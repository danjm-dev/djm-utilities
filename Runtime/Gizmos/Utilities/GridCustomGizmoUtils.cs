#if UNITY_EDITOR
using DJM.Utilities.Coordinates;
using UnityEngine;

namespace DJM.Utilities.Gizmos
{
    internal static class GridCustomGizmoUtils
    {
        public static void DrawGridLines
        (
            Vector3 originPosition, 
            Vector2Int resolution, 
            Vector2 cellSize
        )
        {
            if(resolution.x <= 0 || resolution.y <= 0) return;
            cellSize = Vector2.Max(cellSize, Vector2.zero);
            
            var gridSize = resolution * cellSize;
            var maxY = originPosition.y + gridSize.y;
            
            for(var x = 0; x <= resolution.x; x++)
            {
                var xPosition = originPosition.x + x * cellSize.x;
                UnityEngine.Gizmos.DrawLine
                (
                    new Vector3(xPosition, originPosition.y, originPosition.z), 
                    new Vector3(xPosition, maxY, originPosition.z)
                );
            }
            
            var maxX = originPosition.x + gridSize.x;
            
            for(var y = 0; y <= resolution.y; y++)
            {
                var yPosition = originPosition.y + y * cellSize.y;
                UnityEngine.Gizmos.DrawLine
                (
                    new Vector3(originPosition.x, yPosition, originPosition.z), 
                    new Vector3(maxX, yPosition, originPosition.z)
                );
            }
        }
        
        // public static void DrawGridLines
        // (
        //     Vector3 position,
        //     Vector3Int resolution,
        //     Vector3 cellSize,
        //     Vector3 right,
        //     Vector3 up,
        //     RectPivot pivot
        // )
        // {
        //     if(resolution.x <= 0 || resolution.y <= 0 || resolution.z <= 0) return;
        //     cellSize = Vector3.Max(cellSize, Vector3.zero);
        //     
        //     var originPosition = GetGridOriginPosition(position, resolution, cellSize, pivot);
        // }
        
        public static void DrawGridNodes
        (
            Vector3 originPosition, 
            Vector2Int resolution, 
            Vector2 cellSize
        )
        {
            if(resolution.x <= 0 || resolution.y <= 0) return;
            cellSize = Vector2.Max(cellSize, Vector2.zero);
            
            var nodeCircleRadius = Mathf.Min(cellSize.x, cellSize.y) * 0.25f;
            
            for (var i = 0; i < resolution.x * resolution.y; i++)
            {
                CoordinateUtils.IndexToCoordinates(i, resolution.AsInt(), out var coordinates);
                CoordinateUtils.CoordinatesToCenterPosition(coordinates, cellSize, out var position);
                CircleCustomGizmoUtils.DrawCircle(originPosition + position.XYO().AsVector(), nodeCircleRadius);
            }
        }
        
        private static Vector3 GetGridOriginPosition
        (
            Vector3 position, 
            Vector2Int resolution, 
            Vector2 cellSize, 
            RectPivot pivot
        )
        {
            return pivot == RectPivot.Origin 
                ? position 
                : position - (resolution * cellSize * 0.5f).XYO();
        }
        
        private static Vector3 GetGridOriginPosition
        (
            Vector3 position, 
            Vector3Int resolution, 
            Vector3 cellSize, 
            RectPivot pivot
        )
        {
            return pivot == RectPivot.Origin 
                ? position 
                : position - position - Vector3.Scale(resolution, cellSize) * 0.5f;
        }
    }
}
#endif