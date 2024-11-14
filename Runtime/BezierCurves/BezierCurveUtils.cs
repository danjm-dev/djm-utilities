using Unity.Burst;
using Unity.Mathematics;

namespace DJM.Utilities.BezierCurves
{
    [BurstCompile]
    public static class BezierCurveUtils
    {
        [BurstCompile]
        public static void EvaluatePosition
        (
            in float3 p0, 
            in float3 p1, 
            in float3 p2, 
            in float3 p3, 
            in float t, 
            out float3 position
        )
        {
            var t1 = math.clamp(t, 0, 1);
            var t2 = t1 * t1;
            var t3 = t2 * t1;
            position =
                p0 * ( -1f * t3 + 3f * t2 - 3f * t1 + 1f ) +
                p1 * (  3f * t3 - 6f * t2 + 3f * t1) +
                p2 * ( -3f * t3 + 3f * t2) +
                p3 * (       t3 );
        }
        
        [BurstCompile]
        public static void EvaluatePosition(in CubicBezierCurve curve, in float t, out float3 position)
        {
            EvaluatePosition(curve.P0, curve.P1, curve.P2, curve.P3, t, out position);
        }
        
        [BurstCompile]
        public static void EvaluatePosition
        (
            in float3 p0, 
            in float3 p1, 
            in float3 p2, 
            in float t, 
            out float3 position
        )
        {
            var t1 = math.clamp(t, 0, 1);
            var t2 = t1 * t1;
            position =
                p0 * (1f - 2f * t1 + t2) +
                p1 * (2f * t1 - 2f * t2) +
                p2 * t2;
        }
        
        [BurstCompile]
        public static void EvaluatePosition(in QuadraticBezierCurve curve, in float t, out float3 position)
        {
            EvaluatePosition(curve.P0, curve.P1, curve.P2, t, out position);
        }
        
        [BurstCompile]
        public static void EvaluatePosition
        (
            in float2 p0, 
            in float2 p1, 
            in float2 p2, 
            in float2 p3, 
            in float t, 
            out float2 position
        )
        {
            var t1 = math.clamp(t, 0, 1);
            var t2 = t1 * t1;
            var t3 = t2 * t1;
            position =
                p0 * ( -1f * t3 + 3f * t2 - 3f * t1 + 1f ) +
                p1 * (  3f * t3 - 6f * t2 + 3f * t1) +
                p2 * ( -3f * t3 + 3f * t2) +
                p3 * (       t3 );
        }
        
        [BurstCompile]
        public static void EvaluatePosition(in CubicBezierCurve2D curve, in float t, out float2 position)
        {
            EvaluatePosition(curve.P0, curve.P1, curve.P2, curve.P3, t, out position);
        }
        
        [BurstCompile]
        public static void EvaluatePosition
        (
            in float2 p0, 
            in float2 p1, 
            in float2 p2, 
            in float t, 
            out float2 position
        )
        {
            var t1 = math.clamp(t, 0, 1);
            var t2 = t1 * t1;
            position =
                p0 * (1f - 2f * t1 + t2) +
                p1 * (2f * t1 - 2f * t2) +
                p2 * t2;
        }
        
        [BurstCompile]
        public static void EvaluatePosition(in QuadraticBezierCurve2D curve, in float t, out float2 position)
        {
            EvaluatePosition(curve.P0, curve.P1, curve.P2, t, out position);
        }
        
        [BurstCompile]
        public static void EvaluateTangent
        (
            in float3 p0, 
            in float3 p1, 
            in float3 p2, 
            in float3 p3, 
            in float t, 
            out float3 tangent
        )
        {
            var t1 = math.clamp(t, 0, 1);
            var t2 = t1 * t1;
            tangent =
                p0 * ( -3f * t2 +  6f * t1 - 3f ) +
                p1 * (  9f * t2 - 12f * t1 + 3f) +
                p2 * ( -9f * t2 +  6f * t1 ) +
                p3 * (  3f * t2 );
        }
        
        [BurstCompile]
        public static void EvaluateTangent(in CubicBezierCurve curve, in float t, out float3 tangent)
        {
            EvaluateTangent(curve.P0, curve.P1, curve.P2, curve.P3, t, out tangent);
        }
        
