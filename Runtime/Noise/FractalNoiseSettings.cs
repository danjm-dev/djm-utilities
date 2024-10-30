using System;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities.Noise
{
    [Serializable]
    public struct FractalNoiseSettings
    {
        [SerializeField, Min(math.EPSILON)] private float scale;
        [SerializeField, Min(FractalNoseUtils.MinOctaves)] private int octaves;
        [SerializeField, Range(FractalNoseUtils.MinPersistence, FractalNoseUtils.MaxPersistence)] private float persistence;
        [SerializeField, Min(FractalNoseUtils.MinLacunarity)] private float lacunarity;
        
        public float Scale => scale;
        public int Octaves => octaves;
        public float Persistence => persistence;
        public float Lacunarity => lacunarity;
        
        public FractalNoiseSettings(float scale, int octaves, float persistence, float lacunarity)
        {
            this.scale = math.max(scale, math.EPSILON);
            this.octaves = math.max(octaves, FractalNoseUtils.MinOctaves);
            this.persistence = math.clamp(persistence, FractalNoseUtils.MinPersistence, FractalNoseUtils.MaxPersistence);
            this.lacunarity = math.max(lacunarity, FractalNoseUtils.MinLacunarity);
        }
        
        public static FractalNoiseSettings Default => new
        (
            1f, 
            FractalNoseUtils.DefaultOctaves, 
            FractalNoseUtils.DefaultPersistence, 
            FractalNoseUtils.DefaultLacunarity
        );
    }
}