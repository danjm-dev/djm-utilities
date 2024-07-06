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
    }
}