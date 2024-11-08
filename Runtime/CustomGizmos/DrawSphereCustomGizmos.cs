using System.Diagnostics;
using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    public static partial class Gizmos2
    {
        [Conditional("UNITY_EDITOR")]
        public static void DrawSphere(Vector3 center, float radius, UnityEngine.Color? color = null)
        {
#if UNITY_EDITOR
            SetColor(color);
            Gizmos.DrawSphere(center, radius);
            RevertColor();
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawWireSphere(Vector3 center, float radius, UnityEngine.Color? color = null)
        {
#if UNITY_EDITOR
            SetColor(color);
            Gizmos.DrawWireSphere(center, radius);
            RevertColor();
#endif
        }
    }
}