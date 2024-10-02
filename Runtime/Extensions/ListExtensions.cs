using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace DJM.Utilities
{
    public static class ListExtensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsValidIndex<T>(this List<T> list, int index) => index >= 0 && index < list.Count;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsValidIndex<T>(this IList<T> list, int index) => index >= 0 && index < list.Count;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsValidIndex<T>(this IReadOnlyList<T> list, int index) => index >= 0 && index < list.Count;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsValidIndex<T>(this T[] array, int index) => index >= 0 && index < array.Length;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsValidIndex<T>(this Span<T> span, int index) => index >= 0 && index < span.Length;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsValidIndex<T>(this ReadOnlySpan<T> span, int index) => index >= 0 && index < span.Length;
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFirstIndex<T>(this List<T> list, int index) => index == 0;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFirstIndex<T>(this IList<T> list, int index) => index == 0;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFirstIndex<T>(this IReadOnlyList<T> list, int index) => index == 0;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFirstIndex<T>(this T[] array, int index) => index == 0;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFirstIndex<T>(this Span<T> span, int index) => index == 0;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFirstIndex<T>(this ReadOnlySpan<T> span, int index) => index == 0;
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLastIndex<T>(this List<T> list, int index) => index == list.Count - 1;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLastIndex<T>(this IList<T> list, int index) => index == list.Count - 1;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLastIndex<T>(this IReadOnlyList<T> list, int index) => index == list.Count - 1;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLastIndex<T>(this T[] array, int index) => index == array.Length - 1;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLastIndex<T>(this Span<T> span, int index) => index == span.Length - 1;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLastIndex<T>(this ReadOnlySpan<T> span, int index) => index == span.Length - 1;
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFirstOrLastIndex<T>(this List<T> list, int index) => index == 0 || index == list.Count - 1;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFirstOrLastIndex<T>(this IList<T> list, int index) => index == 0 || index == list.Count - 1;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFirstOrLastIndex<T>(this IReadOnlyList<T> list, int index) => index == 0 || index == list.Count - 1;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFirstOrLastIndex<T>(this T[] array, int index) => index == 0 || index == array.Length - 1;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFirstOrLastIndex<T>(this Span<T> span, int index) => index == 0 || index == span.Length - 1;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFirstOrLastIndex<T>(this ReadOnlySpan<T> span, int index) => index == 0 || index == span.Length - 1;
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T GetRandom<T>(this List<T> list) => list[UnityEngine.Random.Range(0, list.Count)];
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T GetRandom<T>(this IList<T> list) => list[UnityEngine.Random.Range(0, list.Count)];
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T GetRandom<T>(this IReadOnlyList<T> list) => list[UnityEngine.Random.Range(0, list.Count)];
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T GetRandom<T>(this T[] array) => array[UnityEngine.Random.Range(0, array.Length)];
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T GetRandom<T>(this Span<T> span) => span[UnityEngine.Random.Range(0, span.Length)];
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T GetRandom<T>(this ReadOnlySpan<T> span) => span[UnityEngine.Random.Range(0, span.Length)];
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T>(this List<T> list, Predicate<T> predicate)
        {
            var count = 0;
            for (var i = 0; i < list.Count; i++) if (predicate(list[i])) count++;
            return count;
        }
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T>(this IList<T> list, Predicate<T> predicate)
        {
            var count = 0;
            for (var i = 0; i < list.Count; i++) if (predicate(list[i])) count++;
            return count;
        }
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T>(this IReadOnlyList<T> list, Predicate<T> predicate)
        {
            var count = 0;
            for (var i = 0; i < list.Count; i++) if (predicate(list[i])) count++;
            return count;
        }
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T>(this T[] array, Predicate<T> predicate)
        {
            var count = 0;
            for (var i = 0; i < array.Length; i++) if (predicate(array[i])) count++;
            return count;
        }
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T>(this Span<T> span, Predicate<T> predicate)
        {
            var count = 0;
            for (var i = 0; i < span.Length; i++) if (predicate(span[i])) count++;
            return count;
        }
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T>(this ReadOnlySpan<T> span, Predicate<T> predicate)
        {
            var count = 0;
            for (var i = 0; i < span.Length; i++) if (predicate(span[i])) count++;
            return count;
        }
    }
}