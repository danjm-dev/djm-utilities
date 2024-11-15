using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class Vector4Extensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 AsFloat(this Vector4 v) => new(v.x, v.y, v.z, v.w);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 WithX(this Vector4 v, float x) => new(x, v.y, v.z, v.w);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 WithY(this Vector4 v, float y) => new(v.x, y, v.z, v.w);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 WithZ(this Vector4 v, float z) => new(v.x, v.y, z, v.w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 WithW(this Vector4 v, float w) => new(v.x, v.y, v.z, w);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 AddX(this Vector4 v, float x) => new(v.x + x, v.y, v.z, v.w);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 AddY(this Vector4 v, float y) => new(v.x, v.y + y, v.z, v.w);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 AddZ(this Vector4 v, float z) => new(v.x, v.y, v.z + z, v.w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 AddW(this Vector4 v, float w) => new(v.x, v.y, v.z, v.w + w);
    }
}