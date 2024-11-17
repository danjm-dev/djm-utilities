using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class Float2Extensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete("Use XOY instead")]
        public static float3 X0Y(this float2 v, float y = 0f) => new(v.x, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete("Use XY0 instead")]
        public static float3 XY0(this float2 v, float z = 0f) => new(v.x, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector3 X0YAsVector(this float2 v, float y = 0f) => new(v.x, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector3 XY0AsVector(this float2 v, float z = 0f) => new(v.x, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2 AsVector(this float2 v) => new(v.x, v.y);


        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 AsVector2(this float2 v) => new(v.x, v.y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 With(this float2 v, float? x = null, float? y = null) => new(x ?? v.x, y ?? v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 WithX(this float2 v, float x) => new(x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 WithY(this float2 v, float y) => new(v.x, y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 AddX(this float2 v, float x) => new(v.x + x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 AddY(this float2 v, float y) => new(v.x, v.y + y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float2 XO(this float2 v, float y = 0f) => new(v.x, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float2 YO(this float2 v, float y = 0f) => new(v.y, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float2 OX(this float2 v, float x = 0f) => new(x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float2 OY(this float2 v, float x = 0f) => new(x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 XXO(this float2 v, float z = 0f) => new(v.x, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 XYO(this float2 v, float z = 0f) => new(v.x, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 XOX(this float2 v, float y = 0f) => new(v.x, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 XOY(this float2 v, float y = 0f) => new(v.x, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 XOO(this float2 v, float y = 0f, float z = 0f) => new(v.x, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 YXO(this float2 v, float z = 0f) => new(v.y, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 YYO(this float2 v, float z = 0f) => new(v.y, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 YOX(this float2 v, float y = 0f) => new(v.y, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 YOY(this float2 v, float y = 0f) => new(v.y, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 YOO(this float2 v, float y = 0f, float z = 0f) => new(v.y, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OXX(this float2 v, float x = 0f) => new(x, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OXY(this float2 v, float x = 0f) => new(x, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OXO(this float2 v, float x = 0f, float z = 0f) => new(x, v.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OYX(this float2 v, float x = 0f) => new(x, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OYY(this float2 v, float x = 0f) => new(x, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OYO(this float2 v, float x = 0f, float z = 0f) => new(x, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OOX(this float2 v, float x = 0f, float y = 0f) => new(x, y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float3 OOY(this float2 v, float x = 0f, float y = 0f) => new(x, y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XXXO(this float2 v, float w = 0f) => new(v.x, v.x, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XXYO(this float2 v, float w = 0f) => new(v.x, v.x, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XXOX(this float2 v, float z = 0f) => new(v.x, v.x, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XXOY(this float2 v, float z = 0f) => new(v.x, v.x, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XXOO(this float2 v, float z = 0f, float w = 0f) => new(v.x, v.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XYXO(this float2 v, float w = 0f) => new(v.x, v.y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XYYO(this float2 v, float w = 0f) => new(v.x, v.y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XYOX(this float2 v, float z = 0f) => new(v.x, v.y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XYOY(this float2 v, float z = 0f) => new(v.x, v.y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XYOO(this float2 v, float z = 0f, float w = 0f) => new(v.x, v.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOXX(this float2 v, float y = 0f) => new(v.x, y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOXY(this float2 v, float y = 0f) => new(v.x, y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOXO(this float2 v, float y = 0f, float w = 0f) => new(v.x, y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOYX(this float2 v, float y = 0f) => new(v.x, y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOYY(this float2 v, float y = 0f) => new(v.x, y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOYO(this float2 v, float y = 0f, float w = 0f) => new(v.x, y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOOX(this float2 v, float y = 0f, float z = 0f) => new(v.x, y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOOY(this float2 v, float y = 0f, float z = 0f) => new(v.x, y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 XOOO(this float2 v, float y = 0f, float z = 0f, float w = 0f) => new(v.x, y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YXXO(this float2 v, float w = 0f) => new(v.y, v.x, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YXYO(this float2 v, float w = 0f) => new(v.y, v.x, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YXOX(this float2 v, float z = 0f) => new(v.y, v.x, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YXOY(this float2 v, float z = 0f) => new(v.y, v.x, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YXOO(this float2 v, float z = 0f, float w = 0f) => new(v.y, v.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YYXO(this float2 v, float w = 0f) => new(v.y, v.y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YYYO(this float2 v, float w = 0f) => new(v.y, v.y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YYOX(this float2 v, float z = 0f) => new(v.y, v.y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YYOY(this float2 v, float z = 0f) => new(v.y, v.y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YYOO(this float2 v, float z = 0f, float w = 0f) => new(v.y, v.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOXX(this float2 v, float y = 0f) => new(v.y, y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOXY(this float2 v, float y = 0f) => new(v.y, y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOXO(this float2 v, float y = 0f, float w = 0f) => new(v.y, y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOYX(this float2 v, float y = 0f) => new(v.y, y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOYY(this float2 v, float y = 0f) => new(v.y, y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOYO(this float2 v, float y = 0f, float w = 0f) => new(v.y, y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOOX(this float2 v, float y = 0f, float z = 0f) => new(v.y, y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOOY(this float2 v, float y = 0f, float z = 0f) => new(v.y, y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 YOOO(this float2 v, float y = 0f, float z = 0f, float w = 0f) => new(v.y, y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXXX(this float2 v, float x = 0f) => new(x, v.x, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXXY(this float2 v, float x = 0f) => new(x, v.x, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXXO(this float2 v, float x = 0f, float w = 0f) => new(x, v.x, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXYX(this float2 v, float x = 0f) => new(x, v.x, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXYY(this float2 v, float x = 0f) => new(x, v.x, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXYO(this float2 v, float x = 0f, float w = 0f) => new(x, v.x, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXOX(this float2 v, float x = 0f, float z = 0f) => new(x, v.x, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXOY(this float2 v, float x = 0f, float z = 0f) => new(x, v.x, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OXOO(this float2 v, float x = 0f, float z = 0f, float w = 0f) => new(x, v.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYXX(this float2 v, float x = 0f) => new(x, v.y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYXY(this float2 v, float x = 0f) => new(x, v.y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYXO(this float2 v, float x = 0f, float w = 0f) => new(x, v.y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYYX(this float2 v, float x = 0f) => new(x, v.y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYYY(this float2 v, float x = 0f) => new(x, v.y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYYO(this float2 v, float x = 0f, float w = 0f) => new(x, v.y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYOX(this float2 v, float x = 0f, float z = 0f) => new(x, v.y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYOY(this float2 v, float x = 0f, float z = 0f) => new(x, v.y, z, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OYOO(this float2 v, float x = 0f, float z = 0f, float w = 0f) => new(x, v.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOXX(this float2 v, float x = 0f, float y = 0f) => new(x, y, v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOXY(this float2 v, float x = 0f, float y = 0f) => new(x, y, v.x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOXO(this float2 v, float x = 0f, float y = 0f, float w = 0f) => new(x, y, v.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOYX(this float2 v, float x = 0f, float y = 0f) => new(x, y, v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOYY(this float2 v, float x = 0f, float y = 0f) => new(x, y, v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOYO(this float2 v, float x = 0f, float y = 0f, float w = 0f) => new(x, y, v.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOOX(this float2 v, float x = 0f, float y = 0f, float z = 0f) => new(x, y, z, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static float4 OOOY(this float2 v, float x = 0f, float y = 0f, float z = 0f) => new(x, y, z, v.y);
    }
}