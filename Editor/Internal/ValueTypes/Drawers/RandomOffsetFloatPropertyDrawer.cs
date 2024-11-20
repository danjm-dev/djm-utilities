using DJM.Utilities.ValueTypes;
using UnityEditor;
using UnityEngine;

namespace DJM.Utilities.Editor.Internal.ValueTypes
{
    [CustomPropertyDrawer(typeof(RandomOffsetFloat))]
    public class RandomOffsetFloatPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            const float maxFieldWidth = 150f;
            const float maxPlusMinusWidth = 25f;
            
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            
            var baseValueWidth = position.width * 0.475f;
            var plusMinusSymbolWidth = position.width * 0.05f;
            var maxOffsetWidth = position.width * 0.475f;
            
            baseValueWidth = Mathf.Min(baseValueWidth, maxFieldWidth);
            plusMinusSymbolWidth = Mathf.Min(plusMinusSymbolWidth, maxPlusMinusWidth);
            maxOffsetWidth = Mathf.Min(maxOffsetWidth, maxFieldWidth);
            
            var baseValueRect = new Rect(position.x, position.y, baseValueWidth, position.height);
            var plusMinusSymbolRect = new Rect(baseValueRect.xMax, position.y, plusMinusSymbolWidth, position.height);
            var maxOffsetRect = new Rect(plusMinusSymbolRect.xMax, position.y, maxOffsetWidth, position.height);
            
            
            var baseValueProperty = property.FindPropertyRelative("baseValue");
            var maxOffsetProperty = property.FindPropertyRelative("maxOffset");
            
            EditorGUI.PropertyField(baseValueRect, baseValueProperty, GUIContent.none);
            
            var plusMinusStyle = new GUIStyle(EditorStyles.largeLabel)
            {
                alignment = TextAnchor.MiddleCenter,
                fontSize = 22
            };
            
            EditorGUI.LabelField(plusMinusSymbolRect, "±", plusMinusStyle);
            EditorGUI.PropertyField(maxOffsetRect, maxOffsetProperty, GUIContent.none);
        }

    }
}