        [BurstCompile]
        public static void EvaluateTangent
        (
            in float3 p0, 
            in float3 p1, 
            in float3 p2, 
            in float t, 
            out float3 tangent
        )
        {
            var t1 = math.clamp(t, 0, 1);
            tangent = 
                2f * (1f - t1) * (p1 - p0) + 
                2f * t1 * (p2 - p1);
        }
        
        [BurstCompile]
        public static void EvaluateTangent(in QuadraticBezierCurve curve, in float t, out float3 tangent)
        {
            EvaluateTangent(curve.P0, curve.P1, curve.P2, t, out tangent);
        }
        
        [BurstCompile]
        public static void EvaluateTangent
        (
            in float2 p0, 
            in float2 p1, 
            in float2 p2, 
            in float2 p3, 
            in float t, 
            out float2 tangent
        )
        {
            var t1 = math.clamp(t, 0, 1);
            var t2 = t1 * t1;
            tangent =
                p0 * ( -3f * t2 +  6f * t1 - 3f ) +
                p1 * (  9f * t2 - 12f * t1 + 3f) +
                p2 * ( -9f * t2 +  6f * t1 ) +
                p3 * (  3f * t2 );
        }
        
        [BurstCompile]
        public static void EvaluateTangent(in CubicBezierCurve2D curve, in float t, out float2 tangent)
        {
            EvaluateTangent(curve.P0, curve.P1, curve.P2, curve.P3, t, out tangent);
        }
        
        [BurstCompile]
        public static void EvaluateTangent
        (
            in float2 p0, 
            in float2 p1, 
            in float2 p2, 
            in float t, 
            out float2 tangent
        )
        {
            var t1 = math.clamp(t, 0, 1);
            tangent = 
                2f * (1f - t1) * (p1 - p0) + 
                2f * t1 * (p2 - p1);
        }
        
        [BurstCompile]
        public static void EvaluateTangent(in QuadraticBezierCurve2D curve, in float t, out float2 tangent)
        {
            EvaluateTangent(curve.P0, curve.P1, curve.P2, t, out tangent);
        }
        
        [BurstCompile]
        public static void EvaluateAcceleration
        (
            in float3 p0, 
            in float3 p1, 
            in float3 p2, 
            in float3 p3, 
            in float t,
            out float3 acceleration
        )
        {
            var t1 = math.clamp(t, 0, 1);
            acceleration =
                p0 * ( -6f * t1 + 6f ) +
                p1 * ( 18f * t1 - 12f) +
                p2 * (-18f * t1 + 6f ) +
                p3 * (  6f * t1 );
        }
        
        [BurstCompile]
        public static void EvaluateAcceleration(in CubicBezierCurve curve, in float t, out float3 acceleration)
        {
            EvaluateAcceleration(curve.P0, curve.P1, curve.P2, curve.P3, t, out acceleration);
        }
        
        [BurstCompile]
        public static void EvaluateAcceleration
        (
            in float3 p0, 
            in float3 p1, 
            in float3 p2, 
            out float3 acceleration
        )
        {
            acceleration = 2f * (p2 - 2f * p1 + p0);
        }
        
        [BurstCompile]
        public static void EvaluateAcceleration(in QuadraticBezierCurve curve, out float3 acceleration)
        {
            EvaluateAcceleration(curve.P0, curve.P1, curve.P2, out acceleration);
        }
        
        [BurstCompile]
        public static void EvaluateAcceleration
        (
            in float2 p0, 
            in float2 p1, 
            in float2 p2, 
            in float2 p3, 
            in float t,
            out float2 acceleration
        )
        {
            var t1 = math.clamp(t, 0, 1);
            acceleration =
                p0 * ( -6f * t1 + 6f ) +
                p1 * ( 18f * t1 - 12f) +
                p2 * (-18f * t1 + 6f ) +
                p3 * (  6f * t1 );
        }
        
        [BurstCompile]
        public static void EvaluateAcceleration(in CubicBezierCurve2D curve, in float t, out float2 acceleration)
        {
            EvaluateAcceleration(curve.P0, curve.P1, curve.P2, curve.P3, t, out acceleration);
        }
        
        [BurstCompile]
        public static void EvaluateAcceleration
        (
            in float2 p0, 
            in float2 p1, 
            in float2 p2, 
            out float2 acceleration
        )
        {
            acceleration = 2f * (p2 - 2f * p1 + p0);
        }
        
