using UnityEngine;

namespace DJM.Utilities.Singletons
{
    public class PersistentSingleton<T> : MonoBehaviour where T : Component
    {
        protected static T instance;
    
        public static bool HasInstance => instance != null;
        public static T TryGetInstance() => HasInstance ? instance : null;

        public static T Instance 
        {
            get 
            {
                if (instance != null) return instance;
                
                instance = FindAnyObjectByType<T>();
                if (instance != null) return instance;
                
                var go = new GameObject($"[{typeof(T).Name}]");
                instance = go.AddComponent<T>();
                return instance;
            }
        }

        /// <summary>
        /// Ensure base.Awake() is called if overriding.
        /// </summary>
        protected virtual void Awake() => InitializeSingleton(); 

        protected virtual void InitializeSingleton() 
        {
            if (!Application.isPlaying) return;
            transform.SetParent(null);
            
            if (instance == null) 
            {
                instance = this as T;
                DontDestroyOnLoad(gameObject);
            }

            if (instance == this) return;
            Destroy(gameObject);
        }
    }
}