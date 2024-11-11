using Unity.Burst;
using Unity.Mathematics;

namespace DJM.Utilities.Coordinates
{
    /// <summary>
    /// Provides utility methods for coordinate transformations and calculations.
    /// </summary>
    [BurstCompile]
    public static class CoordinateUtils
    {
        /// <summary>
        /// Converts a 1D position to coordinates.
        /// </summary>
        /// <param name="position">The position to convert.</param>
        /// <param name="unitSize">The size of a unit.</param>
        /// <param name="coordinates">The resulting 1D coordinates.</param>
        [BurstCompile]
        public static void PositionToCoordinates
        (
            in float position, 
            in float unitSize, 
            out int coordinates
        )
        {
            coordinates = (int)math.floor(position / unitSize);
        }
        
        /// <summary>
        /// Converts a 2D position to coordinates.
        /// </summary>
        /// <param name="position">The position to convert.</param>
        /// <param name="unitSize">The size of a unit.</param>
        /// <param name="coordinates">The resulting 2D coordinates.</param>
        [BurstCompile]
        public static void PositionToCoordinates
        (
            in float2 position, 
            in float2 unitSize, 
            out int2 coordinates
        )
        {
            coordinates = (int2)math.floor(position / unitSize);
        }
        
        /// <summary>
        /// Converts a 3D position to coordinates.
        /// </summary>
        /// <param name="position">The position to convert.</param>
        /// <param name="unitSize">The size of a unit.</param>
        /// <param name="coordinates">The resulting 3D coordinates.</param>
        [BurstCompile]
        public static void PositionToCoordinates
        (
            in float3 position, 
            in float3 unitSize, 
            out int3 coordinates
        )
        {
            coordinates = (int3)math.floor(position / unitSize);
        }
        
        /// <summary>
        /// Converts 1D coordinates to a position.
        /// </summary>
        /// <param name="coordinates">The coordinates to convert.</param>
        /// <param name="unitSize">The size of a unit.</param>
        /// <param name="position">The resulting 1D position.</param>
        [BurstCompile]
        public static void CoordinatesToPosition
        (
            in int coordinates, 
            in float unitSize, 
            out float position
        )
        {
            position = coordinates * unitSize;
        }
        
        /// <summary>
        /// Converts 2D coordinates to a position.
        /// </summary>
        /// <param name="coordinates">The coordinates to convert.</param>
        /// <param name="unitSize">The size of a unit.</param>
        /// <param name="position">The resulting 2D position.</param>
        [BurstCompile]
        public static void CoordinatesToPosition
        (
            in int2 coordinates, 
            in float2 unitSize, 
            out float2 position
        )
        {
            position = coordinates * unitSize;
        }
        
        /// <summary>
        /// Converts 3D coordinates to a position.
        /// </summary>
        /// <param name="coordinates">The coordinates to convert.</param>
        /// <param name="unitSize">The size of a unit.</param>
        /// <param name="position">The resulting 3D position.</param>
        [BurstCompile]
        public static void CoordinatesToPosition
        (
            in int3 coordinates, 
            in float3 unitSize, 
            out float3 position
        )
        {
            position = coordinates * unitSize;
        }
        
        /// <summary>
        /// Converts 1D coordinates to a position with an offset.
        /// </summary>
        /// <param name="coordinates">The coordinates to convert.</param>
        /// <param name="unitSize">The size of a unit.</param>
        /// <param name="offset">The amount to offset the position by.</param>
        /// <param name="position">The resulting 1D position.</param>
        [BurstCompile]
        public static void CoordinatesToPosition
        (
            in int coordinates, 
            in float unitSize, 
            in float offset,
            out float position
        )
        {
            position = coordinates * unitSize + offset;
        }
        
        /// <summary>
        /// Converts 2D coordinates to a position with an offset.
        /// </summary>
        /// <param name="coordinates">The coordinates to convert.</param>
        /// <param name="unitSize">The size of a unit.</param>
        /// <param name="offset">The amount to offset the position by.</param>
        /// <param name="position">The resulting 2D position.</param>
        [BurstCompile]
        public static void CoordinatesToPosition
        (
            in int2 coordinates, 
            in float2 unitSize, 
            in float2 offset,
            out float2 position
        )
        {
            position = coordinates * unitSize + offset;
        }
        
