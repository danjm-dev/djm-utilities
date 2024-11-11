using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Internal;

namespace DJM.Utilities
{
    public static class Texture2DExtensions
    {
        public static int2 Resolution(this Texture2D texture2D)
        {
            return new int2(texture2D.width, texture2D.height);
        }
        
        public static UnityEngine.Color GetPixel(this Texture2D texture2D, Vector2Int coordinates)
        {
            return texture2D.GetPixel(coordinates.x, coordinates.y);
        }
        
        public static UnityEngine.Color GetPixel(this Texture2D texture2D, int2 coordinates)
        {
            return texture2D.GetPixel(coordinates.x, coordinates.y);
        }

        public static UnityEngine.Color GetPixel(this Texture2D texture2D, Vector2Int coordinates, [DefaultValue("0")] int mipLevel)
        {
            return texture2D.GetPixel(coordinates.x, coordinates.y, mipLevel);
        }
        
        public static UnityEngine.Color GetPixel(this Texture2D texture2D, int2 coordinates, [DefaultValue("0")] int mipLevel)
        {
            return texture2D.GetPixel(coordinates.x, coordinates.y, mipLevel);
        }

        public static void SetPixel(this Texture2D texture2D, Vector2Int coordinates, UnityEngine.Color color)
        {
            texture2D.SetPixel(coordinates.x, coordinates.y, color);
        }
        
        public static void SetPixel(this Texture2D texture2D, int2 coordinates, UnityEngine.Color color)
        {
            texture2D.SetPixel(coordinates.x, coordinates.y, color);
        }

        public static void SetPixel(this Texture2D texture2D, Vector2Int coordinates, UnityEngine.Color color, [DefaultValue("0")] int mipLevel)
        {
            texture2D.SetPixel(coordinates.x, coordinates.y, color, mipLevel);
        }
        
        public static void SetPixel(this Texture2D texture2D, int2 coordinates, UnityEngine.Color color, [DefaultValue("0")] int mipLevel)
        {
            texture2D.SetPixel(coordinates.x, coordinates.y, color, mipLevel);
        }

        public static void SetAll(this Texture2D texture2D, UnityEngine.Color color)
        {
            var pixels = new UnityEngine.Color[texture2D.width * texture2D.height];
            for (var i = 0; i < pixels.Length; i++) pixels[i] = color;
            texture2D.SetPixels(pixels);
        }
    }
}