﻿using Unity.Burst;
using Unity.Mathematics;

namespace DJM.Utilities.Noise
{
    [BurstCompile]
    public static class SimplexNoiseUtils
    {
        [BurstCompile]
        public static float Sample2D(in float2 position, float scale = 1f)
        {
            ScalePosition(position, scale, out var scaledPosition);
            return noise.snoise(scaledPosition);
        }

        [BurstCompile]
        public static float Sample2DNormalized(in float2 position, in float scale = 1f)
        {
            var output = Sample2D(position, scale);
            NormalizeNoise(ref output);
            return output;
        }

        [BurstCompile]
        public static float Sample2DFractalNormalized(in float2 position, in FractalNoiseSettings settings)
        {
            return Sample2DFractalNormalized
            (
                position, 
                settings.Scale, 
                settings.Octaves, 
                settings.Persistence, 
                settings.Lacunarity
            );
        }
        
        [BurstCompile]
        public static float Sample2DFractalNormalized
        (
            in float2 position, 
            in float scale = 1f, 
            in int octaves = FractalNoseUtils.DefaultOctaves, 
            in float persistence = FractalNoseUtils.DefaultPersistence, 
            in float lacunarity = FractalNoseUtils.DefaultLacunarity
        )
        {
            ScalePosition(position, scale, out var scaledPosition);
            var amplitude = 1f;
            var frequency = 1f;
            var noiseHeight = 0f;
            var maxValue = 0f;
            
            for (var i = 0; i < octaves; i++)
            {
                var sample = scaledPosition * frequency;
                noiseHeight += noise.snoise(sample) * amplitude;
                
                maxValue += amplitude;
                amplitude *= persistence;
                frequency *= lacunarity;
            }

            var output = noiseHeight / maxValue;
            NormalizeNoise(ref output);
            return output;
        }
        
        [BurstCompile]
        public static float Sample3D(in float3 position, float scale = 1f)
        {
            ScalePosition(position, scale, out var scaledPosition);
            return noise.snoise(scaledPosition);
        }
        
        [BurstCompile]
        public static float Sample3DNormalized(in float3 position, float scale = 1f)
        {
            var output = Sample3D(position, scale);
            NormalizeNoise(ref output);
            return output;
        }

        [BurstCompile]
        public static float Sample3DFractalNormalized(in float3 position, in FractalNoiseSettings settings)
        {
            return Sample3DFractalNormalized
            (
                position, 
                settings.Scale, 
                settings.Octaves, 
                settings.Persistence, 
                settings.Lacunarity
            );
        }
        
        [BurstCompile]
        public static float Sample3DFractalNormalized
        (
            in float3 position, 
            in float scale = 1f, 
            int octaves = FractalNoseUtils.DefaultOctaves, 
            float persistence = FractalNoseUtils.DefaultPersistence, 
            float lacunarity = FractalNoseUtils.DefaultLacunarity
        )
        {
            ScalePosition(position, scale, out var scaledPosition);
            var amplitude = 1f;
            var frequency = 1f;
            var noiseHeight = 0f;
            var maxValue = 0f;
            
            for (var i = 0; i < octaves; i++)
            {
                var sample = scaledPosition * frequency;
                noiseHeight += noise.snoise(sample) * amplitude;
                
                maxValue += amplitude;
                amplitude *= persistence;
                frequency *= lacunarity;
            }

            var output = noiseHeight / maxValue;
            NormalizeNoise(ref output);
            return output;
        }
        
        [BurstCompile]
        private static void ScalePosition(in float2 position, float scale, out float2 scaledPosition)
        {
            scaledPosition = position / scale;
        }
        
        [BurstCompile]
        private static void ScalePosition(in float3 position, float scale, out float3 scaledPosition)
        {
            scaledPosition = position / scale;
        }
        
        [BurstCompile]
        private static void NormalizeNoise(ref float noise)
        {
            noise = math.clamp((noise + 1) * 0.5f, 0f, 1f);
        }
    }
}