        /// <summary>
        /// Converts 3D coordinates to a position.
        /// </summary>
        /// <param name="coordinates">The coordinates to convert.</param>
        /// <param name="unitSize">The size of a unit.</param>
        /// /// <param name="offset">The amount to offset the position by.</param>
        /// <param name="position">The resulting 3D position.</param>
        [BurstCompile]
        public static void CoordinatesToPosition
        (
            in int3 coordinates, 
            in float3 unitSize, 
            in float3 offset,
            out float3 position
        )
        {
            position = coordinates * unitSize + offset;
        }
           
        /// <summary>
        /// Converts 1D coordinates to its center position.
        /// </summary>
        /// <param name="coordinates">The coordinates to convert.</param>
        /// <param name="unitSize">The size of a unit.</param>
        /// <param name="position">The resulting 1D position.</param>
        [BurstCompile]
        public static void CoordinatesToCenterPosition
        (
            in int coordinates, 
            in float unitSize, 
            out float position
        )
        {
            CoordinatesToPosition(coordinates, unitSize, unitSize * 0.5f, out position);
        }
        
        /// <summary>
        /// Converts 2D coordinates to its center position.
        /// </summary>
        /// <param name="coordinates">The coordinates to convert.</param>
        /// <param name="unitSize">The size of a unit.</param>
        /// <param name="position">The resulting 2D position.</param>
        [BurstCompile]
        public static void CoordinatesToCenterPosition
        (
            in int2 coordinates, 
            in float2 unitSize, 
            out float2 position
        )
        {
            CoordinatesToPosition(coordinates, unitSize, unitSize * 0.5f, out position);
        }
        
        /// <summary>
        /// Converts 3D coordinates to its center position.
        /// </summary>
        /// <param name="coordinates">The coordinates to convert.</param>
        /// <param name="unitSize">The size of a unit.</param>
        /// <param name="position">The resulting 3D position.</param>
        [BurstCompile]
        public static void CoordinatesToCenterPosition
        (
            in int3 coordinates, 
            in float3 unitSize, 
            out float3 position
        )
        {
            CoordinatesToPosition(coordinates, unitSize, unitSize * 0.5f, out position);
        }
        
        /// <summary>
        /// Converts 1D coordinates to its center position with an offset.
        /// </summary>
        /// <param name="coordinates">The coordinates to convert.</param>
        /// <param name="unitSize">The size of a unit.</param>
        /// <param name="offset">The amount to offset the position by.</param>
        /// <param name="position">The resulting 1D position.</param>
        [BurstCompile]
        public static void CoordinatesToCenterPosition
        (
            in int coordinates, 
            in float unitSize, 
            in float offset,
            out float position
        )
        {
            CoordinatesToPosition(coordinates, unitSize, offset + unitSize * 0.5f, out position);
        }
        
        /// <summary>
        /// Converts 2D coordinates to its center position with an offset.
        /// </summary>
        /// <param name="coordinates">The coordinates to convert.</param>
        /// <param name="unitSize">The size of a unit.</param>
        /// <param name="offset">The amount to offset the position by.</param>
        /// <param name="position">The resulting 2D position.</param>
        [BurstCompile]
        public static void CoordinatesToCenterPosition
        (
            in int2 coordinates, 
            in float2 unitSize, 
            in float2 offset,
            out float2 position
        )
        {
            CoordinatesToPosition(coordinates, unitSize, offset + unitSize * 0.5f, out position);
        }
        
        /// <summary>
        /// Converts 3D coordinates to its center position with an offset.
        /// </summary>
        /// <param name="coordinates">The coordinates to convert.</param>
        /// <param name="unitSize">The size of a unit.</param>
        /// /// <param name="offset">The amount to offset the position by.</param>
        /// <param name="position">The resulting 3D position.</param>
        [BurstCompile]
        public static void CoordinatesToCenterPosition
        (
            in int3 coordinates, 
            in float3 unitSize, 
            in float3 offset,
            out float3 position
        )
        {
            CoordinatesToPosition(coordinates, unitSize, offset + unitSize * 0.5f, out position);
        }
        
