using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class Int3Extensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int AsVector(this int3 v) => new(v.x, v.y, v.z);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 WithX(this int3 v, int x) => new(x, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 WithY(this int3 v, int y) => new(v.x, y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 WithZ(this int3 v, int z) => new(v.x, v.y, z);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 AddX(this int3 v, int x) => new(v.x + x, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 AddY(this int3 v, int y) => new(v.x, v.y + y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 AddZ(this int3 v, int z) => new(v.x, v.y, v.z + z);
    }
}