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
        
        public static void DrawRect(Vector3 position, Vector2 size, Vector3 right, Vector3 up, RectPivot pivot)
        {
            size = Vector2.Max(size, Vector2.zero);
            if(size == Vector2.zero) return;
            
            MathUtils.GetNormalizedAxes
            (
                right, 
                up, 
                out var validRight, 
                out var validUp, 
                out var validForward
            );
            
            var rotation = Quaternion.LookRotation(validForward, validUp);
            position = pivot == RectPivot.Origin 
                ? position + validRight.AsVector() * size.x * 0.5f + validUp.AsVector() * size.y * 0.5f 
                : position;
            Gizmos.DrawMesh(RectMesh, position, rotation, size.XYO());
        }
        
        public static void DrawRectOutline(Vector3 position, Vector2 size, Vector3 right, Vector3 up, RectPivot pivot)
        {
            size = Vector2.Max(size, Vector2.zero);
            if(size == Vector2.zero) return;
            
            MathUtils.GetNormalizedAxes
            (
                right, 
                up, 
                out var validRight, 
                out var validUp, 
                out _
            );
            
            var xOffset = validRight.AsVector() * size.x;
            var yOffset = validUp.AsVector() * size.y;
            
            var origin = pivot == RectPivot.Origin ? position : position - xOffset * 0.5f - yOffset * 0.5f;
            
            PointBuffer[0] = origin;
            PointBuffer[1] = origin + yOffset;
            PointBuffer[2] = origin + xOffset + yOffset;
            PointBuffer[3] = origin + xOffset;
            
            Gizmos.DrawLineStrip(new ReadOnlySpan<Vector3>(PointBuffer), true);
        }
    }
}
#endif