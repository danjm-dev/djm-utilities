﻿#if UNITY_EDITOR
using System;
using DJM.Utilities.MeshGeneration;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using MathUtils = DJM.Utilities.Math.MathUtils;

namespace DJM.Utilities.Gizmos
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
        
        public static void DrawCircle(Vector3 center, float radius)
        {
            if(radius <= math.EPSILON) return;
            UnityEngine.Gizmos.DrawMesh
            (
                CircleMesh, 
                center, 
                Quaternion.identity, 
                (Vector2.one * radius).XYO()
            );
        }
        
        public static void DrawCircleOutline(Vector3 center, float radius)
        {
            if(radius <= Mathf.Epsilon) return;
            
            var xOffSet = Vector3.right * radius;
            var yOffSet = Vector3.up * radius;
            
            for (var i = 0; i < CirclePointCount; i++)
            {
                var angle = i * CircleRadiansPerPoint;
                var x = Mathf.Cos(angle);
                var y = Mathf.Sin(angle);
                PointBuffer[i] = center + x * xOffSet + y * yOffSet;
            }
            
            UnityEngine.Gizmos.DrawLineStrip(new ReadOnlySpan<Vector3>(PointBuffer), true);
        }
    }
}
#endif