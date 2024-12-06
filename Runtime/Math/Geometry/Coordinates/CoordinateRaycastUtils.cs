using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace DJM.Utilities.Math.Geometry
{
    [BurstCompile]
    public static class CoordinateRaycastUtils
    {
        [BurstCompile]
        public static bool Raycast<T>
        (
            in float2 origin,
            in float2 direction, 
            in float distance,
            in int layerMask,
            in float2 coordinateUnitSize,
            in int2 gridResolution,
            in NativeArray<T> nodeArray,
            out CoordinateRaycastHitResults2D hitResults
        ) where T : unmanaged, ICoordinateRaycastTarget
        {
            var normalizedDirection = math.normalizesafe(direction, Direction2D.Right);
            var clampedDistance = math.max(distance, 0);
            
            CoordinateInternalUtils.ValidateNodeArrayResolution(gridResolution, nodeArray);
            
            CoordinateUtils.PositionToCoordinates(origin, coordinateUnitSize, out var coordinates);
            CalculateUnitStepSize(coordinateUnitSize, normalizedDirection, out var unitStepSize);
            
            CalculateStartingConditions
            (
                origin, 
                coordinates, 
                coordinateUnitSize, 
                normalizedDirection, 
                unitStepSize, 
                out var rayLengthX, 
                out var rayLengthY, 
                out var coordinateOffsetX, 
                out var coordinateOffsetY
            );
            
            var currentDistance = 0f;
            
            while (currentDistance <= clampedDistance)
            {
                if (CoordinateNodeArrayUtils.TestRayHit(coordinates, in gridResolution, in nodeArray, in layerMask))
                {
                    var hitPosition = origin + normalizedDirection * currentDistance;
                    hitResults = new CoordinateRaycastHitResults2D(coordinates, hitPosition);
                    return true;
                }
                
                if (rayLengthX < rayLengthY)
                {
                    coordinates += coordinateOffsetX;
                    currentDistance = rayLengthX;
                    rayLengthX += unitStepSize.x;
                }
                else
                {
                    coordinates += coordinateOffsetY;
                    currentDistance = rayLengthY;
                    rayLengthY += unitStepSize.y;
                }
            }

            hitResults = default;
            return false;
        }
        
        [BurstCompile]
        public static void GetIntersectingCoordinates
        (
            in float2 origin, 
            in float2 direction, 
            in float distance,
            in float2 coordinateUnitSize,
            in NativeList<int2> results
        )
        {
            var normalizedDirection = math.normalizesafe(direction, Direction2D.Right);
            var clampedDistance = math.max(distance, 0);
            
            CoordinateUtils.PositionToCoordinates
            (
                origin, 
                coordinateUnitSize, 
                out var coordinates
            );
            
            CalculateUnitStepSize(coordinateUnitSize, normalizedDirection, out var unitStepSize);
            
            CalculateStartingConditions
            (
                origin, 
                coordinates, 
                coordinateUnitSize, 
                normalizedDirection, 
                unitStepSize, 
                out var xRayLength, 
                out var yRayLength, 
                out var xCoordsOffset, 
                out var yCoordsOffset
            );
            
            var currentDistance = 0f;
            results.Clear();
            
            while (currentDistance <= clampedDistance)
            {
                results.Add(coordinates);
                
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
            }
        }

        [BurstCompile]
        public static void GetIntersectingCoordinates
        (
            in float2 from, 
            in float2 to,
            in float2 coordinateUnitSize,
            in NativeList<int2> results
        )
        {
            var offset = to - from;
            var distance = math.length(offset);
            var direction = math.normalizesafe(offset, Direction2D.Right);
            GetIntersectingCoordinates(from, direction, distance, coordinateUnitSize, results);
        }
        
        [BurstCompile]
        private static void CalculateUnitStepSize(in float2 unitSize, in float2 rayDirection, out float2 unitStepSize)
        {
            unitStepSize = new float2
            (
                math.abs(unitSize.x / rayDirection.x),
                math.abs(unitSize.y / rayDirection.y)
            );
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