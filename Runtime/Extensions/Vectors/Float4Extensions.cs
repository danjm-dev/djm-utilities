using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class Float4Extensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 AsVector(this float4 v) => new(v.x, v.y, v.z, v.w);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 WithX(this float4 v, float x) => new(x, v.y, v.z, v.w);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 WithY(this float4 v, float y) => new(v.x, y, v.z, v.w);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 WithZ(this float4 v, float z) => new(v.x, v.y, z, v.w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 WithW(this float4 v, float w) => new(v.x, v.y, v.z, w);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 AddX(this float4 v, float x) => new(v.x + x, v.y, v.z, v.w);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 AddY(this float4 v, float y) => new(v.x, v.y + y, v.z, v.w);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 AddZ(this float4 v, float z) => new(v.x, v.y, v.z + z, v.w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 AddW(this float4 v, float w) => new(v.x, v.y, v.z, v.w + w);
    }
}