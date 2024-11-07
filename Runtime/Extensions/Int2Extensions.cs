using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class Int2Extensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 X0Y(this int2 v, int y = 0) => new(v.x, y, v.y);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 XY0(this int2 v, int z = 0) => new(v.x, v.y, z);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int AsVector(this int2 v) => new(v.x, v.y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int X0YAsVector(this int2 v, int y = 0) => new(v.x, y, v.y);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int XY0AsVector(this int2 v, int z = 0) => new(v.x, v.y, z);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 WithX(this int2 v, int x) => new(x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 WithY(this int2 v, int y) => new(v.x, y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 AddX(this int2 v, int x) => new(v.x + x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 AddY(this int2 v, int y) => new(v.x, v.y + y);
    }
}