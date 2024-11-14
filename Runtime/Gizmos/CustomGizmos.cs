using UnityEditor;

namespace DJM.Utilities.Gizmos
{
    public static class CustomGizmos
    {
        public static readonly IGizmoContext Instance;
        
        static CustomGizmos()
        {
#if UNITY_EDITOR
            Instance = new CustomGizmoContext();
#else
            Instance = new DefaultGizmoContext();
#endif
        }

#if UNITY_EDITOR
        [InitializeOnLoadMethod]
        private static void Initialize() => Instance.Dispose();
#endif
    }
}