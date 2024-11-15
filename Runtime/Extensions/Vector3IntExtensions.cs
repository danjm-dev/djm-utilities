using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class Vector3IntExtensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 AsInt(this Vector3Int v) => new(v.x, v.y, v.z);
        
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
    }
}