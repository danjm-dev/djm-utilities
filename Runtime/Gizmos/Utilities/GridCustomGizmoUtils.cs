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
            if(cellSize == Vector2.zero) return;
            
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
        
        public static void DrawGridLines
        (
            Vector3 originPosition, 
            Vector3Int resolution, 
            Vector3 cellSize
        )
        {
            if(resolution.x <= 0 || resolution.y <= 0) return;
            cellSize = Vector3.Max(cellSize, Vector3.zero);
            if(cellSize == Vector3.zero) return;
            
            var gridSize = Vector3.Scale(resolution, cellSize);
            var maxY = originPosition.y + gridSize.y;
            var maxX = originPosition.x + gridSize.x;
            
            for (var z = 0; z <= resolution.z; z++)
            {
                var zPosition = originPosition.z + z * cellSize.z;
                
                for(var x = 0; x <= resolution.x; x++)
                {
                    var xPosition = originPosition.x + x * cellSize.x;
                    UnityEngine.Gizmos.DrawLine
                    (
                        new Vector3(xPosition, originPosition.y, zPosition), 
                        new Vector3(xPosition, maxY, zPosition)
                    );
                }
                
                for(var y = 0; y <= resolution.y; y++)
                {
                    var yPosition = originPosition.y + y * cellSize.y;
                    UnityEngine.Gizmos.DrawLine
                    (
                        new Vector3(originPosition.x, yPosition, zPosition), 
                        new Vector3(maxX, yPosition, zPosition)
                    );
                }
            }
            
            var maxZ = originPosition.z + gridSize.z;
            
            for (var x = 0; x <= resolution.x; x++)
            {
                var xPosition = originPosition.x + x * cellSize.x;
                
                for(var y = 0; y <= resolution.y; y++)
                {
                    var yPosition = originPosition.y + y * cellSize.y;
                    UnityEngine.Gizmos.DrawLine
                    (
                        new Vector3(xPosition, yPosition, originPosition.z), 
                        new Vector3(xPosition, yPosition, maxZ)
                    );
                }
            }
        }
        
        public static void DrawGridNodes
        (
            Vector3 originPosition, 
            Vector2Int resolution, 
            Vector2 cellSize
        )
        {
            if(resolution.x <= 0 || resolution.y <= 0) return;
            cellSize = Vector2.Max(cellSize, Vector2.zero);
            if(cellSize == Vector2.zero) return;
            
            var nodeCircleRadius = Mathf.Min(cellSize.x, cellSize.y) * 0.25f;
            
            for (var i = 0; i < resolution.x * resolution.y; i++)
            {
                CoordinateUtils.IndexToCoordinates(i, resolution.AsInt2(), out var coordinates);
                CoordinateUtils.CoordinatesToCenterPosition(coordinates, cellSize, out var position);
                CircleCustomGizmoUtils.DrawCircle(originPosition + position.XYO().AsVector3(), nodeCircleRadius);
            }
        }
        
        public static void DrawGridNodes
        (
            Vector3 originPosition, 
            Vector3Int resolution, 
            Vector3 cellSize
        )
        {
            if(resolution.x <= 0 || resolution.y <= 0) return;
            cellSize = Vector3.Max(cellSize, Vector3.zero);
            if(cellSize == Vector3.zero) return;
            
            var nodeRadius = Mathf.Min(Mathf.Min(cellSize.x, cellSize.y), cellSize.z) * 0.25f;
            
            for (var i = 0; i < resolution.x * resolution.y * resolution.z; i++)
            {
                CoordinateUtils.IndexToCoordinates(i, resolution.AsInt3(), out var coordinates);
                CoordinateUtils.CoordinatesToCenterPosition(coordinates, cellSize, out var position);
                UnityEngine.Gizmos.DrawSphere(originPosition + position.AsVector3(), nodeRadius);
            }
        }
    }
}
#endif