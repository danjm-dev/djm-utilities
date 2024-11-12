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
            DrawRectOutlineInternal(center, normal, size);
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawRect
        (
            Vector2 center, 
            Vector2 size, 
            float? positionDepth = null, 
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            DrawRectOutlineInternal(Get3DPosition(center, plane, positionDepth), Get2DPlaneNormal(plane), size, color);
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawRect
        (
            Vector3 center, 
            Vector2 size, 
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            DrawRectOutlineInternal(center, Get2DPlaneNormal(plane), size, color);
#endif
        }
        
#if UNITY_EDITOR
        private static void DrawRectOutlineInternal
        (
            Vector3 center, 
            Vector3 normal, 
            Vector2 size, 
            UnityEngine.Color? color = null
        )
        {
            if(size == Vector2.zero) return;
            if(normal == Vector3.zero) return;
            
            SetColor(color);
            
            normal = normal.normalized;
            
            var referenceVector = Mathf.Abs(Vector3.Dot(normal, Vector3.up)) < 0.99f ? Vector3.up : Vector3.forward;
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

            RevertColor();
        }
        
        // private static void DrawRectFilledInternal(Vector3 center, Vector3 normal, Vector2 size)
        // {
        //
        //
        //     
        // }
#endif
    }
}