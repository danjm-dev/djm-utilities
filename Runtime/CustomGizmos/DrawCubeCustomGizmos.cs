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
        public static void DrawCube
        (
            Vector2 center, 
            Vector3 size, 
            float? positionDepth = null, 
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            
            var position = Get3DPosition(center, plane, positionDepth);
            DrawCube(position, size, color);
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
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawWireCube
        (
            Vector2 center, 
            Vector3 size, 
            float? positionDepth = null, 
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            
            var position = Get3DPosition(center, plane, positionDepth);
            DrawWireCube(position, size, color);
#endif
        }
    }
}