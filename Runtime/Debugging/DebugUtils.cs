using System.Diagnostics;
using Debug = UnityEngine.Debug;
using Object = UnityEngine.Object;

namespace DJM.Utilities.Debugging
{
    public static class DebugUtils
    {
        [Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
        public static void Log(object message, Object context = null)
        {
            Debug.Log(message, context);
        }
        
        [Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
        public static void LogWarning(object message, Object context = null)
        {
            Debug.LogWarning(message, context);
        }
                
        [Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
        public static void LogError(object message, Object context = null)
        {
            Debug.LogError(message, context);
        }
    }
}