        [BurstCompile]
        public static void EvaluateAcceleration(in CubicBezierCurve2D curve, out float2 acceleration)
        {
            EvaluateAcceleration(curve.P0, curve.P1, curve.P2, out acceleration);
        }
        
        [BurstCompile]
        public static float EvaluateCurvature
        (
            in float3 p0, 
            in float3 p1, 
            in float3 p2, 
            in float3 p3, 
            in float t
        )
        {
            var t1 = math.clamp(t, 0, 1);
            EvaluateTangent(p0, p1, p2, p3, t1, out var firstDerivative);
            EvaluateAcceleration(p0, p1, p2, p3, t1, out var secondDerivative);
            CalculateCurvature(firstDerivative, secondDerivative, out var curvature);
            return curvature;
        }
        
        [BurstCompile]
        public static float EvaluateCurvature(in CubicBezierCurve curve, in float t)
        {
            return EvaluateCurvature(curve.P0, curve.P1, curve.P2, curve.P3, t);
        }
        
        [BurstCompile]
        public static float EvaluateCurvature
        (
            in float3 p0, 
            in float3 p1, 
            in float3 p2,
            in float t
        )
        {
            var t1 = math.clamp(t, 0, 1);
            EvaluateTangent(p0, p1, p2, t1, out var firstDerivative);
            EvaluateAcceleration(p0, p1, p2, out var secondDerivative);
            CalculateCurvature(firstDerivative, secondDerivative, out var curvature);
            return curvature;
        }
        
        [BurstCompile]
        public static float EvaluateCurvature(in QuadraticBezierCurve curve, in float t)
        {
            return EvaluateCurvature(curve.P0, curve.P1, curve.P2, t);
        }
        
        [BurstCompile]
        public static float EvaluateCurvature
        (
            in float2 p0, 
            in float2 p1, 
            in float2 p2, 
            in float2 p3, 
            in float t
        )
        {
            var t1 = math.clamp(t, 0, 1);
            EvaluateTangent(p0, p1, p2, p3, t1, out var firstDerivative);
            EvaluateAcceleration(p0, p1, p2, p3, t1, out var secondDerivative);
            CalculateCurvature(firstDerivative, secondDerivative, out var curvature);
            return curvature;
        }
        
        [BurstCompile]
        public static float EvaluateCurvature(in CubicBezierCurve2D curve, in float t)
        {
            return EvaluateCurvature(curve.P0, curve.P1, curve.P2, curve.P3, t);
        }
        
        [BurstCompile]
        public static float EvaluateCurvature
        (
            in float2 p0, 
            in float2 p1, 
            in float2 p2,
            in float t
        )
        {
            var t1 = math.clamp(t, 0, 1);
            EvaluateTangent(p0, p1, p2, t1, out var firstDerivative);
            EvaluateAcceleration(p0, p1, p2, out var secondDerivative);
            CalculateCurvature(firstDerivative, secondDerivative, out var curvature);
            return curvature;
        }
        
        [BurstCompile]
        public static float EvaluateCurvature(in QuadraticBezierCurve2D curve, in float t)
        {
            return EvaluateCurvature(curve.P0, curve.P1, curve.P2, t);
        }
        
        [BurstCompile]
        private static void CalculateCurvature(in float3 firstDerivative, in float3 secondDerivative, out float curvature)
        {
            var firstDerivativeNormSq = math.lengthsq(firstDerivative);
            var secondDerivativeNormSq = math.lengthsq(secondDerivative);
            var derivativesDot = math.dot(firstDerivative, secondDerivative);

            curvature = 
                math.sqrt(firstDerivativeNormSq * secondDerivativeNormSq - derivativesDot * derivativesDot) / 
                (firstDerivativeNormSq * math.length(firstDerivative));
        }
        
        [BurstCompile]
        private static void CalculateCurvature(in float2 firstDerivative, in float2 secondDerivative, out float curvature)
        {
            var firstDerivativeNormSq = math.lengthsq(firstDerivative);
            var secondDerivativeNormSq = math.lengthsq(secondDerivative);
            var derivativesDot = math.dot(firstDerivative, secondDerivative);

            curvature = 
                math.sqrt(firstDerivativeNormSq * secondDerivativeNormSq - derivativesDot * derivativesDot) / 
                (firstDerivativeNormSq * math.length(firstDerivative));
        }
    }
}