        /// <summary>
        /// Gets the scale factor for 2D coordinates scale conversion.
        /// </summary>
        /// <remarks>
        /// The value returned from this is intended to be used in <see cref="o:ScaleCoordinates"/>.
        /// </remarks>
        /// <param name="fromUnitSize">The original unit size.</param>
        /// <param name="toUnitSize">The target unit size.</param>
        /// <param name="scaleFactor">The resulting scale factor.</param>
        [BurstCompile]
        public static void GetCoordinateScaleFactor(in float2 fromUnitSize, in float2 toUnitSize, out float2 scaleFactor)
        {
            scaleFactor = fromUnitSize / toUnitSize;
        }
        
        /// <summary>
        /// Gets the scale factor for 3D coordinates scale conversion.
        /// </summary>
        /// <remarks>
        /// The value returned from this is intended to be used in the <see cref="o:ScaleCoordinates"/>.
        /// </remarks>
        /// <param name="fromUnitSize">The original unit size.</param>
        /// <param name="toUnitSize">The target unit size.</param>
        /// <param name="scaleFactor">The resulting scale factor.</param>
        [BurstCompile]
        public static void GetCoordinateScaleFactor(in float3 fromUnitSize, in float3 toUnitSize, out float3 scaleFactor)
        {
            scaleFactor = fromUnitSize / toUnitSize;
        }
        
        /// <summary>
        /// Scale 2D coordinates by a given factor.
        /// </summary>
        /// <remarks>
        /// This is useful for finding equivalent coordinates of a different size, e.g. chunk coordinates of tile coordinates.
        /// </remarks>
        /// <param name="coordinates">Coordinates to be scaled</param>
        /// <param name="scaleFactor">Factor to scale the coordinates by. Can be calculated from <see cref="o:GetCoordinateScaleFactor"/>.></param>
        /// <param name="scaledCoordinates">Resulting scaled coordinates.</param>
        [BurstCompile]
        public static void ScaleCoordinates
        (
            in int2 coordinates, 
            in float2 scaleFactor,
            out int2 scaledCoordinates
        )
        {
            scaledCoordinates = (int2)math.floor(coordinates * scaleFactor);
        }
        
        /// <summary>
        /// Scale 3D coordinates by a given factor.
        /// </summary>
        /// <remarks>
        /// This is useful for finding equivalent coordinates of a different size, e.g. chunk coordinates of tile coordinates.
        /// </remarks>
        /// <param name="coordinates">Coordinates to be scaled</param>
        /// <param name="scaleFactor">Factor to scale the coordinates by. Can be calculated from <see cref="o:GetCoordinateScaleFactor"/>.></param>
        /// <param name="scaledCoordinates">Resulting scaled coordinates.</param>
        [BurstCompile]
        public static void ScaleCoordinates
        (
            in int3 coordinates, 
            in float3 scaleFactor,
            out int3 scaledCoordinates
        )
        {
            scaledCoordinates = (int3)math.floor(coordinates * scaleFactor);
        }
        
        /// <summary>
        /// Transforms 2D coordinates from local space to world space.
        /// </summary>
        /// <param name="localCoordinates">Local coordinates to be transformed.</param>
        /// <param name="origin">Origin of local coordinates in world space.</param>
        /// <param name="worldCoordinates">Resulting world coordinates.</param>
        [BurstCompile]
        public static void TransformCoordinates
        (
            in int2 localCoordinates, 
            in int2 origin,
            out int2 worldCoordinates
        )
        {
            worldCoordinates = localCoordinates + origin;
        }
        
        /// <summary>
        /// Transforms 3D coordinates from local space to world space.
        /// </summary>
        /// <param name="localCoordinates">Local coordinates to be transformed.</param>
        /// <param name="origin">Origin of local coordinates in world space.</param>
        /// <param name="worldCoordinates">Resulting world coordinates.</param>
        [BurstCompile]
        public static void TransformCoordinates
        (
            in int3 localCoordinates, 
            in int3 origin,
            out int3 worldCoordinates
        )
        {
            worldCoordinates = localCoordinates + origin;
        }

