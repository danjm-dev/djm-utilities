#if UNITY_EDITOR
using System;
using DJM.Utilities.MeshGeneration;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using MathUtils = DJM.Utilities.Math.MathUtils;

namespace DJM.Utilities.CustomGizmos
{
    [InitializeOnLoad]
    internal static class CircleCustomGizmoUtils
    {
        private const int CirclePointCount = 36;
        private const float CircleRadiansPerPoint = MathUtils.PI2 / CirclePointCount;
        
        private static readonly Mesh CircleMesh;
        private static readonly Vector3[] PointBuffer = new Vector3[CirclePointCount];
        
        static CircleCustomGizmoUtils()
        {
            CircleMesh = PrimitiveMeshUtils.GenerateCircleMesh
            (
                1f, 
                math.right(), 
                math.up(), 
                CirclePointCount
            );
        }
        
        public static void DrawCircle
        (
            Vector3 center,
            float radius,
            Vector3 right,
            Vector3 up
        )
        {
            if(radius <= math.EPSILON) return;
            
            MathUtils.GetNormalizedAxes
            (
                right, 
                up, 
                out _, 
                out var validUp, 
                out var validForward
            );
            
            var rotation = Quaternion.LookRotation(validForward, validUp);
            Gizmos.DrawMesh(CircleMesh, center, rotation, Vector3.one.WithZ(0) * radius);
        }
        
        public static void DrawCircleOutline
        (
            Vector3 center, 
            float radius,
            Vector3 right,
            Vector3 up
        )
        {
            if(radius <= Mathf.Epsilon) return;
            
            MathUtils.GetNormalizedAxes
            (
                right, 
                up, 
                out var validRight, 
                out var validUp, 
                out _
            );
            
            var xOffSet = (validRight * radius).AsVector();
            var yOffSet = (validUp * radius).AsVector();
            
            for (var i = 0; i < CirclePointCount; i++)
            {
                var angle = i * CircleRadiansPerPoint;
                var x = Mathf.Cos(angle);
                var y = Mathf.Sin(angle);
                PointBuffer[i] = center + x * xOffSet + y * yOffSet;
            }
            
            Gizmos.DrawLineStrip(new ReadOnlySpan<Vector3>(PointBuffer), true);
        }
    }
}
#endif