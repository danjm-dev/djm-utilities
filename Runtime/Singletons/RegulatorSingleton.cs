using UnityEngine;

namespace DJM.Utilities.Singletons
{
    public class RegulatorSingleton<T> : MonoBehaviour where T : Component
    {
        protected static T instance;
    
        public static bool HasInstance => instance != null;
        public float InitializationTime { get; private set; }

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
            InitializationTime = Time.time;
            DontDestroyOnLoad(gameObject);

            var oldInstances = FindObjectsByType<T>(FindObjectsSortMode.None);
            
            foreach (var old in oldInstances) 
            {
                if (old.GetComponent<RegulatorSingleton<T>>().InitializationTime < InitializationTime) 
                {
                    Destroy(old.gameObject);
                }
            }

            if (instance == null) instance = this as T;
        }
    }
}