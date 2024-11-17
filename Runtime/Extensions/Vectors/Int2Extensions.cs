using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class Int2Extensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static int3 X0Y(this int2 v, int y = 0) => new(v.x, y, v.y);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static int3 XY0(this int2 v, int z = 0) => new(v.x, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector3Int X0YAsVector(this int2 v, int y = 0) => new(v.x, y, v.y);
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector3Int XY0AsVector(this int2 v, int z = 0) => new(v.x, v.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2Int AsVector(this int2 v) => new(v.x, v.y);
        
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XXXO(this int2 current, int w = 0) => new(current.x, current.x, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XXYO(this int2 current, int w = 0) => new(current.x, current.x, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XXOX(this int2 current, int z = 0) => new(current.x, current.x, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XXOY(this int2 current, int z = 0) => new(current.x, current.x, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XXOO(this int2 current, int z = 0, int w = 0) => new(current.x, current.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XYXO(this int2 current, int w = 0) => new(current.x, current.y, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XYYO(this int2 current, int w = 0) => new(current.x, current.y, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XYOX(this int2 current, int z = 0) => new(current.x, current.y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XYOY(this int2 current, int z = 0) => new(current.x, current.y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XYOO(this int2 current, int z = 0, int w = 0) => new(current.x, current.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOXX(this int2 current, int y = 0) => new(current.x, y, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOXY(this int2 current, int y = 0) => new(current.x, y, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOXO(this int2 current, int y = 0, int w = 0) => new(current.x, y, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOYX(this int2 current, int y = 0) => new(current.x, y, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOYY(this int2 current, int y = 0) => new(current.x, y, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOYO(this int2 current, int y = 0, int w = 0) => new(current.x, y, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOOX(this int2 current, int y = 0, int z = 0) => new(current.x, y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOOY(this int2 current, int y = 0, int z = 0) => new(current.x, y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOOO(this int2 current, int y = 0, int z = 0, int w = 0) => new(current.x, y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YXXO(this int2 current, int w = 0) => new(current.y, current.x, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YXYO(this int2 current, int w = 0) => new(current.y, current.x, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YXOX(this int2 current, int z = 0) => new(current.y, current.x, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YXOY(this int2 current, int z = 0) => new(current.y, current.x, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YXOO(this int2 current, int z = 0, int w = 0) => new(current.y, current.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YYXO(this int2 current, int w = 0) => new(current.y, current.y, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YYYO(this int2 current, int w = 0) => new(current.y, current.y, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YYOX(this int2 current, int z = 0) => new(current.y, current.y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YYOY(this int2 current, int z = 0) => new(current.y, current.y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YYOO(this int2 current, int z = 0, int w = 0) => new(current.y, current.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOXX(this int2 current, int y = 0) => new(current.y, y, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOXY(this int2 current, int y = 0) => new(current.y, y, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOXO(this int2 current, int y = 0, int w = 0) => new(current.y, y, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOYX(this int2 current, int y = 0) => new(current.y, y, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOYY(this int2 current, int y = 0) => new(current.y, y, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOYO(this int2 current, int y = 0, int w = 0) => new(current.y, y, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOOX(this int2 current, int y = 0, int z = 0) => new(current.y, y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOOY(this int2 current, int y = 0, int z = 0) => new(current.y, y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOOO(this int2 current, int y = 0, int z = 0, int w = 0) => new(current.y, y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXXX(this int2 current, int x = 0) => new(x, current.x, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXXY(this int2 current, int x = 0) => new(x, current.x, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXXO(this int2 current, int x = 0, int w = 0) => new(x, current.x, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXYX(this int2 current, int x = 0) => new(x, current.x, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXYY(this int2 current, int x = 0) => new(x, current.x, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXYO(this int2 current, int x = 0, int w = 0) => new(x, current.x, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXOX(this int2 current, int x = 0, int z = 0) => new(x, current.x, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXOY(this int2 current, int x = 0, int z = 0) => new(x, current.x, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXOO(this int2 current, int x = 0, int z = 0, int w = 0) => new(x, current.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYXX(this int2 current, int x = 0) => new(x, current.y, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYXY(this int2 current, int x = 0) => new(x, current.y, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYXO(this int2 current, int x = 0, int w = 0) => new(x, current.y, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYYX(this int2 current, int x = 0) => new(x, current.y, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYYY(this int2 current, int x = 0) => new(x, current.y, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYYO(this int2 current, int x = 0, int w = 0) => new(x, current.y, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYOX(this int2 current, int x = 0, int z = 0) => new(x, current.y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYOY(this int2 current, int x = 0, int z = 0) => new(x, current.y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYOO(this int2 current, int x = 0, int z = 0, int w = 0) => new(x, current.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OOOX(this int2 current, int x = 0, int y = 0, int z = 0) => new(x, y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OOOY(this int2 current, int x = 0, int y = 0, int z = 0) => new(x, y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 XXO(this int2 current, int z = 0) => new(current.x, current.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 XYO(this int2 current, int z = 0) => new(current.x, current.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 XOX(this int2 current, int y = 0) => new(current.x, y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 XOY(this int2 current, int y = 0) => new(current.x, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 XOO(this int2 current, int y = 0, int z = 0) => new(current.x, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 YXO(this int2 current, int z = 0) => new(current.y, current.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 YYO(this int2 current, int z = 0) => new(current.y, current.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 YOX(this int2 current, int y = 0) => new(current.y, y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 YOY(this int2 current, int y = 0) => new(current.y, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 YOO(this int2 current, int y = 0, int z = 0) => new(current.y, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 OXX(this int2 current, int x = 0) => new(x, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 OXY(this int2 current, int x = 0) => new(x, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 OXO(this int2 current, int x = 0, int z = 0) => new(x, current.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 OYX(this int2 current, int x = 0) => new(x, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 OYY(this int2 current, int x = 0) => new(x, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 OYO(this int2 current, int x = 0, int z = 0) => new(x, current.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 OOX(this int2 current, int x = 0, int y = 0) => new(x, y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 OOY(this int2 current, int x = 0, int y = 0) => new(x, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 XO(this int2 current, int y = 0) => new(current.x, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 YO(this int2 current, int y = 0) => new(current.y, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 OX(this int2 current, int x = 0) => new(x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 OY(this int2 current, int x = 0) => new(x, current.y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int AsVector2Int(this int2 v) => new(v.x, v.y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 With(this int2 v, int? x = null, int? y = null) => new(x ?? v.x, y ?? v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 WithX(this int2 v, int x) => new(x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 WithY(this int2 v, int y) => new(v.x, y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 AddX(this int2 v, int x) => new(v.x + x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 AddY(this int2 v, int y) => new(v.x, v.y + y);
    }
}