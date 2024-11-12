using System;
using System.Diagnostics;
using DJM.Utilities.Math;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    public static partial class Gizmos2
    {
        [Conditional("UNITY_EDITOR")]
        public static void DrawCircle(Vector3 center, Vector3 normal, float radius, UnityEngine.Color? color = null)
        {
#if UNITY_EDITOR
            SetColor(color);
            DrawCircleInternal(center, normal, radius);
            RevertColor();
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawCircle(Vector2 center, float radius, UnityEngine.Color? color = null)
        {
#if UNITY_EDITOR
            SetColor(color);
            DrawCircleInternal(center.XY0(_depth2D), Vector3.forward, radius);
            RevertColor();
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawCircleXY(Vector2 center, float radius, UnityEngine.Color? color = null)
        {
#if UNITY_EDITOR
            SetColor(color);
            DrawCircleInternal(center.XY0(_depth2D), Vector3.forward, radius);
            RevertColor();
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawCircleXZ(Vector2 center, float radius, UnityEngine.Color? color = null)
        {
#if UNITY_EDITOR
            SetColor(color);
            DrawCircleInternal(center.X0Y(_depth2D), Vector3.up, radius);
            RevertColor();
#endif
        }
        
#if UNITY_EDITOR       
        private static void DrawCircleInternal(Vector3 center, Vector3 normal, float radius)
        {
            const int pointCount = 32;
            const float radiansPerPoint = MathUtils.PI2 / pointCount;
            
            if(radius <= Mathf.Epsilon) return;
            if(normal == Vector3.zero) return;
            
            normal = normal.normalized;
            var xDirection = normal != Vector3.up
                ? Vector3.Cross(normal, Vector3.up).normalized
                : Vector3.Cross(normal, Vector3.right).normalized;
            var yDirection = Vector3.Cross(normal, xDirection).normalized;
            
            for (var i = 0; i < pointCount; i++)
            {
                var angle = i * radiansPerPoint;
                var x = Mathf.Cos(angle);
                var y = Mathf.Sin(angle);
                PointBuffer[i] = center + x * xDirection * radius + y * yDirection * radius;
            }
            
            Gizmos.DrawLineStrip(new ReadOnlySpan<Vector3>(PointBuffer, 0, pointCount), true);

        }
#endif
    }
}