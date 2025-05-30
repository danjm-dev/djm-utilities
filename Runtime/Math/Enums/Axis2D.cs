using Unity.Burst;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities.Math
{
    public enum Axis2D : byte
    {
        X = 0,
        Y = 1
    }
    
    [BurstCompile]
    public static class Axis2DExtensions
    {
        [BurstCompile]
        public static void GetColor(this Axis2D axis, out UnityEngine.Color color)
        {
            color = axis switch
            {
                Axis2D.X => UnityEngine.Color.red,
                Axis2D.Y => UnityEngine.Color.green,
                _ => UnityEngine.Color.magenta
            };
        }
        
        [BurstDiscard]
        public static UnityEngine.Color GetColor(this Axis2D axis)
        {
            GetColor(axis, out var color);
            return color;
        }
        
        [BurstCompile]
        public static void GetDirection(this Axis2D axis, out float2 direction)
        {
            direction = axis switch
            {
                Axis2D.X => Direction2D.Right,
                Axis2D.Y => Direction2D.Up,
                _ => default
            };
        }
        
        [BurstDiscard]
        public static Vector2 GetDirection(this Axis2D axis)
        {
            GetDirection(axis, out var direction);
            return direction.AsVector2();
        }
    }
}