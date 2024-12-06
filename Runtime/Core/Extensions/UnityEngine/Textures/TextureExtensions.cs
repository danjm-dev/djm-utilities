using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class TextureExtensions
    {
        public static int2 Resolution(this Texture texture)
        {
            return new int2(texture.width, texture.height);
        }
    }
}