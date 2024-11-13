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
    internal static class RectCustomGizmoUtils
    {
        private static readonly Mesh RectMesh;
        private static readonly Vector3[] PointBuffer = new Vector3[4];
        
        static RectCustomGizmoUtils()
        {
            RectMesh = PrimitiveMeshUtils.GenerateRectMesh(1f, math.right(), math.up());
        }
        
        public static void DrawRect(Vector3 center, Vector2 size, Vector3 horizontalAxis, Vector3 verticalAxis)
        {
            MathUtils.GetValidAxes
            (
                horizontalAxis, 
                verticalAxis, 
                out _, 
                out var up, 
                out var forward
            );
            
            var rotation = Quaternion.LookRotation(forward, up);
            Gizmos.DrawMesh(RectMesh, center, rotation, size.XYO());
        }
        
        public static void DrawRectOutline(Vector3 center, Vector3 normal, Vector2 size)
        {
            if(size == Vector2.zero) return;
            if(normal == Vector3.zero) return;
            
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
            
            Gizmos.DrawLineStrip(new ReadOnlySpan<Vector3>(PointBuffer), true);
        }
    }
}
#endif