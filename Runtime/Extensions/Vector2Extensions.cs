﻿using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class Vector2Extensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 XX(this float2 v) => new(v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 YX(this float2 v) => new(v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 YY(this float2 v) => new(v.y, v.y);
        
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 X0Y(this Vector2 current, float y = 0f) => new(current.x, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XY0(this Vector2 current, float z = 0f) => new(current.x, current.y, z);
        
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 AsFloat(this Vector2 v) => new(v.x, v.y);
        
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 XXAsFloat(this float2 v) => new(v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 YXAsFloat(this float2 v) => new(v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 YYAsFloat(this float2 v) => new(v.y, v.y);
        
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 X0YAsFloat(this Vector2 current, float y = 0f) => new(current.x, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 XY0AsFloat(this Vector2 current, float z = 0f) => new(current.x, current.y, z);
        
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 WithX(this Vector2 v, float x) => new(x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 WithY(this Vector2 v, float y) => new(v.x, y);
        
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 AddX(this Vector2 v, float x) => new(v.x + x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 AddY(this Vector2 v, float y) => new(v.x, v.y + y);
    }
}