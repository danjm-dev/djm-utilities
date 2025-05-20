using Unity.Burst;
using Unity.Mathematics;
using UnityEngine;

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
        public static void GetNormalizedAxes
        (
            in float3 right, 
            in float3 up, 
            out float3 validRight, 
            out float3 validUp, 
            out float3 validForward
        )
        {
            validRight = math.normalizesafe(right, math.right());
            validUp = math.normalizesafe(up, math.up());
            validForward = math.normalize(math.cross(right, up));
        }
        
        [BurstDiscard]
        public static Vector2 ProjectOnPlane(this Vector2 v, Vector2 planeNormal)
        {
            float num1 = Vector2.Dot(planeNormal, planeNormal);
            if ((double) num1 < (double) Mathf.Epsilon) return v;
            float num2 = Vector2.Dot(v, planeNormal);
            return new Vector2(v.x - planeNormal.x * num2 / num1, v.y - planeNormal.y * num2 / num1);
        }
        
        [BurstDiscard]
        public static Vector4 Abs(in Vector4 v)
        {
            return math.abs(v);
        }
        
        [BurstDiscard]
        public static Vector3 Abs(in Vector3 v)
        {
            return math.abs(v);
        }
        
        [BurstDiscard]
        public static Vector2 Abs(in Vector2 v)
        {
            return math.abs(v);
        }
        
        [BurstCompile]
        private static float GetAngleInRadians(in float angle, in AngleUnit unit)
        {
            return unit == AngleUnit.Degrees ? math.radians(angle) : angle;
        }
        
        [BurstCompile]
        public static int WrapIndex(int index, int count)
        {
            return (index % count + count) % count;
        }
        
        [BurstCompile]
        public static void MultiplyVector(in float4x4 matrix, in float3 vector, out float3 result)
        {
            result.x = matrix.c0.x * vector.x + matrix.c1.x * vector.y + matrix.c2.x * vector.z;
            result.y = matrix.c0.y * vector.x + matrix.c1.y * vector.y + matrix.c2.y * vector.z;
            result.z = matrix.c0.z * vector.x + matrix.c1.z * vector.y + matrix.c2.z * vector.z;
        }
        
        [BurstCompile]
        public static void MultipleOfFloor(int value, in int multiple, out int result)
        {
            result = value - value % multiple;
        }
        
        [BurstCompile]
        public static void MultipleOfFloor(in int2 value, in int multiple, out int2 result)
        {
            result = value - value % multiple;
        }
        
        [BurstCompile]
        public static void MultipleOfFloor(in int3 value, in int multiple, out int3 result)
        {
            result = value - value % multiple;
        }
        
        [BurstCompile]
        public static void MultipleOfFloor(in int4 value, in int multiple, out int4 result)
        {
            result = value - value % multiple;
        }
        
        [BurstCompile]
        public static void MultipleOfCeil(in int value, in int multiple, out int result)
        {
            result = value + (multiple - value % multiple) % multiple;
        }
        
        [BurstCompile]
        public static void MultipleOfCeil(in int2 value, in int multiple, out int2 result)
        {
            result = value + (multiple - value % multiple) % multiple;
        }
        
        [BurstCompile]
        public static void MultipleOfCeil(in int3 value, in int multiple, out int3 result)
        {
            result = value + (multiple - value % multiple) % multiple;
        }
        [BurstCompile]
        public static void MultipleOfCeil(in int4 value, in int multiple, out int4 result)
        {
            result = value + (multiple - value % multiple) % multiple;
        }
    }
}