        /// <summary>
        /// Transforms 2D coordinates from world space to local space.
        /// </summary>
        /// <param name="localCoordinates">World coordinates to be transformed.</param>
        /// <param name="origin">Origin of local coordinates in world space.</param>
        /// <param name="worldCoordinates">Resulting local coordinates.</param>
        [BurstCompile]
        public static void InverseTransformCoordinates
        (
            in int2 worldCoordinates, 
            in int2 origin,
            out int2 localCoordinates
        )
        {
            localCoordinates = worldCoordinates - origin;
        }
        
        /// <summary>
        /// Transforms 3D coordinates from world space to local space.
        /// </summary>
        /// <param name="localCoordinates">World coordinates to be transformed.</param>
        /// <param name="origin">Origin of local coordinates in world space.</param>
        /// <param name="worldCoordinates">Resulting local coordinates.</param>
        [BurstCompile]
        public static void InverseTransformCoordinates
        (
            in int3 worldCoordinates, 
            in int3 origin,
            out int3 localCoordinates
        )
        {
            localCoordinates = worldCoordinates - origin;
        }

        /// <summary>
        /// Gets the 2D resolution of the grid made by bounds.
        /// </summary>
        /// <param name="boundsMin">Bounds minimum.</param>
        /// <param name="boundsMax">Bounds maximum.</param>
        /// <param name="boundsResolution">Bounds grid resolution.</param>
        [BurstCompile]
        public static void GetBoundsResolution(in int2 boundsMin, in int2 boundsMax, out int2 boundsResolution)
        {
            boundsResolution = boundsMax - boundsMin + 1;
        }
        
        /// <summary>
        /// Gets the 3D resolution of the grid made by the bounds.
        /// </summary>
        /// <param name="boundsMin">Bounds minimum.</param>
        /// <param name="boundsMax">Bounds maximum.</param>
        /// <param name="boundsResolution">Bounds grid resolution.</param>
        [BurstCompile]
        public static void GetBoundsResolution(in int3 boundsMin, in int3 boundsMax, out int3 boundsResolution)
        {
            boundsResolution = boundsMax - boundsMin + 1;
        }
        
        /// <summary>
        /// Checks if 2D coordinates are within given bounds, including bounds edge coordinates.
        /// </summary>
        /// <param name="coordinates">Coordinates to check.</param>
        /// <param name="boundsMin">Bounds minimum.</param>
        /// <param name="boundsMax">Bounds maximum.</param>
        /// <returns>True if coordinates are within bounds, false otherwise.</returns>
        [BurstCompile]
        public static bool IsWithinBoundsInclusive(in int2 coordinates, in int2 boundsMin, in int2 boundsMax)
        {
            return coordinates >= boundsMin is { x: true, y: true } 
                   && coordinates <= boundsMax is { x: true, y: true };
        }
        
        /// <summary>
        /// Checks if 2D coordinates are within bounds of a grid with given resolution, including bounds edge coordinates.
        /// </summary>
        /// <remarks>
        /// Min bounds are assumed to be zero.
        /// </remarks>
        /// <param name="coordinates">Coordinates to check.</param>
        /// <param name="resolution">Resolution of grid.</param>
        /// <returns>True if coordinates are within bounds, false otherwise.</returns>
        [BurstCompile]
        public static bool IsWithinBoundsInclusive(in int2 coordinates, in int2 resolution)
        {
            return IsWithinBoundsInclusive(coordinates, int2.zero, resolution - 1);
        }
        
        /// <summary>
        /// Checks if 3D coordinates are within given bounds, including bounds edge coordinates.
        /// </summary>
        /// <param name="coordinates">Coordinates to check.</param>
        /// <param name="boundsMin">Bounds minimum.</param>
        /// <param name="boundsMax">Bounds maximum.</param>
        /// <returns>True if coordinates are within bounds, false otherwise.</returns>
        [BurstCompile]
        public static bool IsWithinBoundsInclusive(in int3 coordinates, in int3 boundsMin, in int3 boundsMax)
        {
            return coordinates >= boundsMin is { x: true, y: true, z: true } 
                   && coordinates <= boundsMax is { x: true, y: true, z: true };
        }
        
