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
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float2 XO(this float3 v, float y = 0f) => new(v.x, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float2 YO(this float3 v, float y = 0f) => new(v.y, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float2 ZO(this float3 v, float y = 0f) => new(v.z, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float2 OX(this float3 v, float x = 0f) => new(x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float2 OY(this float3 v, float x = 0f) => new(x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float2 OZ(this float3 v, float x = 0f) => new(x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 XXO(this float3 v, float z = 0f) => new(v.x, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 XYO(this float3 v, float z = 0f) => new(v.x, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 XZO(this float3 v, float z = 0f) => new(v.x, v.z, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 XOX(this float3 v, float y = 0f) => new(v.x, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 XOY(this float3 v, float y = 0f) => new(v.x, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 XOZ(this float3 v, float y = 0f) => new(v.x, y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 XOO(this float3 v, float y = 0f, float z = 0f) => new(v.x, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 YXO(this float3 v, float z = 0f) => new(v.y, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 YYO(this float3 v, float z = 0f) => new(v.y, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 YZO(this float3 v, float z = 0f) => new(v.y, v.z, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 YOX(this float3 v, float y = 0f) => new(v.y, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 YOY(this float3 v, float y = 0f) => new(v.y, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 YOZ(this float3 v, float y = 0f) => new(v.y, y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 YOO(this float3 v, float y = 0f, float z = 0f) => new(v.y, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 ZXO(this float3 v, float z = 0f) => new(v.z, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 ZYO(this float3 v, float z = 0f) => new(v.z, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 ZZO(this float3 v, float z = 0f) => new(v.z, v.z, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 ZOX(this float3 v, float y = 0f) => new(v.z, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 ZOY(this float3 v, float y = 0f) => new(v.z, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 ZOZ(this float3 v, float y = 0f) => new(v.z, y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 ZOO(this float3 v, float y = 0f, float z = 0f) => new(v.z, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OXX(this float3 v, float x = 0f) => new(x, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OXY(this float3 v, float x = 0f) => new(x, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OXZ(this float3 v, float x = 0f) => new(x, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OXO(this float3 v, float x = 0f, float z = 0f) => new(x, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OYX(this float3 v, float x = 0f) => new(x, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OYY(this float3 v, float x = 0f) => new(x, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OYZ(this float3 v, float x = 0f) => new(x, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OYO(this float3 v, float x = 0f, float z = 0f) => new(x, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OZX(this float3 v, float x = 0f) => new(x, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OZY(this float3 v, float x = 0f) => new(x, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OZZ(this float3 v, float x = 0f) => new(x, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OZO(this float3 v, float x = 0f, float z = 0f) => new(x, v.z, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OOX(this float3 v, float x = 0f, float y = 0f) => new(x, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OOY(this float3 v, float x = 0f, float y = 0f) => new(x, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OOZ(this float3 v, float x = 0f, float y = 0f) => new(x, y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XXXO(this float3 v, float w = 0f) => new(v.x, v.x, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XXYO(this float3 v, float w = 0f) => new(v.x, v.x, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XXZO(this float3 v, float w = 0f) => new(v.x, v.x, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XXOX(this float3 v, float z = 0f) => new(v.x, v.x, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XXOY(this float3 v, float z = 0f) => new(v.x, v.x, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XXOZ(this float3 v, float z = 0f) => new(v.x, v.x, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XXOO(this float3 v, float z = 0f, float w = 0f) => new(v.x, v.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XYXO(this float3 v, float w = 0f) => new(v.x, v.y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XYYO(this float3 v, float w = 0f) => new(v.x, v.y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XYZO(this float3 v, float w = 0f) => new(v.x, v.y, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XYOX(this float3 v, float z = 0f) => new(v.x, v.y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XYOY(this float3 v, float z = 0f) => new(v.x, v.y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XYOZ(this float3 v, float z = 0f) => new(v.x, v.y, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XYOO(this float3 v, float z = 0f, float w = 0f) => new(v.x, v.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XZXO(this float3 v, float w = 0f) => new(v.x, v.z, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XZYO(this float3 v, float w = 0f) => new(v.x, v.z, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XZZO(this float3 v, float w = 0f) => new(v.x, v.z, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XZOX(this float3 v, float z = 0f) => new(v.x, v.z, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XZOY(this float3 v, float z = 0f) => new(v.x, v.z, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XZOZ(this float3 v, float z = 0f) => new(v.x, v.z, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XZOO(this float3 v, float z = 0f, float w = 0f) => new(v.x, v.z, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOXX(this float3 v, float y = 0f) => new(v.x, y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOXY(this float3 v, float y = 0f) => new(v.x, y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOXZ(this float3 v, float y = 0f) => new(v.x, y, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOXO(this float3 v, float y = 0f, float w = 0f) => new(v.x, y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOYX(this float3 v, float y = 0f) => new(v.x, y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOYY(this float3 v, float y = 0f) => new(v.x, y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOYZ(this float3 v, float y = 0f) => new(v.x, y, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOYO(this float3 v, float y = 0f, float w = 0f) => new(v.x, y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOZX(this float3 v, float y = 0f) => new(v.x, y, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOZY(this float3 v, float y = 0f) => new(v.x, y, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOZZ(this float3 v, float y = 0f) => new(v.x, y, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOZO(this float3 v, float y = 0f, float w = 0f) => new(v.x, y, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOOX(this float3 v, float y = 0f, float z = 0f) => new(v.x, y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOOY(this float3 v, float y = 0f, float z = 0f) => new(v.x, y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOOZ(this float3 v, float y = 0f, float z = 0f) => new(v.x, y, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOOO(this float3 v, float y = 0f, float z = 0f, float w = 0f) => new(v.x, y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YXXO(this float3 v, float w = 0f) => new(v.y, v.x, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YXYO(this float3 v, float w = 0f) => new(v.y, v.x, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YXZO(this float3 v, float w = 0f) => new(v.y, v.x, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YXOX(this float3 v, float z = 0f) => new(v.y, v.x, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YXOY(this float3 v, float z = 0f) => new(v.y, v.x, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YXOZ(this float3 v, float z = 0f) => new(v.y, v.x, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YXOO(this float3 v, float z = 0f, float w = 0f) => new(v.y, v.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YYXO(this float3 v, float w = 0f) => new(v.y, v.y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YYYO(this float3 v, float w = 0f) => new(v.y, v.y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YYZO(this float3 v, float w = 0f) => new(v.y, v.y, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YYOX(this float3 v, float z = 0f) => new(v.y, v.y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YYOY(this float3 v, float z = 0f) => new(v.y, v.y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YYOZ(this float3 v, float z = 0f) => new(v.y, v.y, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YYOO(this float3 v, float z = 0f, float w = 0f) => new(v.y, v.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YZXO(this float3 v, float w = 0f) => new(v.y, v.z, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YZYO(this float3 v, float w = 0f) => new(v.y, v.z, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YZZO(this float3 v, float w = 0f) => new(v.y, v.z, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YZOX(this float3 v, float z = 0f) => new(v.y, v.z, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YZOY(this float3 v, float z = 0f) => new(v.y, v.z, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YZOZ(this float3 v, float z = 0f) => new(v.y, v.z, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YZOO(this float3 v, float z = 0f, float w = 0f) => new(v.y, v.z, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOXX(this float3 v, float y = 0f) => new(v.y, y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOXY(this float3 v, float y = 0f) => new(v.y, y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOXZ(this float3 v, float y = 0f) => new(v.y, y, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOXO(this float3 v, float y = 0f, float w = 0f) => new(v.y, y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOYX(this float3 v, float y = 0f) => new(v.y, y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOYY(this float3 v, float y = 0f) => new(v.y, y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOYZ(this float3 v, float y = 0f) => new(v.y, y, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOYO(this float3 v, float y = 0f, float w = 0f) => new(v.y, y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOZX(this float3 v, float y = 0f) => new(v.y, y, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOZY(this float3 v, float y = 0f) => new(v.y, y, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOZZ(this float3 v, float y = 0f) => new(v.y, y, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOZO(this float3 v, float y = 0f, float w = 0f) => new(v.y, y, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOOX(this float3 v, float y = 0f, float z = 0f) => new(v.y, y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOOY(this float3 v, float y = 0f, float z = 0f) => new(v.y, y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOOZ(this float3 v, float y = 0f, float z = 0f) => new(v.y, y, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOOO(this float3 v, float y = 0f, float z = 0f, float w = 0f) => new(v.y, y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZXXO(this float3 v, float w = 0f) => new(v.z, v.x, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZXYO(this float3 v, float w = 0f) => new(v.z, v.x, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZXZO(this float3 v, float w = 0f) => new(v.z, v.x, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZXOX(this float3 v, float z = 0f) => new(v.z, v.x, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZXOY(this float3 v, float z = 0f) => new(v.z, v.x, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZXOZ(this float3 v, float z = 0f) => new(v.z, v.x, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZXOO(this float3 v, float z = 0f, float w = 0f) => new(v.z, v.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZYXO(this float3 v, float w = 0f) => new(v.z, v.y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZYYO(this float3 v, float w = 0f) => new(v.z, v.y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZYZO(this float3 v, float w = 0f) => new(v.z, v.y, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZYOX(this float3 v, float z = 0f) => new(v.z, v.y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZYOY(this float3 v, float z = 0f) => new(v.z, v.y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZYOZ(this float3 v, float z = 0f) => new(v.z, v.y, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZYOO(this float3 v, float z = 0f, float w = 0f) => new(v.z, v.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZZXO(this float3 v, float w = 0f) => new(v.z, v.z, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZZYO(this float3 v, float w = 0f) => new(v.z, v.z, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZZZO(this float3 v, float w = 0f) => new(v.z, v.z, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZZOX(this float3 v, float z = 0f) => new(v.z, v.z, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZZOY(this float3 v, float z = 0f) => new(v.z, v.z, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZZOZ(this float3 v, float z = 0f) => new(v.z, v.z, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZZOO(this float3 v, float z = 0f, float w = 0f) => new(v.z, v.z, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZOXX(this float3 v, float y = 0f) => new(v.z, y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZOXY(this float3 v, float y = 0f) => new(v.z, y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZOXZ(this float3 v, float y = 0f) => new(v.z, y, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZOXO(this float3 v, float y = 0f, float w = 0f) => new(v.z, y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZOYX(this float3 v, float y = 0f) => new(v.z, y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZOYY(this float3 v, float y = 0f) => new(v.z, y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZOYZ(this float3 v, float y = 0f) => new(v.z, y, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZOYO(this float3 v, float y = 0f, float w = 0f) => new(v.z, y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZOZX(this float3 v, float y = 0f) => new(v.z, y, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZOZY(this float3 v, float y = 0f) => new(v.z, y, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZOZZ(this float3 v, float y = 0f) => new(v.z, y, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZOZO(this float3 v, float y = 0f, float w = 0f) => new(v.z, y, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZOOX(this float3 v, float y = 0f, float z = 0f) => new(v.z, y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZOOY(this float3 v, float y = 0f, float z = 0f) => new(v.z, y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZOOZ(this float3 v, float y = 0f, float z = 0f) => new(v.z, y, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 ZOOO(this float3 v, float y = 0f, float z = 0f, float w = 0f) => new(v.z, y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXXX(this float3 v, float x = 0f) => new(x, v.x, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXXY(this float3 v, float x = 0f) => new(x, v.x, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXXZ(this float3 v, float x = 0f) => new(x, v.x, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXXO(this float3 v, float x = 0f, float w = 0f) => new(x, v.x, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXYX(this float3 v, float x = 0f) => new(x, v.x, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXYY(this float3 v, float x = 0f) => new(x, v.x, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXYZ(this float3 v, float x = 0f) => new(x, v.x, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXYO(this float3 v, float x = 0f, float w = 0f) => new(x, v.x, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXZX(this float3 v, float x = 0f) => new(x, v.x, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXZY(this float3 v, float x = 0f) => new(x, v.x, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXZZ(this float3 v, float x = 0f) => new(x, v.x, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXZO(this float3 v, float x = 0f, float w = 0f) => new(x, v.x, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXOX(this float3 v, float x = 0f, float z = 0f) => new(x, v.x, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXOY(this float3 v, float x = 0f, float z = 0f) => new(x, v.x, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXOZ(this float3 v, float x = 0f, float z = 0f) => new(x, v.x, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXOO(this float3 v, float x = 0f, float z = 0f, float w = 0f) => new(x, v.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYXX(this float3 v, float x = 0f) => new(x, v.y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYXY(this float3 v, float x = 0f) => new(x, v.y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYXZ(this float3 v, float x = 0f) => new(x, v.y, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYXO(this float3 v, float x = 0f, float w = 0f) => new(x, v.y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYYX(this float3 v, float x = 0f) => new(x, v.y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYYY(this float3 v, float x = 0f) => new(x, v.y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYYZ(this float3 v, float x = 0f) => new(x, v.y, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYYO(this float3 v, float x = 0f, float w = 0f) => new(x, v.y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYZX(this float3 v, float x = 0f) => new(x, v.y, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYZY(this float3 v, float x = 0f) => new(x, v.y, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYZZ(this float3 v, float x = 0f) => new(x, v.y, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYZO(this float3 v, float x = 0f, float w = 0f) => new(x, v.y, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYOX(this float3 v, float x = 0f, float z = 0f) => new(x, v.y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYOY(this float3 v, float x = 0f, float z = 0f) => new(x, v.y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYOZ(this float3 v, float x = 0f, float z = 0f) => new(x, v.y, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYOO(this float3 v, float x = 0f, float z = 0f, float w = 0f) => new(x, v.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OZXX(this float3 v, float x = 0f) => new(x, v.z, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OZXY(this float3 v, float x = 0f) => new(x, v.z, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OZXZ(this float3 v, float x = 0f) => new(x, v.z, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OZXO(this float3 v, float x = 0f, float w = 0f) => new(x, v.z, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OZYX(this float3 v, float x = 0f) => new(x, v.z, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OZYY(this float3 v, float x = 0f) => new(x, v.z, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OZYZ(this float3 v, float x = 0f) => new(x, v.z, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OZYO(this float3 v, float x = 0f, float w = 0f) => new(x, v.z, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OZZX(this float3 v, float x = 0f) => new(x, v.z, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OZZY(this float3 v, float x = 0f) => new(x, v.z, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OZZZ(this float3 v, float x = 0f) => new(x, v.z, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OZZO(this float3 v, float x = 0f, float w = 0f) => new(x, v.z, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OZOX(this float3 v, float x = 0f, float z = 0f) => new(x, v.z, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OZOY(this float3 v, float x = 0f, float z = 0f) => new(x, v.z, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OZOZ(this float3 v, float x = 0f, float z = 0f) => new(x, v.z, z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OZOO(this float3 v, float x = 0f, float z = 0f, float w = 0f) => new(x, v.z, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOXX(this float3 v, float x = 0f, float y = 0f) => new(x, y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOXY(this float3 v, float x = 0f, float y = 0f) => new(x, y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOXZ(this float3 v, float x = 0f, float y = 0f) => new(x, y, v.x, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOXO(this float3 v, float x = 0f, float y = 0f, float w = 0f) => new(x, y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOYX(this float3 v, float x = 0f, float y = 0f) => new(x, y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOYY(this float3 v, float x = 0f, float y = 0f) => new(x, y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOYZ(this float3 v, float x = 0f, float y = 0f) => new(x, y, v.y, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOYO(this float3 v, float x = 0f, float y = 0f, float w = 0f) => new(x, y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOZX(this float3 v, float x = 0f, float y = 0f) => new(x, y, v.z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOZY(this float3 v, float x = 0f, float y = 0f) => new(x, y, v.z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOZZ(this float3 v, float x = 0f, float y = 0f) => new(x, y, v.z, v.z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOZO(this float3 v, float x = 0f, float y = 0f, float w = 0f) => new(x, y, v.z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOOX(this float3 v, float x = 0f, float y = 0f, float z = 0f) => new(x, y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOOY(this float3 v, float x = 0f, float y = 0f, float z = 0f) => new(x, y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOOZ(this float3 v, float x = 0f, float y = 0f, float z = 0f) => new(x, y, z, v.z);
    }
}