using Unity.Burst;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities.RenderingAndVisuals
{
    [BurstCompile]
    public static class ScreenSpaceUtils
    {
        [BurstCompile]
        public static void GetNormalizedScreenPosition(in float2 screenPosition, in int2 resolution, out float2 normalizedScreenPosition)
        {
            normalizedScreenPosition = new float2
            (
                math.clamp(screenPosition.x / resolution.x, 0f, 1f),
                math.clamp(screenPosition.y / resolution.y, 0f, 1f)
            );
        }
        
        [BurstDiscard]
        public static float2 GetNormalizedScreenPosition(in float2 screenPosition)
        {
            GetNormalizedScreenPosition
            (
                screenPosition, 
                new int2(Screen.width, Screen.height), 
                out var normalizedScreenPosition
            );
            return normalizedScreenPosition;
        }
    }
}