        /// <summary>
        /// Checks if 3D coordinates are within bounds of a grid with given resolution, including bounds edge coordinates.
        /// </summary>
        /// <remarks>
        /// Min bounds are assumed to be zero.
        /// </remarks>
        /// <param name="coordinates">Coordinates to check.</param>
        /// <param name="resolution">Resolution of grid.</param>
        /// <returns>True if coordinates are within bounds, false otherwise.</returns>
        [BurstCompile]
        public static bool IsWithinBoundsInclusive(in int3 coordinates, in int3 resolution)
        {
            return IsWithinBoundsInclusive(coordinates, int3.zero, resolution - 1);
        }
        
        /// <summary>
        /// Checks if 2D coordinates are within given bounds, excluding bounds edge coordinates.
        /// </summary>
        /// <param name="coordinates">Coordinates to check.</param>
        /// <param name="boundsMin">Bounds minimum.</param>
        /// <param name="boundsMax">Bounds maximum.</param>
        /// <returns>True if coordinates are within bounds, false otherwise.</returns>
        [BurstCompile]
        public static bool IsWithinBoundsExclusive(in int2 coordinates, in int2 boundsMin, in int2 boundsMax)
        {
            return coordinates > boundsMin is { x: true, y: true } 
                   && coordinates < boundsMax is { x: true, y: true };
        }
        
        /// <summary>
        /// Checks if 2D coordinates are within bounds of a grid with given resolution, excluding bounds edge coordinates.
        /// </summary>
        /// <remarks>
        /// Min bounds are assumed to be zero.
        /// </remarks>
        /// <param name="coordinates">Coordinates to check.</param>
        /// <param name="resolution">Resolution of grid.</param>
        /// <returns>True if coordinates are within bounds, false otherwise.</returns>
        [BurstCompile]
        public static bool IsWithinBoundsExclusive(in int2 coordinates, in int2 resolution)
        {
            return IsWithinBoundsExclusive(coordinates, int2.zero, resolution - 1);
        }
        
        /// <summary>
        /// Checks if 3D coordinates are within given bounds, excluding bounds edge coordinates.
        /// </summary>
        /// <param name="coordinates">Coordinates to check.</param>
        /// <param name="boundsMin">Bounds minimum.</param>
        /// <param name="boundsMax">Bounds maximum.</param>
        /// <returns>True if coordinates are within bounds, false otherwise.</returns>
        [BurstCompile]
        public static bool IsWithinBoundsExclusive(in int3 coordinates, in int3 boundsMin, in int3 boundsMax)
        {
            return coordinates > boundsMin is { x: true, y: true, z: true } 
                   && coordinates < boundsMax is { x: true, y: true, z: true } ;
        }
        
        /// <summary>
        /// Checks if 3D coordinates are within bounds of a grid with given resolution, excluding bounds edge coordinates.
        /// </summary>
        /// <remarks>
        /// Min bounds are assumed to be zero.
        /// </remarks>
        /// <param name="coordinates">Coordinates to check.</param>
        /// <param name="resolution">Resolution of grid.</param>
        /// <returns>True if coordinates are within bounds, false otherwise.</returns>
        [BurstCompile]
        public static bool IsWithinBoundsExclusive(in int3 coordinates, in int3 resolution)
        {
            return IsWithinBoundsExclusive(coordinates, int3.zero, resolution - 1);
        }
        
        /// <summary>
        /// Checks if 2D coordinates are on the edge of given bounds.
        /// </summary>
        /// <param name="coordinates">Coordinates to check.</param>
        /// <param name="boundsMin">Bounds minimum.</param>
        /// <param name="boundsMax">Bounds maximum.</param>
        /// <returns>True if coordinates are on the edge of bounds, false otherwise.</returns>
        [BurstCompile]
        public static bool IsOnBoundsEdge(in int2 coordinates, in int2 boundsMin, in int2 boundsMax)
        {
            var minimumOnBounds = coordinates == boundsMin;
            if (minimumOnBounds.x || minimumOnBounds.y) return true;
            
            var maximumOnBounds = coordinates == boundsMax;
            return maximumOnBounds.x || maximumOnBounds.y;
        }
        
