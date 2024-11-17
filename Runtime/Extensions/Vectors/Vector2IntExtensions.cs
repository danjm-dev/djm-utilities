using System;
using System.Diagnostics.Contracts;

using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class Vector2IntExtensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector3Int X0Y(this Vector2Int current, int y = 0) => new(current.x, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector3Int XY0(this Vector2Int current, int z = 0) => new(current.x, current.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2Int XXAsInt(this Vector2Int v) => new(v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2Int YXAsInt(this Vector2Int v) => new(v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2Int YYAsInt(this Vector2Int v) => new(v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector3Int X0YAsInt(this Vector2Int current, int y = 0) => new(current.x, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector3Int XY0AsInt(this Vector2Int current, int z = 0) => new(current.x, current.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static int2 AsInt(this Vector2Int v) => new(v.x, v.y);
        
        
        
        
        

        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 AsInt2(this Vector2Int v) => new(v.x, v.y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int With(this Vector2Int v, int? x = null, int? y = null) => new(x ?? v.x, y ?? v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int WithX(this Vector2Int v, int x) => new(x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int WithY(this Vector2Int v, int y) => new(v.x, y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int AddX(this Vector2Int v, int x) => new(v.x + x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int AddY(this Vector2Int v, int y) => new(v.x, v.y + y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int XX(this Vector2Int v) => new(v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int XO(this Vector2Int v, int y = 0) => new(v.x, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int YX(this Vector2Int v) => new(v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int YY(this Vector2Int v) => new(v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int YO(this Vector2Int v, int y = 0) => new(v.y, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int OX(this Vector2Int v, int x = 0) => new(x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int OY(this Vector2Int v, int x = 0) => new(x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XXX(this Vector2Int v) => new(v.x, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XXY(this Vector2Int v) => new(v.x, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XXO(this Vector2Int v, int z = 0) => new(v.x, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XYX(this Vector2Int v) => new(v.x, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XYY(this Vector2Int v) => new(v.x, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XYO(this Vector2Int v, int z = 0) => new(v.x, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XOX(this Vector2Int v, int y = 0) => new(v.x, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XOY(this Vector2Int v, int y = 0) => new(v.x, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XOO(this Vector2Int v, int y = 0, int z = 0) => new(v.x, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YXX(this Vector2Int v) => new(v.y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YXY(this Vector2Int v) => new(v.y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YXO(this Vector2Int v, int z = 0) => new(v.y, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YYX(this Vector2Int v) => new(v.y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YYY(this Vector2Int v) => new(v.y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YYO(this Vector2Int v, int z = 0) => new(v.y, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YOX(this Vector2Int v, int y = 0) => new(v.y, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YOY(this Vector2Int v, int y = 0) => new(v.y, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YOO(this Vector2Int v, int y = 0, int z = 0) => new(v.y, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OXX(this Vector2Int v, int x = 0) => new(x, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OXY(this Vector2Int v, int x = 0) => new(x, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OXO(this Vector2Int v, int x = 0, int z = 0) => new(x, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OYX(this Vector2Int v, int x = 0) => new(x, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OYY(this Vector2Int v, int x = 0) => new(x, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OYO(this Vector2Int v, int x = 0, int z = 0) => new(x, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OOX(this Vector2Int v, int x = 0, int y = 0) => new(x, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OOY(this Vector2Int v, int x = 0, int y = 0) => new(x, y, v.y);
    }
}