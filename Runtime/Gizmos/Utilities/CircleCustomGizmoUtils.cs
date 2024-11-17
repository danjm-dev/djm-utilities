#if UNITY_EDITOR
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
        
        public static void DrawEclipse(Vector3 center, Vector2 axisRadii)
        {
            if(axisRadii == Vector2.zero) return;
            UnityEngine.Gizmos.DrawMesh
            (
                CircleMesh, 
                center, 
                Quaternion.identity, 
                axisRadii.XYO()
            );
        }
        
        public static void DrawCircle(Vector3 center, float radius)
        {
            DrawEclipse(center, new Vector2(radius, radius));
        }
        
        public static void DrawEclipseOutline(Vector3 center, Vector2 axisRadii)
        {
            if(axisRadii == Vector2.zero) return;
            
            for (var i = 0; i < CirclePointCount; i++)
            {
                var angle = i * CircleRadiansPerPoint;
                MathUtils.GetDirection(angle, out var direction);
                var radius = MathUtils.GetEclipseRadius(direction, axisRadii);
                PointBuffer[i] = center + (direction * radius).XYO().AsVector3();
            }
            
            UnityEngine.Gizmos.DrawLineStrip(new ReadOnlySpan<Vector3>(PointBuffer), true);
        }
        
        public static void DrawCircleOutline(Vector3 center, float radius)
        {
            DrawEclipseOutline(center, new Vector2(radius, radius));
        }
    }
}
#endif