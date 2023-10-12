using UnityEngine;

namespace DJM.Utilities.Noise
{
    public static class NoiseGenerator
    {
        public static float[,] GenerateMap(int width, int height, int seed, float scale, int octaves, float persistence, float lacunarity, Vector2 offset) 
        {
            width = Mathf.Max(1, width);
            height = Mathf.Max(1, height);
            scale = Mathf.Max(0.0001f, scale);
            octaves = Mathf.Max(1, octaves);
            lacunarity = Mathf.Max(1, lacunarity);
            persistence = Mathf.Clamp01(persistence);
            
            var noiseMap = new float[width, height];
            
            Random.InitState(seed);
            var octaveOffsets = new Vector2[octaves];
            for (var i = 0; i < octaveOffsets.Length; i++)
            {
                var offsetX = Random.Range(-100000f, 100000f) + offset.x;
                var offsetY = Random.Range(-100000f, 100000f) + offset.y;
                octaveOffsets[i] = new Vector2(offsetX, offsetY);
            }
            
            var maxNoiseHeight = float.MinValue;
            var minNoiseHeight = float.MaxValue;
            
            var halfWidth = width * 0.5f;
            var halfHeight = height * 0.5f;

            for (var y = 0; y < height; y++) 
            {
                var yCoord = y - halfHeight;
                for (var x = 0; x < width; x++) 
                {
                    var xCoord = x - halfWidth;
                    var amplitude = 1f;
                    var frequency = 1f;
                    var noiseHeight = 0f;
                    
                    for (var i = 0; i < octaves; i++)
                    {
                        var sampleX = xCoord / scale * frequency + octaveOffsets[i].x;
                        var sampleY = yCoord / scale * frequency + octaveOffsets[i].y;

                        noiseHeight += (Mathf.PerlinNoise(sampleX, sampleY) * 2 - 1) * amplitude;
                        
                        amplitude *= persistence;
                        frequency *= lacunarity;
                    }
                    
                    if(noiseHeight > maxNoiseHeight) maxNoiseHeight = noiseHeight;
                    else if(noiseHeight < minNoiseHeight) minNoiseHeight = noiseHeight;
                    
                    noiseMap[x, y] = noiseHeight;
                }
            }

            // normalise
            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    noiseMap[x, y] = Mathf.InverseLerp(minNoiseHeight, maxNoiseHeight, noiseMap[x, y]);
                }
            }

            return noiseMap;
        }
    }
}