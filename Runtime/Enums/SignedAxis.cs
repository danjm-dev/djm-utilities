using DJM.Utilities.Math;
using Unity.Burst;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public enum SignedAxis : byte
    {
        PositiveX = 0,
        PositiveY = 1,
        PositiveZ = 2,
        NegativeX = 3,
        NegativeY = 4,
        NegativeZ = 5
    }
    
    [BurstCompile]
    public static class SignedAxisExtensions
    {
        [BurstCompile]
        public static Axis GetUnsignedAxis(this SignedAxis axis)
        {
            return axis switch
            {
                SignedAxis.PositiveX => Axis.X,
                SignedAxis.PositiveY => Axis.Y,
                SignedAxis.PositiveZ => Axis.Z,
                SignedAxis.NegativeX => Axis.X,
                SignedAxis.NegativeY => Axis.Y,
                SignedAxis.NegativeZ => Axis.Z,
                _ => default
            };
        }
        
        [BurstCompile]
        public static bool IsPositive(this SignedAxis axis)
        {
            return (int)axis < 3;
        }
        
        [BurstCompile]
        public static bool IsNegative(this SignedAxis axis)
        {
            return !IsPositive(axis);
        }
        
        [BurstCompile]
        public static void GetColor(this SignedAxis axis, out UnityEngine.Color color)
        {
            color = axis switch
            {
                SignedAxis.PositiveX => UnityEngine.Color.red,
                SignedAxis.PositiveY => UnityEngine.Color.green,
                SignedAxis.PositiveZ => UnityEngine.Color.blue,
                SignedAxis.NegativeX => UnityEngine.Color.red,
                SignedAxis.NegativeY => UnityEngine.Color.green,
                SignedAxis.NegativeZ => UnityEngine.Color.blue,
                _ => UnityEngine.Color.magenta
            };
        }
        
        [BurstDiscard]
        public static UnityEngine.Color GetColor(this SignedAxis axis)
        {
            GetColor(axis, out var color);
            return color;
        }
        
        [BurstCompile]
        public static void GetDirection(this SignedAxis axis, out float3 direction)
        {
            direction = axis switch
            {
                SignedAxis.PositiveX => Direction3D.Right,
                SignedAxis.PositiveY => Direction3D.Up,
                SignedAxis.PositiveZ => Direction3D.Forward,
                SignedAxis.NegativeX => Direction3D.Left,
                SignedAxis.NegativeY => Direction3D.Down,
                SignedAxis.NegativeZ => Direction3D.Back,
                _ => default
            };
        }
        
        [BurstDiscard]
        public static Vector3 GetDirection(this SignedAxis axis)
        {
            GetDirection(axis, out var direction);
            return direction.AsVector();
        }
    }
}