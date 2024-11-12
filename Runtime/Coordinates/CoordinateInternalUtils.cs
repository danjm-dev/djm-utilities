using System.Diagnostics;
using DJM.Utilities.Debugging;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;

namespace DJM.Utilities.Coordinates
{
    [BurstCompile]
    internal static class CoordinateInternalUtils
    {
        [BurstCompile]
        [Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
        public static void ValidateNodeArrayResolution<T>
            (in int2 resolution, in NativeArray<T> nodeArray) where T : unmanaged
        {
            if(resolution.x * resolution.y == nodeArray.Length) return;
            DebugUtils.LogError("Node array length does not match resolution");
        }
    }

    [BurstCompile]
    internal static class CoordinateNodeArrayUtils
    {
        [BurstCompile]
        public static bool TestRayHit<T>
        (
            in int2 coordinates, 
            in int2 gridResolution, 
            in NativeArray<T> nodeArray, 
            in int layerMask
        ) where T : unmanaged, ICoordinateRaycastTarget
        {
            if (!CoordinateUtils.IsWithinBoundsInclusive(coordinates, gridResolution)) return false;
            var nodeIndex = CoordinateUtils.CoordinatesToIndex(coordinates, gridResolution);
            return nodeArray[nodeIndex].DoesRayHit(layerMask);
        }
    }
}