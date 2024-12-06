using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DJM.Utilities.Serialization;
using UnityEditor;
using UnityEngine;

namespace DJM.Utilities.Editor.Internal.Serialization.Interfaces
{
    [CustomPropertyDrawer(typeof(InterfaceReference<>))]
    [CustomPropertyDrawer(typeof(InterfaceReference<,>))]
    internal sealed class InterfaceReferencePropertyDrawer : PropertyDrawer
    {
        private const string ObjectFieldName = "objectValue";
        
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) 
        {
            var objectProperty = property.FindPropertyRelative(ObjectFieldName);

            if (!GetArguments(fieldInfo, out var arguments))
            {
                Debug.LogError("Failed to get arguments for InterfaceReference.", property.serializedObject.targetObject);
                return;
            }

            EditorGUI.BeginProperty(position, label, property);

            var assignedObject = EditorGUI.ObjectField(position, label, objectProperty.objectReferenceValue, arguments.ObjectType, true);
            objectProperty.objectReferenceValue = GetAssignedComponent(assignedObject, arguments);

            EditorGUI.EndProperty();
            InterfaceReferenceUtils.OnGUI(position, objectProperty, label, arguments); 
        }
        
        private static bool GetArguments(FieldInfo fieldInfo, out InterfaceArguments arguments) 
        {
            if(TryGetInterfaceArgumentsFromReference(fieldInfo.FieldType, out arguments)) return true;
            if(GetInterfaceArgumentsFromList(fieldInfo.FieldType, out arguments)) return true;
            
            arguments = default;
            return false;
        }

        private static bool TryGetInterfaceArgumentsFromReference(Type type, out InterfaceArguments arguments) 
        {
            arguments = default;
                
            if(type is null) return false;
            if (!type.IsGenericType) return false;

            if (type.GetGenericTypeDefinition() == typeof(InterfaceReference<>))
            {
                if(type.BaseType is null) return false;
                type = type.BaseType;
            }
                
            if (type.GetGenericTypeDefinition() != typeof(InterfaceReference<,>)) return false;
                
            var types = type.GetGenericArguments();
            arguments = new InterfaceArguments(types[1], types[0]);
            return true;
        }
        
        private static bool GetInterfaceArgumentsFromList(Type type, out InterfaceArguments arguments) 
        {
            arguments = default;
            
            if(type is null) return false;
            
            var listInterface = type.GetInterfaces()
                .FirstOrDefault(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IList<>));

            if (listInterface is null) return false;
            
            var elementType = listInterface.GetGenericArguments()[0];
            return TryGetInterfaceArgumentsFromReference(elementType, out arguments);
        }
        
        private static UnityEngine.Object GetAssignedComponent(UnityEngine.Object assignedObject, InterfaceArguments arguments)
        {
            if (assignedObject.OrNull() is null) return null;
            
            if (assignedObject is GameObject gameObject) return gameObject.GetComponent(arguments.InterfaceType);

            return arguments.InterfaceType.IsAssignableFrom(assignedObject.GetType()) 
                ? assignedObject 
                : null;
        }
    }

    internal struct InterfaceArguments
    {
        public readonly Type ObjectType;
        public readonly Type InterfaceType;

        public InterfaceArguments(Type objectType, Type interfaceType)
        {
            Debug.Assert(typeof(UnityEngine.Object).IsAssignableFrom(objectType), $"{nameof(objectType)} needs to be of Type {typeof(UnityEngine.Object)}.");
            Debug.Assert(interfaceType.IsInterface, $"{nameof(interfaceType)} needs to be an interface.");

            ObjectType = objectType;
            InterfaceType = interfaceType;
        }
    }
}