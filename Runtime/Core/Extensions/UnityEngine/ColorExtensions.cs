using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using DJM.Utilities.RenderingAndVisuals;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class ColorExtensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void GetHSV(this UnityEngine.Color color, out float hue, out float saturation, out float value)
        {
            UnityEngine.Color.RGBToHSV(color, out hue, out saturation, out value);
        }
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float GetHue(this UnityEngine.Color color)
        {
            UnityEngine.Color.RGBToHSV(color, out var hue, out _, out _);
            return hue;
        }
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float GetSaturation(this UnityEngine.Color color)
        {
            UnityEngine.Color.RGBToHSV(color, out _, out var saturation, out _);
            return saturation;
        }
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float GetValue(this UnityEngine.Color color)
        {
            UnityEngine.Color.RGBToHSV(color, out _, out _, out var value);
            return value;
        }
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnityEngine.Color WithRed(this UnityEngine.Color color, float red)
        {
            return new UnityEngine.Color(red, color.g, color.b, color.a);
        }
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnityEngine.Color WithGreen(this UnityEngine.Color color, float green)
        {
            return new UnityEngine.Color(color.r, green, color.b, color.a);
        }
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnityEngine.Color WithBlue(this UnityEngine.Color color, float blue)
        {
            return new UnityEngine.Color(color.r, color.g, blue, color.a);
        }
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnityEngine.Color WithAlpha(this UnityEngine.Color color, float alpha)
        {
            return new UnityEngine.Color(color.r, color.g, color.b, alpha);
        }
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnityEngine.Color WithHue(this UnityEngine.Color color, float hue, bool hdr = false)
        {
            UnityEngine.Color.RGBToHSV(color, out _, out var saturation, out var value);
            return UnityEngine.Color.HSVToRGB(hue, saturation, value, hdr);
        }
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnityEngine.Color WithSaturation(this UnityEngine.Color color, float saturation, bool hdr = false)
        {
            UnityEngine.Color.RGBToHSV(color, out var hue, out _, out var value);
            return UnityEngine.Color.HSVToRGB(hue, saturation, value, hdr);
        }
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnityEngine.Color WithValue(this UnityEngine.Color color, float value, bool hdr = false)
        {
            UnityEngine.Color.RGBToHSV(color, out var hue, out var saturation, out _);
            return UnityEngine.Color.HSVToRGB(hue, saturation, value, hdr);
        }
        
        public static UnityEngine.Color WithComplementaryHue(this UnityEngine.Color color)
        {
            return ColorUtils.GetComplementaryColor(color);
        }
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 AsVector4(this UnityEngine.Color color)
        {
            return color;
        }
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 AsFloat4(this UnityEngine.Color color)
        {
            return new float4(color.r, color.g, color.b, color.a);
        }
    }
}