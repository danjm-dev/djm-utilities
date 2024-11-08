using System.Diagnostics;
using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    public static partial class Gizmos2
    {
        [Conditional("UNITY_EDITOR")]
        public static void DrawCube(Vector3 center, Vector3 size, UnityEngine.Color? color = null)
        {
#if UNITY_EDITOR
            SetColor(color);
            Gizmos.DrawCube(center, size);
            RevertColor();
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawWireCube(Vector3 center, Vector3 size, UnityEngine.Color? color = null)
        {
#if UNITY_EDITOR
            SetColor(color);
            Gizmos.DrawWireCube(center, size);
            RevertColor();
#endif
        }
    }
}