using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class Float3Extensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2 XXAsVector(this float3 v) => new(v.x, v.x);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2 XYAsVector(this float3 v) => new(v.x, v.y);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2 XZAsVector(this float3 v) => new(v.x, v.z);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2 YXAsVector(this float3 v) => new(v.y, v.x);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2 YYAsVector(this float3 v) => new(v.y, v.y);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2 YZAsVector(this float3 v) => new(v.y, v.z);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2 ZXAsVector(this float3 v) => new(v.z, v.x);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2 ZYAsVector(this float3 v) => new(v.z, v.y);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2 ZZAsVector(this float3 v) => new(v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector3 AsVector(this float3 v) => new(v.x, v.y, v.z);
        
        
        
        
        
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 AsVector3(this float3 v) => new(v.x, v.y, v.z);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 With(this float3 v, float? x = null, float? y = null, float? z = null) => new(x ?? v.x, y ?? v.y, z ?? v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 WithX(this float3 v, float x) => new(x, v.y, v.z);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 WithY(this float3 v, float y) => new(v.x, y, v.z);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 WithZ(this float3 v, float z) => new(v.x, v.y, z);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 AddX(this float3 v, float x) => new(v.x + x, v.y, v.z);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 AddY(this float3 v, float y) => new(v.x, v.y + y, v.z);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 AddZ(this float3 v, float z) => new(v.x, v.y, v.z + z);
    }
}