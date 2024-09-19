﻿using Unity.Burst;
using Unity.Mathematics;

namespace DJM.Utilities.Math
{
    [BurstCompile]
    public static class MathUtils
    {
        public const float PI2 = math.PI * 2f;
        public const double PI2_DBL = math.PI_DBL * 2d;
        
        [BurstCompile]
        public static float MinkowskiDistance(in float2 point1, in float2 point2, in float p)
        {
            // manhattan distance is p = 1
            // euclidean distance is p = 2
            
            var deltaX = math.abs(point2.x - point1.x);
            var deltaY = math.abs(point2.y - point1.y);

            var distance = math.pow(math.pow(deltaX, p) + math.pow(deltaY, p), 1 / p);
            return distance;
        }
        
        [BurstCompile]
        public static void RotateDirection
        (
            in float2 direction, 
            in float angle, 
            out float2 rotatedDirection, 
            in AngleUnit angleUnit = AngleUnit.Radians
        )
        {
            var angleInRadians = GetAngleInRadians(angle, angleUnit);
            var cosTheta = math.cos(angleInRadians);
            var sinTheta = math.sin(angleInRadians);
            rotatedDirection = new float2
            (
                direction.x * cosTheta - direction.y * sinTheta,
                direction.x * sinTheta + direction.y * cosTheta
            );
        }
        
        [BurstCompile]
        public static void ClampMagnitude(ref float2 vector, in float maxLength)
        {
            var sqrMagnitude = math.lengthsq(vector);
            if (sqrMagnitude <= maxLength * maxLength) return;
            
            var num1 = math.sqrt(sqrMagnitude);
            
            vector = new float2
            (
                vector.x / num1 * maxLength, 
                vector.y / num1 * maxLength
            );
        }
        
        [BurstCompile]
        public static void ClampMagnitude(ref float3 vector, in float maxLength)
        {
            var sqrMagnitude = math.lengthsq(vector);
            if (sqrMagnitude <= maxLength * maxLength) return;
            
            var num1 = math.sqrt(sqrMagnitude);
            
            vector = new float3
            (
                vector.x / num1 * maxLength, 
                vector.y / num1 * maxLength, 
                vector.z / num1 * maxLength
            );
        }

        [BurstCompile]
        public static float GetEclipseRadius(in float2 direction, in float2 axisRadii)
        {
            var directionX = axisRadii.y * direction.x;
            var directionY = axisRadii.x * direction.y;
            
            var directionXSquare = directionX * directionX;
            var directionYSquare = directionY * directionY;

            return axisRadii.x * axisRadii.y / math.sqrt(directionXSquare + directionYSquare);
        }
        
        [BurstCompile]
        public static void GetDirection
        (
            in float angle, 
            out float2 direction, 
            in AngleUnit angleUnit = AngleUnit.Radians
        )
        {
            var angleInRadians = GetAngleInRadians(angle, angleUnit);
            direction = new float2(math.cos(angleInRadians), math.sin(angleInRadians));
        }

        [BurstCompile]
        private static float GetAngleInRadians(in float angle, in AngleUnit unit)
        {
            return unit == AngleUnit.Degrees ? math.radians(angle) : angle;
        }
    }
}