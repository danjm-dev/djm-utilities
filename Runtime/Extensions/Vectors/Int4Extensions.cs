using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace DJM.Utilities
{
    public static class Int4Extensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 WithX(this int4 v, int x) => new(x, v.y, v.z, v.w);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 WithY(this int4 v, int y) => new(v.x, y, v.z, v.w);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 WithZ(this int4 v, int z) => new(v.x, v.y, z, v.w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 WithW(this int4 v, int w) => new(v.x, v.y, v.z, w);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 AddX(this int4 v, int x) => new(v.x + x, v.y, v.z, v.w);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 AddY(this int4 v, int y) => new(v.x, v.y + y, v.z, v.w);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 AddZ(this int4 v, int z) => new(v.x, v.y, v.z + z, v.w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 AddW(this int4 v, int w) => new(v.x, v.y, v.z, v.w + w);
    }
}