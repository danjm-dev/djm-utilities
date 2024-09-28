using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace DJM.Utilities
{
    internal static class ListExtensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsValidIndex<T>(this IList<T> list, int index) => index >= 0 && index < list.Count;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsValidIndex<T>(this IReadOnlyList<T> list, int index) => index >= 0 && index < list.Count;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsValidIndex<T>(this T[] array, int index) => index >= 0 && index < array.Length;
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLastIndex<T>(this IList<T> list, int index) => index == list.Count - 1;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLastIndex<T>(this IReadOnlyList<T> list, int index) => index == list.Count - 1;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLastIndex<T>(this T[] array, int index) => index == array.Length - 1;
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFirstOrLastIndex<T>(this IList<T> list, int index) => index == 0 || index == list.Count - 1;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFirstOrLastIndex<T>(this IReadOnlyList<T> list, int index) => index == 0 || index == list.Count - 1;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFirstOrLastIndex<T>(this T[] array, int index) => index == 0 || index == array.Length - 1;
    }
}