using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class Vector2Extensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)] [Obsolete("Use XOY instead")]
        public static Vector3 X0Y(this Vector2 current, float y = 0f) => new(current.x, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)] [Obsolete("Use XYO instead")]
        public static Vector3 XY0(this Vector2 current, float z = 0f) => new(current.x, current.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float2 XXAsFloat(this Vector2 v) => new(v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float2 YXAsFloat(this Vector2 v) => new(v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float2 YYAsFloat(this Vector2 v) => new(v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 X0YAsFloat(this Vector2 current, float y = 0f) => new(current.x, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float3 XY0AsFloat(this Vector2 current, float z = 0f) => new(current.x, current.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static float2 AsFloat(this Vector2 v) => new(v.x, v.y);
        
        
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XXXX(this Vector2 current) => new(current.x, current.x, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XXXY(this Vector2 current) => new(current.x, current.x, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XXXO(this Vector2 current, float w = 0f) => new(current.x, current.x, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XXYX(this Vector2 current) => new(current.x, current.x, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XXYY(this Vector2 current) => new(current.x, current.x, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XXYO(this Vector2 current, float w = 0f) => new(current.x, current.x, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XXOX(this Vector2 current, float z = 0f) => new(current.x, current.x, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XXOY(this Vector2 current, float z = 0f) => new(current.x, current.x, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XXOO(this Vector2 current, float z = 0f, float w = 0f) => new(current.x, current.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XYXX(this Vector2 current) => new(current.x, current.y, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XYXY(this Vector2 current) => new(current.x, current.y, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XYXO(this Vector2 current, float w = 0f) => new(current.x, current.y, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XYYX(this Vector2 current) => new(current.x, current.y, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XYYY(this Vector2 current) => new(current.x, current.y, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XYYO(this Vector2 current, float w = 0f) => new(current.x, current.y, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XYOX(this Vector2 current, float z = 0f) => new(current.x, current.y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XYOY(this Vector2 current, float z = 0f) => new(current.x, current.y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XYOO(this Vector2 current, float z = 0f, float w = 0f) => new(current.x, current.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XOXX(this Vector2 current, float y = 0f) => new(current.x, y, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XOXY(this Vector2 current, float y = 0f) => new(current.x, y, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XOXO(this Vector2 current, float y = 0f, float w = 0f) => new(current.x, y, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XOYX(this Vector2 current, float y = 0f) => new(current.x, y, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XOYY(this Vector2 current, float y = 0f) => new(current.x, y, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XOYO(this Vector2 current, float y = 0f, float w = 0f) => new(current.x, y, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XOOX(this Vector2 current, float y = 0f, float z = 0f) => new(current.x, y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XOOY(this Vector2 current, float y = 0f, float z = 0f) => new(current.x, y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XOOO(this Vector2 current, float y = 0f, float z = 0f, float w = 0f) => new(current.x, y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YXXX(this Vector2 current) => new(current.y, current.x, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YXXY(this Vector2 current) => new(current.y, current.x, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YXXO(this Vector2 current, float w = 0f) => new(current.y, current.x, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YXYX(this Vector2 current) => new(current.y, current.x, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YXYY(this Vector2 current) => new(current.y, current.x, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YXYO(this Vector2 current, float w = 0f) => new(current.y, current.x, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YXOX(this Vector2 current, float z = 0f) => new(current.y, current.x, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YXOY(this Vector2 current, float z = 0f) => new(current.y, current.x, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YXOO(this Vector2 current, float z = 0f, float w = 0f) => new(current.y, current.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YYXX(this Vector2 current) => new(current.y, current.y, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YYXY(this Vector2 current) => new(current.y, current.y, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YYXO(this Vector2 current, float w = 0f) => new(current.y, current.y, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YYYX(this Vector2 current) => new(current.y, current.y, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YYYY(this Vector2 current) => new(current.y, current.y, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YYYO(this Vector2 current, float w = 0f) => new(current.y, current.y, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YYOX(this Vector2 current, float z = 0f) => new(current.y, current.y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YYOY(this Vector2 current, float z = 0f) => new(current.y, current.y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YYOO(this Vector2 current, float z = 0f, float w = 0f) => new(current.y, current.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YOXX(this Vector2 current, float y = 0f) => new(current.y, y, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YOXY(this Vector2 current, float y = 0f) => new(current.y, y, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YOXO(this Vector2 current, float y = 0f, float w = 0f) => new(current.y, y, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YOYX(this Vector2 current, float y = 0f) => new(current.y, y, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YOYY(this Vector2 current, float y = 0f) => new(current.y, y, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YOYO(this Vector2 current, float y = 0f, float w = 0f) => new(current.y, y, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YOOX(this Vector2 current, float y = 0f, float z = 0f) => new(current.y, y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YOOY(this Vector2 current, float y = 0f, float z = 0f) => new(current.y, y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 YOOO(this Vector2 current, float y = 0f, float z = 0f, float w = 0f) => new(current.y, y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OXXX(this Vector2 current, float x = 0f) => new(x, current.x, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OXXY(this Vector2 current, float x = 0f) => new(x, current.x, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OXXO(this Vector2 current, float x = 0f, float w = 0f) => new(x, current.x, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OXYX(this Vector2 current, float x = 0f) => new(x, current.x, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OXYY(this Vector2 current, float x = 0f) => new(x, current.x, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OXYO(this Vector2 current, float x = 0f, float w = 0f) => new(x, current.x, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OXOX(this Vector2 current, float x = 0f, float z = 0f) => new(x, current.x, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OXOY(this Vector2 current, float x = 0f, float z = 0f) => new(x, current.x, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OXOO(this Vector2 current, float x = 0f, float z = 0f, float w = 0f) => new(x, current.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OYXX(this Vector2 current, float x = 0f) => new(x, current.y, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OYXY(this Vector2 current, float x = 0f) => new(x, current.y, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OYXO(this Vector2 current, float x = 0f, float w = 0f) => new(x, current.y, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OYYX(this Vector2 current, float x = 0f) => new(x, current.y, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OYYY(this Vector2 current, float x = 0f) => new(x, current.y, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OYYO(this Vector2 current, float x = 0f, float w = 0f) => new(x, current.y, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OYOX(this Vector2 current, float x = 0f, float z = 0f) => new(x, current.y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OYOY(this Vector2 current, float x = 0f, float z = 0f) => new(x, current.y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OYOO(this Vector2 current, float x = 0f, float z = 0f, float w = 0f) => new(x, current.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OOOX(this Vector2 current, float x = 0f, float y = 0f, float z = 0f) => new(x, y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 OOOY(this Vector2 current, float x = 0f, float y = 0f, float z = 0f) => new(x, y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XXX(this Vector2 current) => new(current.x, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XXY(this Vector2 current) => new(current.x, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XXO(this Vector2 current, float z = 0f) => new(current.x, current.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XYX(this Vector2 current) => new(current.x, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XYY(this Vector2 current) => new(current.x, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XYO(this Vector2 current, float z = 0f) => new(current.x, current.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XOX(this Vector2 current, float y = 0f) => new(current.x, y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XOY(this Vector2 current, float y = 0f) => new(current.x, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XOO(this Vector2 current, float y = 0f, float z = 0f) => new(current.x, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YXX(this Vector2 current) => new(current.y, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YXY(this Vector2 current) => new(current.y, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YXO(this Vector2 current, float z = 0f) => new(current.y, current.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YYX(this Vector2 current) => new(current.y, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YYY(this Vector2 current) => new(current.y, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YYO(this Vector2 current, float z = 0f) => new(current.y, current.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YOX(this Vector2 current, float y = 0f) => new(current.y, y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YOY(this Vector2 current, float y = 0f) => new(current.y, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YOO(this Vector2 current, float y = 0f, float z = 0f) => new(current.y, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 OXX(this Vector2 current, float x = 0f) => new(x, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 OXY(this Vector2 current, float x = 0f) => new(x, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 OXO(this Vector2 current, float x = 0f, float z = 0f) => new(x, current.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 OYX(this Vector2 current, float x = 0f) => new(x, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 OYY(this Vector2 current, float x = 0f) => new(x, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 OYO(this Vector2 current, float x = 0f, float z = 0f) => new(x, current.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 OOX(this Vector2 current, float x = 0f, float y = 0f) => new(x, y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 OOY(this Vector2 current, float x = 0f, float y = 0f) => new(x, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 XX(this Vector2 v) => new(v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 XY(this Vector2 v) => v;
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 XO(this Vector2 current, float y = 0f) => new(current.x, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 YX(this Vector2 v) => new(v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 YY(this Vector2 v) => new(v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 YO(this Vector2 current, float y = 0f) => new(current.y, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 OX(this Vector2 current, float x = 0f) => new(x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 OY(this Vector2 current, float x = 0f) => new(x, current.y);
        

        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 AsFloat2(this Vector2 v) => new(v.x, v.y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 With(this Vector2 v, float? x = null, float? y = null) => new(x ?? v.x, y ?? v.y);
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