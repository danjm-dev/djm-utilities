using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Internal;

namespace DJM.Utilities
{
    public static class Texture3DExtensions
    {
        public static UnityEngine.Color GetPixel(this Texture3D texture3D, Vector3Int coordinates)
        {
            return texture3D.GetPixel(coordinates.x, coordinates.y, coordinates.z);
        }
        
        public static UnityEngine.Color GetPixel(this Texture3D texture3D, int3 coordinates)
        {
            return texture3D.GetPixel(coordinates.x, coordinates.y, coordinates.z);
        }

        public static UnityEngine.Color GetPixel(this Texture3D texture3D, Vector3Int coordinates, [DefaultValue("0")] int mipLevel)
        {
            return texture3D.GetPixel(coordinates.x, coordinates.y, coordinates.z, mipLevel);
        }
        
        public static UnityEngine.Color GetPixel(this Texture3D texture3D, int3 coordinates, [DefaultValue("0")] int mipLevel)
        {
            return texture3D.GetPixel(coordinates.x, coordinates.y, coordinates.z, mipLevel);
        }

        public static void SetPixel(this Texture3D texture3D, Vector3Int coordinates, UnityEngine.Color color)
        {
            texture3D.SetPixel(coordinates.x, coordinates.y, coordinates.z, color);
        }
        
        public static void SetPixel(this Texture3D texture3D, int3 coordinates, UnityEngine.Color color)
        {
            texture3D.SetPixel(coordinates.x, coordinates.y, coordinates.z, color);
        }

        public static void SetPixel(this Texture3D texture3D, Vector3Int coordinates, UnityEngine.Color color, [DefaultValue("0")] int mipLevel)
        {
            texture3D.SetPixel(coordinates.x, coordinates.y, coordinates.z, color, mipLevel);
        }
        
        public static void SetPixel(this Texture3D texture3D, int3 coordinates, UnityEngine.Color color, [DefaultValue("0")] int mipLevel)
        {
            texture3D.SetPixel(coordinates.x, coordinates.y, coordinates.z, color, mipLevel);
        }
        
        public static void SetAll<T>(this Texture3D texture3D, T value, int mipLevel = 0) where T : unmanaged
        {
            var pixelCount = texture3D.width * texture3D.height * texture3D.depth;
            var data = new NativeArray<T>(pixelCount, Allocator.Temp);
            for (var i = 0; i < data.Length; i++) data[i] = value;
            texture3D.SetPixelData(data, mipLevel);
            data.Dispose();
        }
        
        public static void SetAll(this Texture3D texture3D, UnityEngine.Color32 color, int mipLevel = 0)
        {
            SetAll<UnityEngine.Color32>(texture3D, color, mipLevel);
        }
    }
}