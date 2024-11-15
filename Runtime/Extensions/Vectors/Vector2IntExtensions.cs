using System;
using System.Diagnostics.Contracts;

using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class Vector2IntExtensions
    {
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2Int XX(this Vector2Int v) => new(v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2Int YX(this Vector2Int v) => new(v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2Int YY(this Vector2Int v) => new(v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector3Int X0Y(this Vector2Int current, int y = 0) => new(current.x, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector3Int XY0(this Vector2Int current, int z = 0) => new(current.x, current.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2Int XXAsInt(this Vector2Int v) => new(v.x, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2Int YXAsInt(this Vector2Int v) => new(v.y, v.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector2Int YYAsInt(this Vector2Int v) => new(v.y, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector3Int X0YAsInt(this Vector2Int current, int y = 0) => new(current.x, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)][Obsolete]
        public static Vector3Int XY0AsInt(this Vector2Int current, int z = 0) => new(current.x, current.y, z);
        
        
        
        
        
        
        
        
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XXXO(this Vector2Int current, int w = 0) => new(current.x, current.x, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XXYO(this Vector2Int current, int w = 0) => new(current.x, current.x, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XXOX(this Vector2Int current, int z = 0) => new(current.x, current.x, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XXOY(this Vector2Int current, int z = 0) => new(current.x, current.x, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XXOO(this Vector2Int current, int z = 0, int w = 0) => new(current.x, current.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XYXO(this Vector2Int current, int w = 0) => new(current.x, current.y, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XYYO(this Vector2Int current, int w = 0) => new(current.x, current.y, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XYOX(this Vector2Int current, int z = 0) => new(current.x, current.y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XYOY(this Vector2Int current, int z = 0) => new(current.x, current.y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XYOO(this Vector2Int current, int z = 0, int w = 0) => new(current.x, current.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOXX(this Vector2Int current, int y = 0) => new(current.x, y, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOXY(this Vector2Int current, int y = 0) => new(current.x, y, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOXO(this Vector2Int current, int y = 0, int w = 0) => new(current.x, y, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOYX(this Vector2Int current, int y = 0) => new(current.x, y, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOYY(this Vector2Int current, int y = 0) => new(current.x, y, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOYO(this Vector2Int current, int y = 0, int w = 0) => new(current.x, y, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOOX(this Vector2Int current, int y = 0, int z = 0) => new(current.x, y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOOY(this Vector2Int current, int y = 0, int z = 0) => new(current.x, y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 XOOO(this Vector2Int current, int y = 0, int z = 0, int w = 0) => new(current.x, y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YXXO(this Vector2Int current, int w = 0) => new(current.y, current.x, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YXYO(this Vector2Int current, int w = 0) => new(current.y, current.x, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YXOX(this Vector2Int current, int z = 0) => new(current.y, current.x, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YXOY(this Vector2Int current, int z = 0) => new(current.y, current.x, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YXOO(this Vector2Int current, int z = 0, int w = 0) => new(current.y, current.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YYXO(this Vector2Int current, int w = 0) => new(current.y, current.y, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YYYO(this Vector2Int current, int w = 0) => new(current.y, current.y, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YYOX(this Vector2Int current, int z = 0) => new(current.y, current.y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YYOY(this Vector2Int current, int z = 0) => new(current.y, current.y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YYOO(this Vector2Int current, int z = 0, int w = 0) => new(current.y, current.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOXX(this Vector2Int current, int y = 0) => new(current.y, y, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOXY(this Vector2Int current, int y = 0) => new(current.y, y, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOXO(this Vector2Int current, int y = 0, int w = 0) => new(current.y, y, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOYX(this Vector2Int current, int y = 0) => new(current.y, y, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOYY(this Vector2Int current, int y = 0) => new(current.y, y, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOYO(this Vector2Int current, int y = 0, int w = 0) => new(current.y, y, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOOX(this Vector2Int current, int y = 0, int z = 0) => new(current.y, y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOOY(this Vector2Int current, int y = 0, int z = 0) => new(current.y, y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 YOOO(this Vector2Int current, int y = 0, int z = 0, int w = 0) => new(current.y, y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXXX(this Vector2Int current, int x = 0) => new(x, current.x, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXXY(this Vector2Int current, int x = 0) => new(x, current.x, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXXO(this Vector2Int current, int x = 0, int w = 0) => new(x, current.x, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXYX(this Vector2Int current, int x = 0) => new(x, current.x, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXYY(this Vector2Int current, int x = 0) => new(x, current.x, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXYO(this Vector2Int current, int x = 0, int w = 0) => new(x, current.x, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXOX(this Vector2Int current, int x = 0, int z = 0) => new(x, current.x, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXOY(this Vector2Int current, int x = 0, int z = 0) => new(x, current.x, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OXOO(this Vector2Int current, int x = 0, int z = 0, int w = 0) => new(x, current.x, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYXX(this Vector2Int current, int x = 0) => new(x, current.y, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYXY(this Vector2Int current, int x = 0) => new(x, current.y, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYXO(this Vector2Int current, int x = 0, int w = 0) => new(x, current.y, current.x, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYYX(this Vector2Int current, int x = 0) => new(x, current.y, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYYY(this Vector2Int current, int x = 0) => new(x, current.y, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYYO(this Vector2Int current, int x = 0, int w = 0) => new(x, current.y, current.y, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYOX(this Vector2Int current, int x = 0, int z = 0) => new(x, current.y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYOY(this Vector2Int current, int x = 0, int z = 0) => new(x, current.y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OYOO(this Vector2Int current, int x = 0, int z = 0, int w = 0) => new(x, current.y, z, w);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OOOX(this Vector2Int current, int x = 0, int y = 0, int z = 0) => new(x, y, z, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 OOOY(this Vector2Int current, int x = 0, int y = 0, int z = 0) => new(x, y, z, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int XXO(this Vector2Int current, int z = 0) => new(current.x, current.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int XYO(this Vector2Int current, int z = 0) => new(current.x, current.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int XOX(this Vector2Int current, int y = 0) => new(current.x, y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int XOY(this Vector2Int current, int y = 0) => new(current.x, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int XOO(this Vector2Int current, int y = 0, int z = 0) => new(current.x, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int YXO(this Vector2Int current, int z = 0) => new(current.y, current.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int YYO(this Vector2Int current, int z = 0) => new(current.y, current.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int YOX(this Vector2Int current, int y = 0) => new(current.y, y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int YOY(this Vector2Int current, int y = 0) => new(current.y, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int YOO(this Vector2Int current, int y = 0, int z = 0) => new(current.y, y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int OXX(this Vector2Int current, int x = 0) => new(x, current.x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int OXY(this Vector2Int current, int x = 0) => new(x, current.x, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int OXO(this Vector2Int current, int x = 0, int z = 0) => new(x, current.x, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int OYX(this Vector2Int current, int x = 0) => new(x, current.y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int OYY(this Vector2Int current, int x = 0) => new(x, current.y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int OYO(this Vector2Int current, int x = 0, int z = 0) => new(x, current.y, z);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int OOX(this Vector2Int current, int x = 0, int y = 0) => new(x, y, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int OOY(this Vector2Int current, int x = 0, int y = 0) => new(x, y, current.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int XO(this Vector2Int current, int y = 0) => new(current.x, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int YO(this Vector2Int current, int y = 0) => new(current.y, y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int OX(this Vector2Int current, int x = 0) => new(x, current.x);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int OY(this Vector2Int current, int x = 0) => new(x, current.y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 AsInt(this Vector2Int v) => new(v.x, v.y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int WithX(this Vector2Int v, int x) => new(x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int WithY(this Vector2Int v, int y) => new(v.x, y);
        
        
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int AddX(this Vector2Int v, int x) => new(v.x + x, v.y);
        [Pure, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int AddY(this Vector2Int v, int y) => new(v.x, v.y + y);
    }
}