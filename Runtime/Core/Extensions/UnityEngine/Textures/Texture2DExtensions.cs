using System;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;

namespace DJM.Utilities
{
    public static class Texture2DExtensions
    {
        public static byte[] Encode(this Texture2D texture, ImageFormat format, int jpegQuality = 75, Texture2D.EXRFlags exrFlags = Texture2D.EXRFlags.None)
        {
            return format switch
            {
                ImageFormat.PNG => texture.EncodeToPNG(),
                ImageFormat.JPEG => texture.EncodeToJPG(Mathf.Clamp(jpegQuality, 1, 100)),
                ImageFormat.TGA => texture.EncodeToTGA(),
                ImageFormat.EXR => texture.EncodeToEXR(exrFlags),
                _ => throw new ArgumentOutOfRangeException(nameof(format), format, null)
            };
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

        public static void Reinitialize(this Texture2D texture2D, int2 resolution)
        {
            texture2D.Reinitialize(resolution.x, resolution.y);
        }
        
        public static void Reinitialize(this Texture2D texture2D, int2 resolution, GraphicsFormat graphicsFormat, bool hasMipMap)
        {
            texture2D.Reinitialize(resolution.x, resolution.y, graphicsFormat, hasMipMap);
        }
        
        public static void Reinitialize(this Texture2D texture2D, int2 resolution, TextureFormat textureFormat, bool hasMipMap)
        {
            texture2D.Reinitialize(resolution.x, resolution.y, textureFormat, hasMipMap);
        }
        
        public static void Reinitialize(this Texture2D texture2D, Vector2Int resolution)
        {
            texture2D.Reinitialize(resolution.x, resolution.y);
        }
        
        public static void Reinitialize(this Texture2D texture2D, Vector2Int resolution, GraphicsFormat graphicsFormat, bool hasMipMap)
        {
            texture2D.Reinitialize(resolution.x, resolution.y, graphicsFormat, hasMipMap);
        }
        
        public static void Reinitialize(this Texture2D texture2D, Vector2Int resolution, TextureFormat textureFormat, bool hasMipMap)
        {
            texture2D.Reinitialize(resolution.x, resolution.y, textureFormat, hasMipMap);
        }
        
        [Obsolete]
        public static void SetAll(this Texture2D texture2D, UnityEngine.Color color)
        {
            var pixels = new UnityEngine.Color[texture2D.width * texture2D.height];
            for (var i = 0; i < pixels.Length; i++) pixels[i] = color;
            texture2D.SetPixels(pixels);
        }
        
        public static void SetAll<T>(this Texture2D texture2D, T value, int mipLevel = 0) where T : unmanaged
        {
            var pixelCount = texture2D.width * texture2D.height;
            var data = new NativeArray<T>(pixelCount, Allocator.Temp);
            for (var i = 0; i < data.Length; i++) data[i] = value;
            texture2D.SetPixelData(data, mipLevel);
            data.Dispose();
        }
        
        public static void SetAll(this Texture2D texture2D, UnityEngine.Color32 color, int mipLevel = 0)
        {
            SetAll<UnityEngine.Color32>(texture2D, color, mipLevel);
        }
    }
}