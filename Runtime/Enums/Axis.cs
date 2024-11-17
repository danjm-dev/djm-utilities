using DJM.Utilities.Math;
using Unity.Burst;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public enum Axis : byte
    {
        X = 0,
        Y = 1,
        Z = 2
    }
    
    [BurstCompile]
    public static class AxisExtensions
    {
        [BurstCompile]
        public static void GetColor(this Axis axis, out UnityEngine.Color color)
        {
            color = axis switch
            {
                Axis.X => UnityEngine.Color.red,
                Axis.Y => UnityEngine.Color.green,
                Axis.Z => UnityEngine.Color.blue,
                _ => UnityEngine.Color.magenta
            };
        }
        
        [BurstDiscard]
        public static UnityEngine.Color GetColor(this Axis axis)
        {
            GetColor(axis, out var color);
            return color;
        }
        
        [BurstCompile]
        public static void GetDirection(this Axis axis, out float3 direction)
        {
            direction = axis switch
            {
                Axis.X => Direction3D.Right,
                Axis.Y => Direction3D.Up,
                Axis.Z => Direction3D.Forward,
                _ => default
            };
        }
        
        [BurstDiscard]
        public static Vector3 GetDirection(this Axis axis)
        {
            GetDirection(axis, out var direction);
            return direction.AsVector3();
        }
    }
}