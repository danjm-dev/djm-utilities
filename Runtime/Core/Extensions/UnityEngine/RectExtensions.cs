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
    }
}