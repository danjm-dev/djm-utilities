using System.Diagnostics.Contracts;

using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class Vector2IntExtensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int XX(this Vector2Int v) => new(v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int YX(this Vector2Int v) => new(v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int YY(this Vector2Int v) => new(v.y, v.y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int X0Y(this Vector2Int current, int y = 0) => new(current.x, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int XY0(this Vector2Int current, int z = 0) => new(current.x, current.y, z);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 AsInt(this Vector2Int v) => new(v.x, v.y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 XXAsInt(this Vector2Int v) => new(v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 YXAsInt(this Vector2Int v) => new(v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 YYAsInt(this Vector2Int v) => new(v.y, v.y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 X0YAsInt(this Vector2Int current, int y = 0) => new(current.x, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 XY0AsInt(this Vector2Int current, int z = 0) => new(current.x, current.y, z);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int WithX(this Vector2Int v, int x) => new(x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int WithY(this Vector2Int v, int y) => new(v.x, y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int AddX(this Vector2Int v, int x) => new(v.x + x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int AddY(this Vector2Int v, int y) => new(v.x, v.y + y);
    }
}