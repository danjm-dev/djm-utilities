#if UNITY_EDITOR
using DJM.Utilities.Coordinates;
using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    internal static class GridCustomGizmoUtils
    {
        public static void DrawGridLines
        (
            Vector3 position, 
            Vector2Int resolution, 
            Vector2 cellSize,
            Vector3 right,
            Vector3 up,
            RectPivot pivot
        )
        {
            if(resolution.x <= 0 || resolution.y <= 0) return;
            if(cellSize.x <= 0 || cellSize.y <= 0) return;
            
            var originPosition = GetGridOriginPosition(position, resolution, cellSize, right, up, pivot);
            
            for(var x = 0; x <= resolution.x; x++)
            {
                var start = originPosition + right * (x * cellSize.x);
                var end = start + up * (resolution.y * cellSize.y);
                Gizmos.DrawLine(start, end);
            }
            
            for(var y = 0; y <= resolution.y; y++)
            {
                var start = originPosition + up * (y * cellSize.y);
                var end = start + right * (resolution.x * cellSize.x);
                Gizmos.DrawLine(start, end);
            }
        }
        
        public static void DrawGridNodes
        (
            Vector3 position, 
            Vector2Int resolution, 
            Vector2 cellSize,
            Vector3 right,
            Vector3 up,
            RectPivot pivot
        )
        {
            if(resolution.x <= 0 || resolution.y <= 0) return;
            if(cellSize.x <= 0 || cellSize.y <= 0) return;

            var originPosition = GetGridOriginPosition(position, resolution, cellSize, right, up, pivot);
            
            var positionOffset = cellSize * 0.5f;
            var nodeCircleRadius = Mathf.Min(cellSize.x, cellSize.y) * 0.25f;
            
            for (var i = 0; i < resolution.x * resolution.y; i++)
            {
                CoordinateUtils.IndexToCoordinates(i, resolution.AsInt(), out var coordinates);
                CoordinateUtils.CoordinatesToPosition(coordinates, cellSize, positionOffset, out var position2D);
                var nodePosition = originPosition + right * position2D.x + up * position2D.y;
                CircleCustomGizmoUtils.DrawCircle(nodePosition, nodeCircleRadius, right, up);
            }
        }
        
        private static Vector3 GetGridOriginPosition
        (
            Vector3 position, 
            Vector2Int resolution, 
            Vector2 cellSize, 
            Vector3 right, 
            Vector3 up, 
            RectPivot pivot
        )
        {
            var gridSize = resolution * cellSize;
            return pivot == RectPivot.Origin 
                ? position 
                : position - right * (gridSize.x * 0.5f) - up * (gridSize.y * 0.5f);
        }
    }
}
#endif