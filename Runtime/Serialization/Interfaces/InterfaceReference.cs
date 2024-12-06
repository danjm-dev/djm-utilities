using System;
using UnityEngine;

namespace DJM.Utilities.Serialization
{
    [Serializable]
    public class InterfaceReference<TInterface, TObject> : ISerializationCallbackReceiver
        where TObject : UnityEngine.Object where TInterface : class
    {
        [SerializeField, HideInInspector] private TObject objectValue;
        private TInterface _interfaceValue;
        
        public TInterface Value
        {
            get => _interfaceValue;
            set
            {
                if (value == null)
                {
                    _interfaceValue = null;
                    return;
                }
                
                if (value is not TObject)
                {
                    throw new ArgumentException($"{value} needs to be of type {nameof(TObject)}.");
                }
                
                _interfaceValue = value;
            }
        }

        public InterfaceReference() { }
        public InterfaceReference(TInterface @interface) => Value = @interface;
        
        public void OnBeforeSerialize()
        {
            if (_interfaceValue == null)
            {
                objectValue = null;
                return;
            }
            
            objectValue = _interfaceValue as TObject;
            
            if (objectValue == null)
            {
                Debug.LogError($"{_interfaceValue} is not of type {nameof(TObject)}");
            }
        }

        public void OnAfterDeserialize()
        {
            if (objectValue == null)
            {
                _interfaceValue = null;
                return;
            }

            if (objectValue is not TInterface @interface)
            {
                Debug.LogError($"{objectValue} is not of type {nameof(TInterface)}");
                return;
            }
            
            _interfaceValue = @interface;
        }
    }

    [Serializable]
    public class InterfaceReference<TInterface> : InterfaceReference<TInterface, UnityEngine.Object>
        where TInterface : class { }
}