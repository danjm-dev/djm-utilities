﻿using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class Float2Extensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 X0Y(this float2 v, float y = 0f) => new(v.x, y, v.y);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 XY0(this float2 v, float z = 0f) => new(v.x, v.y, z);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 AsVector(this float2 v) => new(v.x, v.y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 X0YAsVector(this float2 v, float y = 0f) => new(v.x, y, v.y);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XY0AsVector(this float2 v, float z = 0f) => new(v.x, v.y, z);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 WithX(this float2 v, float x) => new(x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 WithY(this float2 v, float y) => new(v.x, y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 AddX(this float2 v, float x) => new(v.x + x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 AddY(this float2 v, float y) => new(v.x, v.y + y);
    }
}