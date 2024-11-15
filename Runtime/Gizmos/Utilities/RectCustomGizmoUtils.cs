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
    internal static class RectCustomGizmoUtils
    {
        private static readonly Mesh RectMesh;
        private static readonly Vector3[] PointBuffer = new Vector3[4];
        
        static RectCustomGizmoUtils()
        {
            RectMesh = PrimitiveMeshUtils.GenerateRectMesh(1f, math.right(), math.up());
        }
        
        public static void DrawRect(Vector3 position, Vector2 size, RectPivot pivot)
        {
            if(size == Vector2.zero) return;
            var offset = pivot == RectPivot.Center ? Vector3.zero : (size * 0.5f).XYO();
            UnityEngine.Gizmos.DrawMesh(RectMesh, position + offset, Quaternion.identity, size.XYO());
        }
        
        public static void DrawRectOutline(Vector3 position, Vector2 size, RectPivot pivot)
        {
            if(size == Vector2.zero) return;
            
            var xOffset = Vector3.right * size.x;
            var yOffset = Vector3.up * size.y;
            
            var origin = pivot == RectPivot.Origin ? position : position - (size * 0.5f).XYO();
            
            PointBuffer[0] = origin;
            PointBuffer[1] = origin + yOffset;
            PointBuffer[2] = origin + xOffset + yOffset;
            PointBuffer[3] = origin + xOffset;
            
            UnityEngine.Gizmos.DrawLineStrip(new ReadOnlySpan<Vector3>(PointBuffer), true);
        }
    }
}
#endif