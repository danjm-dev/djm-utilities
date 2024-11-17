using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class Vector3Extensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 XXXAsFloat(this Vector3 v) => new(v.x, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 XXYAsFloat(this Vector3 v) => new(v.x, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 XXZAsFloat(this Vector3 v) => new(v.x, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 XYXAsFloat(this Vector3 v) => new(v.x, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 XYYAsFloat(this Vector3 v) => new(v.x, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 XZXAsFloat(this Vector3 v) => new(v.x, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 XZYAsFloat(this Vector3 v) => new(v.x, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 XZZAsFloat(this Vector3 v) => new(v.x, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 YXXAsFloat(this Vector3 v) => new(v.y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 YXYAsFloat(this Vector3 v) => new(v.y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 YXZAsFloat(this Vector3 v) => new(v.y, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 YYXAsFloat(this Vector3 v) => new(v.y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 YYYAsFloat(this Vector3 v) => new(v.y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 YYZAsFloat(this Vector3 v) => new(v.y, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 YZXAsFloat(this Vector3 v) => new(v.y, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 YZYAsFloat(this Vector3 v) => new(v.y, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 YZZAsFloat(this Vector3 v) => new(v.y, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 ZXXAsFloat(this Vector3 v) => new(v.z, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 ZXYAsFloat(this Vector3 v) => new(v.z, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 ZXZAsFloat(this Vector3 v) => new(v.z, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 ZYXAsFloat(this Vector3 v) => new(v.z, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 ZYYAsFloat(this Vector3 v) => new(v.z, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 ZYZAsFloat(this Vector3 v) => new(v.z, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 ZZXAsFloat(this Vector3 v) => new(v.z, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 ZZYAsFloat(this Vector3 v) => new(v.z, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 ZZZAsFloat(this Vector3 v) => new(v.z, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float2 XXAsFloat(this Vector3 v) => new(v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float2 XYAsFloat(this Vector3 v) => new(v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float2 XZAsFloat(this Vector3 v) => new(v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float2 YXAsFloat(this Vector3 v) => new(v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float2 YYAsFloat(this Vector3 v) => new(v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float2 YZAsFloat(this Vector3 v) => new(v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float2 ZXAsFloat(this Vector3 v) => new(v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float2 ZYAsFloat(this Vector3 v) => new(v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float2 ZZAsFloat(this Vector3 v) => new(v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 AsFloat(this Vector3 v) => new(v.x, v.y, v.z);
        

        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 AsFloat3(this Vector3 v) => new(v.x, v.y, v.z);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 With(this Vector3 v, float? x = null, float? y = null, float? z = null) => new(x ?? v.x, y ?? v.y, z ?? v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 WithX(this Vector3 v, float x) => new(x, v.y, v.z);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 WithY(this Vector3 v, float y) => new(v.x, y, v.z);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 WithZ(this Vector3 v, float z) => new(v.x, v.y, z);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 AddX(this Vector3 v, float x) => new(v.x + x, v.y, v.z);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 AddY(this Vector3 v, float y) => new(v.x, v.y + y, v.z);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 AddZ(this Vector3 v, float z) => new(v.x, v.y, v.z + z);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2 XX(this Vector3 v) => new(v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2 XY(this Vector3 v) => new(v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2 XZ(this Vector3 v) => new(v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2 XO(this Vector3 v, float y = 0f) => new(v.x, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2 YX(this Vector3 v) => new(v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2 YY(this Vector3 v) => new(v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2 YZ(this Vector3 v) => new(v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2 YO(this Vector3 v, float y = 0f) => new(v.y, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2 ZX(this Vector3 v) => new(v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2 ZY(this Vector3 v) => new(v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2 ZZ(this Vector3 v) => new(v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2 ZO(this Vector3 v, float y = 0f) => new(v.z, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2 OX(this Vector3 v, float x = 0f) => new(x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2 OY(this Vector3 v, float x = 0f) => new(x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector2 OZ(this Vector3 v, float x = 0f) => new(x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 XXX(this Vector3 v) => new(v.x, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 XXY(this Vector3 v) => new(v.x, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 XXZ(this Vector3 v) => new(v.x, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 XXO(this Vector3 v, float z = 0f) => new(v.x, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 XYX(this Vector3 v) => new(v.x, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 XYY(this Vector3 v) => new(v.x, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 XYO(this Vector3 v, float z = 0f) => new(v.x, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 XZX(this Vector3 v) => new(v.x, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 XZY(this Vector3 v) => new(v.x, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 XZZ(this Vector3 v) => new(v.x, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 XZO(this Vector3 v, float z = 0f) => new(v.x, v.z, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 XOX(this Vector3 v, float y = 0f) => new(v.x, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 XOY(this Vector3 v, float y = 0f) => new(v.x, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 XOZ(this Vector3 v, float y = 0f) => new(v.x, y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 XOO(this Vector3 v, float y = 0f, float z = 0f) => new(v.x, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 YXX(this Vector3 v) => new(v.y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 YXY(this Vector3 v) => new(v.y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 YXZ(this Vector3 v) => new(v.y, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 YXO(this Vector3 v, float z = 0f) => new(v.y, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 YYX(this Vector3 v) => new(v.y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 YYY(this Vector3 v) => new(v.y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 YYZ(this Vector3 v) => new(v.y, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 YYO(this Vector3 v, float z = 0f) => new(v.y, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 YZX(this Vector3 v) => new(v.y, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 YZY(this Vector3 v) => new(v.y, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 YZZ(this Vector3 v) => new(v.y, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 YZO(this Vector3 v, float z = 0f) => new(v.y, v.z, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 YOX(this Vector3 v, float y = 0f) => new(v.y, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 YOY(this Vector3 v, float y = 0f) => new(v.y, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 YOZ(this Vector3 v, float y = 0f) => new(v.y, y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 YOO(this Vector3 v, float y = 0f, float z = 0f) => new(v.y, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 ZXX(this Vector3 v) => new(v.z, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 ZXY(this Vector3 v) => new(v.z, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 ZXZ(this Vector3 v) => new(v.z, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 ZXO(this Vector3 v, float z = 0f) => new(v.z, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 ZYX(this Vector3 v) => new(v.z, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 ZYY(this Vector3 v) => new(v.z, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 ZYZ(this Vector3 v) => new(v.z, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 ZYO(this Vector3 v, float z = 0f) => new(v.z, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 ZZX(this Vector3 v) => new(v.z, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 ZZY(this Vector3 v) => new(v.z, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 ZZZ(this Vector3 v) => new(v.z, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 ZZO(this Vector3 v, float z = 0f) => new(v.z, v.z, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 ZOX(this Vector3 v, float y = 0f) => new(v.z, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 ZOY(this Vector3 v, float y = 0f) => new(v.z, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 ZOZ(this Vector3 v, float y = 0f) => new(v.z, y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 ZOO(this Vector3 v, float y = 0f, float z = 0f) => new(v.z, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 OXX(this Vector3 v, float x = 0f) => new(x, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 OXY(this Vector3 v, float x = 0f) => new(x, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 OXZ(this Vector3 v, float x = 0f) => new(x, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 OXO(this Vector3 v, float x = 0f, float z = 0f) => new(x, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 OYX(this Vector3 v, float x = 0f) => new(x, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 OYY(this Vector3 v, float x = 0f) => new(x, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 OYZ(this Vector3 v, float x = 0f) => new(x, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 OYO(this Vector3 v, float x = 0f, float z = 0f) => new(x, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 OZX(this Vector3 v, float x = 0f) => new(x, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 OZY(this Vector3 v, float x = 0f) => new(x, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 OZZ(this Vector3 v, float x = 0f) => new(x, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 OZO(this Vector3 v, float x = 0f, float z = 0f) => new(x, v.z, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 OOX(this Vector3 v, float x = 0f, float y = 0f) => new(x, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 OOY(this Vector3 v, float x = 0f, float y = 0f) => new(x, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector3 OOZ(this Vector3 v, float x = 0f, float y = 0f) => new(x, y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XXXX(this Vector3 v) => new(v.x, v.x, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XXXY(this Vector3 v) => new(v.x, v.x, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XXXZ(this Vector3 v) => new(v.x, v.x, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XXXO(this Vector3 v, float w = 0f) => new(v.x, v.x, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XXYX(this Vector3 v) => new(v.x, v.x, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XXYY(this Vector3 v) => new(v.x, v.x, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XXYZ(this Vector3 v) => new(v.x, v.x, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XXYO(this Vector3 v, float w = 0f) => new(v.x, v.x, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XXZX(this Vector3 v) => new(v.x, v.x, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XXZY(this Vector3 v) => new(v.x, v.x, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XXZZ(this Vector3 v) => new(v.x, v.x, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XXZO(this Vector3 v, float w = 0f) => new(v.x, v.x, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XXOX(this Vector3 v, float z = 0f) => new(v.x, v.x, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XXOY(this Vector3 v, float z = 0f) => new(v.x, v.x, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XXOZ(this Vector3 v, float z = 0f) => new(v.x, v.x, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XXOO(this Vector3 v, float z = 0f, float w = 0f) => new(v.x, v.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XYXX(this Vector3 v) => new(v.x, v.y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XYXY(this Vector3 v) => new(v.x, v.y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XYXZ(this Vector3 v) => new(v.x, v.y, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XYXO(this Vector3 v, float w = 0f) => new(v.x, v.y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XYYX(this Vector3 v) => new(v.x, v.y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XYYY(this Vector3 v) => new(v.x, v.y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XYYZ(this Vector3 v) => new(v.x, v.y, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XYYO(this Vector3 v, float w = 0f) => new(v.x, v.y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XYZX(this Vector3 v) => new(v.x, v.y, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XYZY(this Vector3 v) => new(v.x, v.y, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XYZZ(this Vector3 v) => new(v.x, v.y, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XYZO(this Vector3 v, float w = 0f) => new(v.x, v.y, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XYOX(this Vector3 v, float z = 0f) => new(v.x, v.y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XYOY(this Vector3 v, float z = 0f) => new(v.x, v.y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XYOZ(this Vector3 v, float z = 0f) => new(v.x, v.y, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XYOO(this Vector3 v, float z = 0f, float w = 0f) => new(v.x, v.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XZXX(this Vector3 v) => new(v.x, v.z, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XZXY(this Vector3 v) => new(v.x, v.z, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XZXZ(this Vector3 v) => new(v.x, v.z, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XZXO(this Vector3 v, float w = 0f) => new(v.x, v.z, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XZYX(this Vector3 v) => new(v.x, v.z, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XZYY(this Vector3 v) => new(v.x, v.z, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XZYZ(this Vector3 v) => new(v.x, v.z, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XZYO(this Vector3 v, float w = 0f) => new(v.x, v.z, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XZZX(this Vector3 v) => new(v.x, v.z, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XZZY(this Vector3 v) => new(v.x, v.z, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XZZZ(this Vector3 v) => new(v.x, v.z, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XZZO(this Vector3 v, float w = 0f) => new(v.x, v.z, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XZOX(this Vector3 v, float z = 0f) => new(v.x, v.z, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XZOY(this Vector3 v, float z = 0f) => new(v.x, v.z, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XZOZ(this Vector3 v, float z = 0f) => new(v.x, v.z, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XZOO(this Vector3 v, float z = 0f, float w = 0f) => new(v.x, v.z, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XOXX(this Vector3 v, float y = 0f) => new(v.x, y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XOXY(this Vector3 v, float y = 0f) => new(v.x, y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XOXZ(this Vector3 v, float y = 0f) => new(v.x, y, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XOXO(this Vector3 v, float y = 0f, float w = 0f) => new(v.x, y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XOYX(this Vector3 v, float y = 0f) => new(v.x, y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XOYY(this Vector3 v, float y = 0f) => new(v.x, y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XOYZ(this Vector3 v, float y = 0f) => new(v.x, y, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XOYO(this Vector3 v, float y = 0f, float w = 0f) => new(v.x, y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XOZX(this Vector3 v, float y = 0f) => new(v.x, y, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XOZY(this Vector3 v, float y = 0f) => new(v.x, y, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XOZZ(this Vector3 v, float y = 0f) => new(v.x, y, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XOZO(this Vector3 v, float y = 0f, float w = 0f) => new(v.x, y, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XOOX(this Vector3 v, float y = 0f, float z = 0f) => new(v.x, y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XOOY(this Vector3 v, float y = 0f, float z = 0f) => new(v.x, y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XOOZ(this Vector3 v, float y = 0f, float z = 0f) => new(v.x, y, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 XOOO(this Vector3 v, float y = 0f, float z = 0f, float w = 0f) => new(v.x, y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YXXX(this Vector3 v) => new(v.y, v.x, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YXXY(this Vector3 v) => new(v.y, v.x, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YXXZ(this Vector3 v) => new(v.y, v.x, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YXXO(this Vector3 v, float w = 0f) => new(v.y, v.x, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YXYX(this Vector3 v) => new(v.y, v.x, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YXYY(this Vector3 v) => new(v.y, v.x, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YXYZ(this Vector3 v) => new(v.y, v.x, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YXYO(this Vector3 v, float w = 0f) => new(v.y, v.x, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YXZX(this Vector3 v) => new(v.y, v.x, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YXZY(this Vector3 v) => new(v.y, v.x, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YXZZ(this Vector3 v) => new(v.y, v.x, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YXZO(this Vector3 v, float w = 0f) => new(v.y, v.x, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YXOX(this Vector3 v, float z = 0f) => new(v.y, v.x, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YXOY(this Vector3 v, float z = 0f) => new(v.y, v.x, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YXOZ(this Vector3 v, float z = 0f) => new(v.y, v.x, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YXOO(this Vector3 v, float z = 0f, float w = 0f) => new(v.y, v.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YYXX(this Vector3 v) => new(v.y, v.y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YYXY(this Vector3 v) => new(v.y, v.y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YYXZ(this Vector3 v) => new(v.y, v.y, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YYXO(this Vector3 v, float w = 0f) => new(v.y, v.y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YYYX(this Vector3 v) => new(v.y, v.y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YYYY(this Vector3 v) => new(v.y, v.y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YYYZ(this Vector3 v) => new(v.y, v.y, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YYYO(this Vector3 v, float w = 0f) => new(v.y, v.y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YYZX(this Vector3 v) => new(v.y, v.y, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YYZY(this Vector3 v) => new(v.y, v.y, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YYZZ(this Vector3 v) => new(v.y, v.y, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YYZO(this Vector3 v, float w = 0f) => new(v.y, v.y, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YYOX(this Vector3 v, float z = 0f) => new(v.y, v.y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YYOY(this Vector3 v, float z = 0f) => new(v.y, v.y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YYOZ(this Vector3 v, float z = 0f) => new(v.y, v.y, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YYOO(this Vector3 v, float z = 0f, float w = 0f) => new(v.y, v.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YZXX(this Vector3 v) => new(v.y, v.z, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YZXY(this Vector3 v) => new(v.y, v.z, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YZXZ(this Vector3 v) => new(v.y, v.z, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YZXO(this Vector3 v, float w = 0f) => new(v.y, v.z, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YZYX(this Vector3 v) => new(v.y, v.z, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YZYY(this Vector3 v) => new(v.y, v.z, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YZYZ(this Vector3 v) => new(v.y, v.z, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YZYO(this Vector3 v, float w = 0f) => new(v.y, v.z, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YZZX(this Vector3 v) => new(v.y, v.z, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YZZY(this Vector3 v) => new(v.y, v.z, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YZZZ(this Vector3 v) => new(v.y, v.z, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YZZO(this Vector3 v, float w = 0f) => new(v.y, v.z, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YZOX(this Vector3 v, float z = 0f) => new(v.y, v.z, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YZOY(this Vector3 v, float z = 0f) => new(v.y, v.z, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YZOZ(this Vector3 v, float z = 0f) => new(v.y, v.z, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YZOO(this Vector3 v, float z = 0f, float w = 0f) => new(v.y, v.z, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YOXX(this Vector3 v, float y = 0f) => new(v.y, y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YOXY(this Vector3 v, float y = 0f) => new(v.y, y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YOXZ(this Vector3 v, float y = 0f) => new(v.y, y, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YOXO(this Vector3 v, float y = 0f, float w = 0f) => new(v.y, y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YOYX(this Vector3 v, float y = 0f) => new(v.y, y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YOYY(this Vector3 v, float y = 0f) => new(v.y, y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YOYZ(this Vector3 v, float y = 0f) => new(v.y, y, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YOYO(this Vector3 v, float y = 0f, float w = 0f) => new(v.y, y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YOZX(this Vector3 v, float y = 0f) => new(v.y, y, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YOZY(this Vector3 v, float y = 0f) => new(v.y, y, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YOZZ(this Vector3 v, float y = 0f) => new(v.y, y, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YOZO(this Vector3 v, float y = 0f, float w = 0f) => new(v.y, y, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YOOX(this Vector3 v, float y = 0f, float z = 0f) => new(v.y, y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YOOY(this Vector3 v, float y = 0f, float z = 0f) => new(v.y, y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YOOZ(this Vector3 v, float y = 0f, float z = 0f) => new(v.y, y, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 YOOO(this Vector3 v, float y = 0f, float z = 0f, float w = 0f) => new(v.y, y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZXXX(this Vector3 v) => new(v.z, v.x, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZXXY(this Vector3 v) => new(v.z, v.x, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZXXZ(this Vector3 v) => new(v.z, v.x, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZXXO(this Vector3 v, float w = 0f) => new(v.z, v.x, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZXYX(this Vector3 v) => new(v.z, v.x, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZXYY(this Vector3 v) => new(v.z, v.x, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZXYZ(this Vector3 v) => new(v.z, v.x, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZXYO(this Vector3 v, float w = 0f) => new(v.z, v.x, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZXZX(this Vector3 v) => new(v.z, v.x, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZXZY(this Vector3 v) => new(v.z, v.x, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZXZZ(this Vector3 v) => new(v.z, v.x, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZXZO(this Vector3 v, float w = 0f) => new(v.z, v.x, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZXOX(this Vector3 v, float z = 0f) => new(v.z, v.x, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZXOY(this Vector3 v, float z = 0f) => new(v.z, v.x, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZXOZ(this Vector3 v, float z = 0f) => new(v.z, v.x, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZXOO(this Vector3 v, float z = 0f, float w = 0f) => new(v.z, v.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZYXX(this Vector3 v) => new(v.z, v.y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZYXY(this Vector3 v) => new(v.z, v.y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZYXZ(this Vector3 v) => new(v.z, v.y, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZYXO(this Vector3 v, float w = 0f) => new(v.z, v.y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZYYX(this Vector3 v) => new(v.z, v.y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZYYY(this Vector3 v) => new(v.z, v.y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZYYZ(this Vector3 v) => new(v.z, v.y, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZYYO(this Vector3 v, float w = 0f) => new(v.z, v.y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZYZX(this Vector3 v) => new(v.z, v.y, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZYZY(this Vector3 v) => new(v.z, v.y, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZYZZ(this Vector3 v) => new(v.z, v.y, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZYZO(this Vector3 v, float w = 0f) => new(v.z, v.y, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZYOX(this Vector3 v, float z = 0f) => new(v.z, v.y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZYOY(this Vector3 v, float z = 0f) => new(v.z, v.y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZYOZ(this Vector3 v, float z = 0f) => new(v.z, v.y, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZYOO(this Vector3 v, float z = 0f, float w = 0f) => new(v.z, v.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZZXX(this Vector3 v) => new(v.z, v.z, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZZXY(this Vector3 v) => new(v.z, v.z, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZZXZ(this Vector3 v) => new(v.z, v.z, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZZXO(this Vector3 v, float w = 0f) => new(v.z, v.z, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZZYX(this Vector3 v) => new(v.z, v.z, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZZYY(this Vector3 v) => new(v.z, v.z, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZZYZ(this Vector3 v) => new(v.z, v.z, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZZYO(this Vector3 v, float w = 0f) => new(v.z, v.z, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZZZX(this Vector3 v) => new(v.z, v.z, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZZZY(this Vector3 v) => new(v.z, v.z, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZZZZ(this Vector3 v) => new(v.z, v.z, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZZZO(this Vector3 v, float w = 0f) => new(v.z, v.z, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZZOX(this Vector3 v, float z = 0f) => new(v.z, v.z, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZZOY(this Vector3 v, float z = 0f) => new(v.z, v.z, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZZOZ(this Vector3 v, float z = 0f) => new(v.z, v.z, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZZOO(this Vector3 v, float z = 0f, float w = 0f) => new(v.z, v.z, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZOXX(this Vector3 v, float y = 0f) => new(v.z, y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZOXY(this Vector3 v, float y = 0f) => new(v.z, y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZOXZ(this Vector3 v, float y = 0f) => new(v.z, y, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZOXO(this Vector3 v, float y = 0f, float w = 0f) => new(v.z, y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZOYX(this Vector3 v, float y = 0f) => new(v.z, y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZOYY(this Vector3 v, float y = 0f) => new(v.z, y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZOYZ(this Vector3 v, float y = 0f) => new(v.z, y, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZOYO(this Vector3 v, float y = 0f, float w = 0f) => new(v.z, y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZOZX(this Vector3 v, float y = 0f) => new(v.z, y, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZOZY(this Vector3 v, float y = 0f) => new(v.z, y, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZOZZ(this Vector3 v, float y = 0f) => new(v.z, y, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZOZO(this Vector3 v, float y = 0f, float w = 0f) => new(v.z, y, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZOOX(this Vector3 v, float y = 0f, float z = 0f) => new(v.z, y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZOOY(this Vector3 v, float y = 0f, float z = 0f) => new(v.z, y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZOOZ(this Vector3 v, float y = 0f, float z = 0f) => new(v.z, y, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 ZOOO(this Vector3 v, float y = 0f, float z = 0f, float w = 0f) => new(v.z, y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OXXX(this Vector3 v, float x = 0f) => new(x, v.x, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OXXY(this Vector3 v, float x = 0f) => new(x, v.x, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OXXZ(this Vector3 v, float x = 0f) => new(x, v.x, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OXXO(this Vector3 v, float x = 0f, float w = 0f) => new(x, v.x, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OXYX(this Vector3 v, float x = 0f) => new(x, v.x, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OXYY(this Vector3 v, float x = 0f) => new(x, v.x, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OXYZ(this Vector3 v, float x = 0f) => new(x, v.x, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OXYO(this Vector3 v, float x = 0f, float w = 0f) => new(x, v.x, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OXZX(this Vector3 v, float x = 0f) => new(x, v.x, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OXZY(this Vector3 v, float x = 0f) => new(x, v.x, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OXZZ(this Vector3 v, float x = 0f) => new(x, v.x, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OXZO(this Vector3 v, float x = 0f, float w = 0f) => new(x, v.x, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OXOX(this Vector3 v, float x = 0f, float z = 0f) => new(x, v.x, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OXOY(this Vector3 v, float x = 0f, float z = 0f) => new(x, v.x, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OXOZ(this Vector3 v, float x = 0f, float z = 0f) => new(x, v.x, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OXOO(this Vector3 v, float x = 0f, float z = 0f, float w = 0f) => new(x, v.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OYXX(this Vector3 v, float x = 0f) => new(x, v.y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OYXY(this Vector3 v, float x = 0f) => new(x, v.y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OYXZ(this Vector3 v, float x = 0f) => new(x, v.y, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OYXO(this Vector3 v, float x = 0f, float w = 0f) => new(x, v.y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OYYX(this Vector3 v, float x = 0f) => new(x, v.y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OYYY(this Vector3 v, float x = 0f) => new(x, v.y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OYYZ(this Vector3 v, float x = 0f) => new(x, v.y, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OYYO(this Vector3 v, float x = 0f, float w = 0f) => new(x, v.y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OYZX(this Vector3 v, float x = 0f) => new(x, v.y, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OYZY(this Vector3 v, float x = 0f) => new(x, v.y, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OYZZ(this Vector3 v, float x = 0f) => new(x, v.y, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OYZO(this Vector3 v, float x = 0f, float w = 0f) => new(x, v.y, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OYOX(this Vector3 v, float x = 0f, float z = 0f) => new(x, v.y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OYOY(this Vector3 v, float x = 0f, float z = 0f) => new(x, v.y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OYOZ(this Vector3 v, float x = 0f, float z = 0f) => new(x, v.y, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OYOO(this Vector3 v, float x = 0f, float z = 0f, float w = 0f) => new(x, v.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OZXX(this Vector3 v, float x = 0f) => new(x, v.z, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OZXY(this Vector3 v, float x = 0f) => new(x, v.z, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OZXZ(this Vector3 v, float x = 0f) => new(x, v.z, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OZXO(this Vector3 v, float x = 0f, float w = 0f) => new(x, v.z, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OZYX(this Vector3 v, float x = 0f) => new(x, v.z, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OZYY(this Vector3 v, float x = 0f) => new(x, v.z, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OZYZ(this Vector3 v, float x = 0f) => new(x, v.z, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OZYO(this Vector3 v, float x = 0f, float w = 0f) => new(x, v.z, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OZZX(this Vector3 v, float x = 0f) => new(x, v.z, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OZZY(this Vector3 v, float x = 0f) => new(x, v.z, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OZZZ(this Vector3 v, float x = 0f) => new(x, v.z, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OZZO(this Vector3 v, float x = 0f, float w = 0f) => new(x, v.z, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OZOX(this Vector3 v, float x = 0f, float z = 0f) => new(x, v.z, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OZOY(this Vector3 v, float x = 0f, float z = 0f) => new(x, v.z, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OZOZ(this Vector3 v, float x = 0f, float z = 0f) => new(x, v.z, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OZOO(this Vector3 v, float x = 0f, float z = 0f, float w = 0f) => new(x, v.z, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OOXX(this Vector3 v, float x = 0f, float y = 0f) => new(x, y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OOXY(this Vector3 v, float x = 0f, float y = 0f) => new(x, y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OOXZ(this Vector3 v, float x = 0f, float y = 0f) => new(x, y, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OOXO(this Vector3 v, float x = 0f, float y = 0f, float w = 0f) => new(x, y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OOYX(this Vector3 v, float x = 0f, float y = 0f) => new(x, y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OOYY(this Vector3 v, float x = 0f, float y = 0f) => new(x, y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OOYZ(this Vector3 v, float x = 0f, float y = 0f) => new(x, y, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OOYO(this Vector3 v, float x = 0f, float y = 0f, float w = 0f) => new(x, y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OOZX(this Vector3 v, float x = 0f, float y = 0f) => new(x, y, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OOZY(this Vector3 v, float x = 0f, float y = 0f) => new(x, y, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OOZZ(this Vector3 v, float x = 0f, float y = 0f) => new(x, y, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OOZO(this Vector3 v, float x = 0f, float y = 0f, float w = 0f) => new(x, y, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OOOX(this Vector3 v, float x = 0f, float y = 0f, float z = 0f) => new(x, y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OOOY(this Vector3 v, float x = 0f, float y = 0f, float z = 0f) => new(x, y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static Vector4 OOOZ(this Vector3 v, float x = 0f, float y = 0f, float z = 0f) => new(x, y, z, v.z);
    }
}