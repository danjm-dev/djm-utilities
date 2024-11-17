using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class Vector3IntExtensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 AsInt3(this Vector3Int v) => new(v.x, v.y, v.z);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int With(this Vector3Int v, int? x = null, int? y = null, int? z = null) => new(x ?? v.x, y ?? v.y, z ?? v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int WithX(this Vector3Int v, int x) => new(x, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int WithY(this Vector3Int v, int y) => new(v.x, y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int WithZ(this Vector3Int v, int z) => new(v.x, v.y, z);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int AddX(this Vector3Int v, int x) => new(v.x + x, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int AddY(this Vector3Int v, int y) => new(v.x, v.y + y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int AddZ(this Vector3Int v, int z) => new(v.x, v.y, v.z + z);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int XX(this Vector3Int v) => new(v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int XY(this Vector3Int v) => new(v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int XZ(this Vector3Int v) => new(v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int XO(this Vector3Int v, int y = 0) => new(v.x, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int YX(this Vector3Int v) => new(v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int YY(this Vector3Int v) => new(v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int YZ(this Vector3Int v) => new(v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int YO(this Vector3Int v, int y = 0) => new(v.y, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int ZX(this Vector3Int v) => new(v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int ZY(this Vector3Int v) => new(v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int ZZ(this Vector3Int v) => new(v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int ZO(this Vector3Int v, int y = 0) => new(v.z, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int OX(this Vector3Int v, int x = 0) => new(x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int OY(this Vector3Int v, int x = 0) => new(x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2Int OZ(this Vector3Int v, int x = 0) => new(x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XXX(this Vector3Int v) => new(v.x, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XXY(this Vector3Int v) => new(v.x, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XXZ(this Vector3Int v) => new(v.x, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XXO(this Vector3Int v, int z = 0) => new(v.x, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XYX(this Vector3Int v) => new(v.x, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XYY(this Vector3Int v) => new(v.x, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XYO(this Vector3Int v, int z = 0) => new(v.x, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XZX(this Vector3Int v) => new(v.x, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XZY(this Vector3Int v) => new(v.x, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XZZ(this Vector3Int v) => new(v.x, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XZO(this Vector3Int v, int z = 0) => new(v.x, v.z, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XOX(this Vector3Int v, int y = 0) => new(v.x, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XOY(this Vector3Int v, int y = 0) => new(v.x, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XOZ(this Vector3Int v, int y = 0) => new(v.x, y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int XOO(this Vector3Int v, int y = 0, int z = 0) => new(v.x, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YXX(this Vector3Int v) => new(v.y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YXY(this Vector3Int v) => new(v.y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YXZ(this Vector3Int v) => new(v.y, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YXO(this Vector3Int v, int z = 0) => new(v.y, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YYX(this Vector3Int v) => new(v.y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YYY(this Vector3Int v) => new(v.y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YYZ(this Vector3Int v) => new(v.y, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YYO(this Vector3Int v, int z = 0) => new(v.y, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YZX(this Vector3Int v) => new(v.y, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YZY(this Vector3Int v) => new(v.y, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YZZ(this Vector3Int v) => new(v.y, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YZO(this Vector3Int v, int z = 0) => new(v.y, v.z, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YOX(this Vector3Int v, int y = 0) => new(v.y, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YOY(this Vector3Int v, int y = 0) => new(v.y, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YOZ(this Vector3Int v, int y = 0) => new(v.y, y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int YOO(this Vector3Int v, int y = 0, int z = 0) => new(v.y, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int ZXX(this Vector3Int v) => new(v.z, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int ZXY(this Vector3Int v) => new(v.z, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int ZXZ(this Vector3Int v) => new(v.z, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int ZXO(this Vector3Int v, int z = 0) => new(v.z, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int ZYX(this Vector3Int v) => new(v.z, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int ZYY(this Vector3Int v) => new(v.z, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int ZYZ(this Vector3Int v) => new(v.z, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int ZYO(this Vector3Int v, int z = 0) => new(v.z, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int ZZX(this Vector3Int v) => new(v.z, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int ZZY(this Vector3Int v) => new(v.z, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int ZZZ(this Vector3Int v) => new(v.z, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int ZZO(this Vector3Int v, int z = 0) => new(v.z, v.z, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int ZOX(this Vector3Int v, int y = 0) => new(v.z, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int ZOY(this Vector3Int v, int y = 0) => new(v.z, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int ZOZ(this Vector3Int v, int y = 0) => new(v.z, y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int ZOO(this Vector3Int v, int y = 0, int z = 0) => new(v.z, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OXX(this Vector3Int v, int x = 0) => new(x, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OXY(this Vector3Int v, int x = 0) => new(x, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OXZ(this Vector3Int v, int x = 0) => new(x, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OXO(this Vector3Int v, int x = 0, int z = 0) => new(x, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OYX(this Vector3Int v, int x = 0) => new(x, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OYY(this Vector3Int v, int x = 0) => new(x, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OYZ(this Vector3Int v, int x = 0) => new(x, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OYO(this Vector3Int v, int x = 0, int z = 0) => new(x, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OZX(this Vector3Int v, int x = 0) => new(x, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OZY(this Vector3Int v, int x = 0) => new(x, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OZZ(this Vector3Int v, int x = 0) => new(x, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OZO(this Vector3Int v, int x = 0, int z = 0) => new(x, v.z, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OOX(this Vector3Int v, int x = 0, int y = 0) => new(x, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OOY(this Vector3Int v, int x = 0, int y = 0) => new(x, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3Int OOZ(this Vector3Int v, int x = 0, int y = 0) => new(x, y, v.z);
    }
}