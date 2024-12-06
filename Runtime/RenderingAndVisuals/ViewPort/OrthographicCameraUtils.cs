using Unity.Burst;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities.RenderingAndVisuals
{
    [BurstCompile]
    public static class OrthographicCameraUtils
    {
        [BurstCompile]
        public static void GetViewportSize
        (
            in float orthographicSize, 
            out float2 viewportSize
        )
        {
            var screenHeightInUnits = orthographicSize * 2;
            var screenWidthInUnits = screenHeightInUnits * (Screen.width / (float)Screen.height);
            viewportSize = new float2(screenWidthInUnits, screenHeightInUnits);
        }

        [BurstCompile]
        public static void ScreenToWorldPosition
        (
            in float2 screenPosition, 
            in float2 cameraPosition,
            in float orthographicSize,
            in int2 screenResolution,
            out float2 worldPosition
        )
        {
            ScreenSpaceUtils.GetNormalizedScreenPosition(screenPosition, screenResolution, out var normalizedScreenPosition);
            GetViewportSize(orthographicSize, out var viewportSize);
            worldPosition = cameraPosition + (normalizedScreenPosition - 0.5f) * viewportSize;
        }
        
        [BurstDiscard]
        public static float2 ScreenToWorldPosition
        (
            in float2 screenPosition, 
            in float2 cameraPosition,
            in float orthographicSize
        )
        {
            ScreenToWorldPosition
            (
                screenPosition, 
                cameraPosition, 
                orthographicSize, 
                new int2(Screen.width, Screen.height), 
                out var worldPosition
            );
            return worldPosition;
        }
    }
}