        /// <summary>
        /// Checks if 2D coordinates are on the edge of a grid with given resolution.
        /// </summary>
        /// <remarks>
        /// Min bounds are assumed to be zero.
        /// </remarks>
        /// <param name="coordinates">Coordinates to check.</param>
        /// <param name="resolution">Resolution of grid.</param>
        /// <returns>True if coordinates are on the edge of bounds, false otherwise.</returns>
        [BurstCompile]
        public static bool IsOnBoundsEdge(in int2 coordinates, in int2 resolution)
        {
            return IsOnBoundsEdge(coordinates, int2.zero, resolution - 1);
        }
        
        /// <summary>
        /// Checks if 3D coordinates are on the edge of given bounds.
        /// </summary>
        /// <param name="coordinates">Coordinates to check.</param>
        /// <param name="boundsMin">Bounds minimum.</param>
        /// <param name="boundsMax">Bounds maximum.</param>
        /// <returns>True if coordinates are on the edge of bounds, false otherwise.</returns>
        [BurstCompile]
        public static bool IsOnBoundsEdge(in int3 coordinates, in int3 boundsMin, in int3 boundsMax)
        {
            var minimumOnBounds = coordinates == boundsMin;
            if (minimumOnBounds.x || minimumOnBounds.y || minimumOnBounds.z) return true;
            
            var maximumOnBounds = coordinates == boundsMax;
            return maximumOnBounds.x || maximumOnBounds.y || maximumOnBounds.z;
        }
        
        /// <summary>
        /// Checks if 3D coordinates are on the edge of a grid with given resolution.
        /// </summary>
        /// <remarks>
        /// Min bounds are assumed to be zero.
        /// </remarks>
        /// <param name="coordinates">Coordinates to check.</param>
        /// <param name="resolution">Resolution of grid.</param>
        /// <returns>True if coordinates are on the edge of bounds, false otherwise.</returns>
        [BurstCompile]
        public static bool IsOnBoundsEdge(in int3 coordinates, in int3 resolution)
        {
            return IsOnBoundsEdge(coordinates, int3.zero, resolution - 1);
        }
        
        /// <summary>
        /// Converts an index to 2D coordinates.
        /// </summary>
        /// <param name="index">The index to convert.</param>
        /// <param name="resolution">The resolution of the grid.</param>
        /// <param name="coordinates">The resulting coordinates.</param>
        [BurstCompile]
        public static void IndexToCoordinates(in int index, in int2 resolution, out int2 coordinates)
        {
            coordinates = new int2
            (
                index % resolution.x, 
                index / resolution.x
            );
        }
        
        /// <summary>
        /// Converts an index to 2D coordinates using bitwise operations.
        /// </summary>
        /// <remarks>
        /// To use this overload each axis of grid resolution must be a power of 2. e.g. 2, 4, 8, 16, 32 etc.
        /// </remarks>>
        /// <param name="index">The index to convert.</param>
        /// <param name="indexingData">Indexing data used in bitwise operations. Can be generated from <see cref="o:GetBitwiseIndexingData"/>.></param>
        /// <param name="maxCoordinates">The max coordinates of the grid, which is one less than the grid resolution on each axis.</param>
        /// <param name="coordinates">The resulting coordinates.</param>
        [BurstCompile]
        public static void IndexToCoordinates
        (
            in int index, 
            in BitwiseIndexingData2D indexingData,
            in int2 maxCoordinates, 
            out int2 coordinates
        )
        {
            coordinates = new int2
            (
                index & maxCoordinates.x, 
                (index >> indexingData.XCoordinateResolutionLog2) & maxCoordinates.y
            );
        }
        
        /// <summary>
        /// Converts an index to 3D coordinates.
        /// </summary>
        /// <param name="index">The index to convert.</param>
        /// <param name="resolution">The resolution of the grid.</param>
        /// <param name="coordinates">The resulting coordinates.</param>
        [BurstCompile]
        public static void IndexToCoordinates(in int index, in int3 resolution, out int3 coordinates)
        {
            coordinates = new int3
            (
                index % resolution.x, 
                index / resolution.x % resolution.y,
                index / (resolution.x * resolution.y)
            );
        }
        
