using DJM.Utilities.Color;

namespace DJM.Utilities.Extensions
{
    internal static class ColorExtensions
    {
        public static UnityEngine.Color Complementary(this UnityEngine.Color color)
        {
            return ColorUtils.GetComplementaryColor(color);
        }
    }
}