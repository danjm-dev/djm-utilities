using System;
using System.Diagnostics;
using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    public static partial class Gizmos2
    {
        [Conditional("UNITY_EDITOR")]
        public static void DrawRect
        (
            Vector3 center, 
            Vector3 normal, 
            Vector2 size, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            SetColor(color);
            DrawRectInternal(center, normal, size);
            RevertColor();
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawRectXY
        (
            Vector2 center, 
            Vector2 size, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            SetColor(color);
            DrawRectInternal(center.XY0(), Vector3.forward, size);
            RevertColor();
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawRectXZ
        (
            Vector2 center, 
            Vector2 size, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            SetColor(color);
            DrawRectInternal(center.X0Y(), Vector3.up, size);
            RevertColor();
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        private static void DrawRectInternal(Vector3 center, Vector3 normal, Vector2 size)
        {
#if UNITY_EDITOR
            if(size == Vector2.zero) return;
            if(normal == Vector3.zero) return;
            
            normal = normal.normalized;
            
            var referenceVector = (Mathf.Abs(Vector3.Dot(normal, Vector3.up)) < 0.99f) ? Vector3.up : Vector3.forward;
            var xDirection = Vector3.Cross(normal, referenceVector).normalized;
            var yDirection = Vector3.Cross(xDirection, normal).normalized;
            
            var xOffset = xDirection * size.x;
            var yOffset = yDirection * size.y;
            
            var origin = center - xOffset * 0.5f - yOffset * 0.5f;
            
            PointBuffer[0] = origin;
            PointBuffer[1] = origin + yOffset;
            PointBuffer[2] = origin + xOffset + yOffset;
            PointBuffer[3] = origin + xOffset;
            
            Gizmos.DrawLineStrip(new ReadOnlySpan<Vector3>(PointBuffer, 0, 4), true);
#endif
        }
    }
}