        /// <summary>
        /// Converts an index to 3D coordinates using bitwise operations.
        /// </summary>
        /// <remarks>
        /// To use this overload each axis of grid resolution must be a power of 2. e.g. 2, 4, 8, 16, 32 etc.
        /// </remarks>>
        /// <param name="index">The index to convert.</param>
        /// <param name="indexingData">Indexing data used in bitwise operations. Can be generated from <see cref="o:GetBitwiseIndexingData"/>.></param>
        /// <param name="maxCoordinates">The max coordinates of the grid, which is one less than the grid resolution on each axis.</param>
        /// <param name="coordinates">The resulting coordinates.</param>
        [BurstCompile]
        public static void IndexToCoordinates
        (
            in int index,
            in BitwiseIndexingData3D indexingData,
            in int3 maxCoordinates,
            out int3 coordinates
        )
        {
            coordinates = new int3
            (
                index & maxCoordinates.x, 
                (index >> indexingData.XCoordinateResolutionLog2) & maxCoordinates.y, 
                (index >> indexingData.XYCoordinateResolutionLog2Sum) & maxCoordinates.z
            );
        }
        
        /// <summary>
        /// Converts 2D coordinates to an index.
        /// </summary>
        /// <param name="coordinates">The coordinates to convert.</param>
        /// <param name="resolution">The resolution of the grid.</param>
        /// <returns>The resulting Index</returns>
        [BurstCompile]
        public static int CoordinatesToIndex(in int2 coordinates, in int2 resolution)
        {
            return coordinates.x + coordinates.y * resolution.x;
        }
        
        /// <summary>
        /// Converts 2D coordinates to an index using bitwise operations.
        /// </summary>
        /// <remarks>
        /// To use this overload each axis of grid resolution must be a power of 2. e.g. 2, 4, 8, 16, 32 etc.
        /// </remarks>>
        /// <param name="coordinates">The coordinates to convert.</param>
        /// <param name="indexingData">Indexing data used in bitwise operations. Can be generated from <see cref="o:GetBitwiseIndexingData"/>.></param>
        /// <returns>The resulting Index</returns>
        [BurstCompile]
        public static int CoordinatesToIndex(in int2 coordinates, in BitwiseIndexingData2D indexingData)
        {
            return coordinates.x + (coordinates.y << indexingData.XCoordinateResolutionLog2);
        }
        
        /// <summary>
        /// Converts 3D coordinates to an index.
        /// </summary>
        /// <param name="coordinates">The coordinates to convert.</param>
        /// <param name="resolution">The resolution of the grid.</param>
        /// <returns>The resulting Index</returns>
        [BurstCompile]
        public static int CoordinatesToIndex(in int3 coordinates, in int3 resolution)
        {
            return coordinates.x + coordinates.y * resolution.x + coordinates.z * resolution.x * resolution.y;
        }
        
        /// <summary>
        /// Converts 3D coordinates to an index using bitwise operations.
        /// </summary>
        /// <remarks>
        /// To use this overload each axis of grid resolution must be a power of 2. e.g. 2, 4, 8, 16, 32 etc.
        /// </remarks>>
        /// <param name="coordinates">The coordinates to convert.</param>
        /// <param name="indexingData">Indexing data used in bitwise operations. Can be generated from <see cref="o:GetBitwiseIndexingData"/>.></param>
        /// <returns>The resulting Index</returns>
        [BurstCompile]
        public static int CoordinatesToIndex(in int3 coordinates, in BitwiseIndexingData3D indexingData)
        {
            return coordinates.x + (coordinates.y << indexingData.XCoordinateResolutionLog2) + (coordinates.z << indexingData.XYCoordinateResolutionLog2Sum);
        }
        
        /// <summary>
        /// Checks if a 2D resolution is valid for bitwise indexing. To be valid each axis must be a power of 2.
        /// </summary>
        /// <param name="resolution">The resolution to check.</param>
        /// <returns>True if the resolution is valid.</returns>
        [BurstCompile]
        public static bool IsResolutionValidForBitwiseIndexing(in int2 resolution)
        {
            var valid = math.ispow2(resolution);
            return valid is { x: true, y: true };
        }
        
