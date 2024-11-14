using System;

namespace DJM.Utilities.Color
{
    public static class ColorUtils
    {
        public static void GenerateContrastingColors(UnityEngine.Color[] colors, float saturation = 0.7f, float brightness = 0.6f)
        {
            var hueIncrement = 1.0f / colors.Length;

            for (var i = 0; i < colors.Length; i++)
            {
                var hue = i * hueIncrement;
                colors[i] = UnityEngine.Color.HSVToRGB(hue, saturation, brightness);
            }
        }
        
        public static UnityEngine.Color[] GenerateContrastingColors(int count, float saturation = 0.7f, float brightness = 0.6f)
        {
            if (count <= 0) return Array.Empty<UnityEngine.Color>();
            var results = new UnityEngine.Color[count];
            GenerateContrastingColors(results, saturation, brightness);
            return results;
        }
        
        public static UnityEngine.Color GetComplementaryColor(UnityEngine.Color color)
        {
            UnityEngine.Color.RGBToHSV(color, out var h, out var s, out var v);
            h = (h + 0.5f) % 1;
            return UnityEngine.Color.HSVToRGB(h, s, v);
        }
    }
}