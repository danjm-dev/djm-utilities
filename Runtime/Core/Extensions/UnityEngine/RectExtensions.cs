using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DJM.Utilities
{
    public static class RectExtensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains(this Rect rect, Rect other)
        {
            return rect.Contains(other.min) && rect.Contains(other.max);
        }

        public static Rect WithPadding(this Rect rect, Vector2 padding)
        {
            var clampedPaddingX = Mathf.Clamp(padding.x, 0f, rect.width * 0.5f);
            var clampedPaddingY = Mathf.Clamp(padding.y, 0f, rect.height * 0.5f);
            
            return new Rect
            (
                rect.x + clampedPaddingX,
                rect.y + clampedPaddingY,
                rect.width - 2 * clampedPaddingX,
                rect.height - 2 * clampedPaddingY
            );
        }
        
        public static Rect WithPadding(this Rect rect, float padding)
        {
            return WithPadding(rect, new Vector2(padding, padding));
        }
    }
}