        /// <summary>
        /// Checks if a 3D resolution is valid for bitwise indexing. To be valid each axis must be a power of 2.
        /// </summary>
        /// <param name="resolution">The resolution to check.</param>
        /// <returns>True if the resolution is valid.</returns>
        [BurstCompile]
        public static bool IsResolutionValidForBitwiseIndexing(in int3 resolution)
        {
            var valid = math.ispow2(resolution);
            return valid is { x: true, y: true, z: true };
        }
        
        /// <summary>
        /// Creates a valid 2D resolution for bitwise indexing from an input resolution.
        /// The result will be the same size or larger than the input.
        /// </summary>
        /// <param name="resolution">The input resolution.</param>
        /// <param name="validResolution">The validated resolution.</param>
        [BurstCompile]
        public static void GetValidBitwiseIndexingResolution(in int2 resolution, out int2 validResolution)
        {
            validResolution = resolution;
            
            if(IsResolutionValidForBitwiseIndexing(resolution)) return;
            
            validResolution.x = (int) math.pow(2, math.ceillog2(resolution.x));
            validResolution.y = (int) math.pow(2, math.ceillog2(resolution.y));
        }
        
        /// <summary>
        /// Creates a valid 3D resolution for bitwise indexing from an input resolution.
        /// The result will be the same size or larger than the input.
        /// </summary>
        /// <param name="resolution">The input resolution.</param>
        /// <param name="validResolution">The validated resolution.</param>
        [BurstCompile]
        public static void GetValidBitwiseIndexingResolution(in int3 resolution, out int3 validResolution)
        {
            validResolution = resolution;
            
            if(IsResolutionValidForBitwiseIndexing(resolution)) return;
            
            validResolution.x = (int) math.pow(2, math.ceillog2(resolution.x));
            validResolution.y = (int) math.pow(2, math.ceillog2(resolution.y));
            validResolution.z = (int) math.pow(2, math.ceillog2(resolution.z));
        }
        
        /// <summary>
        /// Create 2D bitwise indexing data.
        /// </summary>
        /// <param name="resolution">The resolution of the grid.</param>
        /// <param name="indexingData">Resulting indexing data</param>
        [BurstCompile]
        public static void GetBitwiseIndexingData(in int2 resolution, out BitwiseIndexingData2D indexingData)
        {
            indexingData = new BitwiseIndexingData2D(math.floorlog2(resolution.x));
        }
        
        /// <summary>
        /// Create 3D bitwise indexing data.
        /// </summary>
        /// <param name="resolution">The resolution of the grid.</param>
        /// <param name="indexingData">Resulting indexing data</param>
        [BurstCompile]
        public static void GetBitwiseIndexingData(in int3 resolution, out BitwiseIndexingData3D indexingData)
        {
            var resolutionXLog2 = math.floorlog2(resolution.x);
            var resolutionYLog2 = math.floorlog2(resolution.y);
            indexingData = new BitwiseIndexingData3D(resolutionXLog2, resolutionXLog2 + resolutionYLog2);
        }
        
        /// <summary>
        /// Struct containing data required for bitwise indexing of 2D coordinates.
        /// </summary>
        public readonly struct BitwiseIndexingData2D
        {
            public readonly int XCoordinateResolutionLog2;
            
            internal BitwiseIndexingData2D(int xCoordinateResolutionLog2)
            {
                XCoordinateResolutionLog2 = xCoordinateResolutionLog2;
            }

            public static BitwiseIndexingData2D Create(in int2 gridResolution)
            {
                GetBitwiseIndexingData(gridResolution, out var indexingData);
                return indexingData;
            }
        }
        
        /// <summary>
        /// Struct containing data required for bitwise indexing of 3D coordinates.
        /// </summary>
        public readonly struct BitwiseIndexingData3D
        {
            public readonly int XCoordinateResolutionLog2;
            public readonly int XYCoordinateResolutionLog2Sum;
            
            internal BitwiseIndexingData3D(int xCoordinateResolutionLog2, int xyCoordinateResolutionLog2Sum)
            {
                XCoordinateResolutionLog2 = xCoordinateResolutionLog2;
                XYCoordinateResolutionLog2Sum = xyCoordinateResolutionLog2Sum;
            }
            
            public static BitwiseIndexingData3D Create(in int3 gridResolution)
            {
                GetBitwiseIndexingData(gridResolution, out var indexingData);
                return indexingData;
            }
        }
    }
}