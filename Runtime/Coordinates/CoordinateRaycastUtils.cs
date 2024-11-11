using DJM.Utilities.Math;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace DJM.Utilities.Coordinates
{
    [BurstCompile]
    public static class CoordinateRaycastUtils
    {
        [BurstCompile]
        public static void GetIntersectingCoordinates
        (
            in float2 originPosition, 
            in float2 direction, 
            in float range,
            in float2 coordinatesUnitSize,
            in float2 coordinatesOrigin,
            in NativeList<int2> results
        )
        {
            var localPosition = originPosition - coordinatesOrigin;
            CoordinateUtils.PositionToCoordinates
            (
                localPosition, 
                coordinatesUnitSize, 
                out var coordinates
            );
            
            var unitStepSize = new float2
            (
                math.abs(coordinatesUnitSize.x / direction.x),
                math.abs(coordinatesUnitSize.y / direction.y)
            );
            
            CalculateStartingConditions
            (
                localPosition, 
                coordinates, 
                coordinatesUnitSize, 
                direction, 
                unitStepSize, 
                out var xRayLength, 
                out var yRayLength, 
                out var xCoordsOffset, 
                out var yCoordsOffset
            );


            
            var currentDistance = 0f;
            
            results.Clear();
            results.Add(coordinates);
            
            while (currentDistance < range)
            {
                if (xRayLength < yRayLength)
                {
                    coordinates += xCoordsOffset;
                    currentDistance = xRayLength;
                    xRayLength += unitStepSize.x;
                }
                else
                {
                    coordinates += yCoordsOffset;
                    currentDistance = yRayLength;
                    yRayLength += unitStepSize.y;
                }
                
                if(currentDistance > range) break;
                
                results.Add(coordinates);
                
                //var hitPosition = originPosition + direction * currentDistance;
            }
        }

        [BurstCompile]
        private static void CalculateStartingConditions
        (
            in float2 localPosition,
            in int2 coordinates,
            in float2 coordinatesUnitSize,
            in float2 direction,
            in float2 unitStepSize,
            out float rayLengthX, 
            out float rayLengthY, 
            out int2 coordinateOffsetX, 
            out int2 coordinateOffsetY
        )
        {
            var offsetFromCoordinatesMin = localPosition - coordinates * coordinatesUnitSize;
            var offsetFromCoordinatesMax = coordinatesUnitSize - offsetFromCoordinatesMin;

            offsetFromCoordinatesMin /= coordinatesUnitSize;
            offsetFromCoordinatesMax /= coordinatesUnitSize;
            
            if (direction.x < 0)
            {
                rayLengthX = offsetFromCoordinatesMin.x * unitStepSize.x;
                coordinateOffsetX = Offset2D.Left;
            }
            else
            {
                rayLengthX = offsetFromCoordinatesMax.x * unitStepSize.x;
                coordinateOffsetX = Offset2D.Right;
            }
            
            if (direction.y < 0)
            {
                rayLengthY = offsetFromCoordinatesMin.y * unitStepSize.y;
                coordinateOffsetY = Offset2D.Down;
            }
            else
            {
                rayLengthY = offsetFromCoordinatesMax.y * unitStepSize.y;
                coordinateOffsetY = Offset2D.Up;
            }
        }
    }
}