using System.Diagnostics;
using DJM.Utilities.Coordinates;
using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    public static partial class Gizmos2
    {
        [Conditional("UNITY_EDITOR")]
        public static void DrawGridLines
        (
            Vector3 position, 
            Vector2Int gridResolution, 
            Vector2 cellSize, 
            RectPivot pivot = RectPivot.Center,
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            var originPosition = GetRectOriginPosition(position, gridResolution * cellSize, pivot, plane);
            var (xAxis, yAxis) = Get2DPlaneAxes(plane);
            DrawGridLinesInternal(originPosition, gridResolution, cellSize, xAxis, yAxis, color);
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawGridLines
        (
            Vector2 position, 
            Vector2Int gridResolution, 
            Vector2 cellSize, 
            RectPivot pivot = RectPivot.Center,
            float? positionDepth = null, 
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            var position3D = Get3DPosition(position, plane, positionDepth);
            DrawGridLines(position3D, gridResolution, cellSize, pivot, plane, color);
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawGridNodes
        (
            Vector3 position, 
            Vector2Int gridResolution, 
            Vector2 cellSize, 
            RectPivot pivot = RectPivot.Center,
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            var originPosition = GetRectOriginPosition(position, gridResolution * cellSize, pivot, plane);
            var (xAxis, yAxis) = Get2DPlaneAxes(plane);
            DrawGridNodesInternal(originPosition, gridResolution, cellSize, xAxis, yAxis, color);
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawGridNodes
        (
            Vector2 position, 
            Vector2Int gridResolution, 
            Vector2 cellSize, 
            RectPivot pivot = RectPivot.Center,
            float? positionDepth = null, 
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            var position3D = Get3DPosition(position, plane, positionDepth);
            DrawGridNodes(position3D, gridResolution, cellSize, pivot, plane, color);
#endif
        }

#if UNITY_EDITOR
        private static void DrawGridLinesInternal
        (
            Vector3 originPosition, 
            Vector2Int resolution, 
            Vector2 cellSize,
            Vector3 xAxis,
            Vector3 yAxis,
            UnityEngine.Color? color = null
        )
        {
            if(resolution.x <= 0 || resolution.y <= 0) return;
            if(cellSize.x <= 0 || cellSize.y <= 0) return;
            
            SetColor(color);
            
            for(var x = 0; x <= resolution.x; x++)
            {
                var start = originPosition + xAxis * (x * cellSize.x);
                var end = start + yAxis * (resolution.y * cellSize.y);
                Gizmos.DrawLine(start, end);
            }
            
            for(var y = 0; y <= resolution.y; y++)
            {
                var start = originPosition + yAxis * (y * cellSize.y);
                var end = start + xAxis * (resolution.x * cellSize.x);
                Gizmos.DrawLine(start, end);
            }
            
            RevertColor();
        }
        
        private static void DrawGridNodesInternal
        (
            Vector3 originPosition, 
            Vector2Int resolution, 
            Vector2 cellSize,
            Vector3 xAxis,
            Vector3 yAxis,
            UnityEngine.Color? color = null
        )
        {
            SetColor(color);
            
            if(resolution.x <= 0 || resolution.y <= 0) return;
            if(cellSize.x <= 0 || cellSize.y <= 0) return;

            var cellCount = resolution.x * resolution.y;
            var positionOffset = cellSize * 0.5f;
            
            var normal = Vector3.Cross(xAxis, yAxis);
            var nodeCircleRadius = Mathf.Min(cellSize.x, cellSize.y) * 0.25f;
            
            for (var i = 0; i < cellCount; i++)
            {
                CoordinateUtils.IndexToCoordinates(i, resolution.AsInt(), out var coordinates);
                CoordinateUtils.CoordinatesToPosition(coordinates, cellSize, positionOffset, out var position2D);
                var position = originPosition + xAxis * position2D.x + yAxis * position2D.y;
                DrawCircleInternal(position, normal, nodeCircleRadius);
            }
            
            RevertColor();
        }
#endif
    }
}