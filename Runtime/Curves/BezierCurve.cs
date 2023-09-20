using UnityEngine;

namespace DJM.Utilities.Curves
{
    public static class BezierCurve
    {
        public static Vector3 Quadratic(Vector3 point0, Vector3 point1, Vector3 point2,  float t)
        {
            var q0 = Vector3.Lerp(point0, point1, t);
            var q1 = Vector3.Lerp(point1, point2, t);
            return Vector3.Lerp(q0, q1, t);
        }
        
        public static Vector3 Cubic(Vector3 point0, Vector3 point1, Vector3 point2, Vector3 point3,  float t)
        {
            var q0 = Vector3.Lerp(point0, point1, t);
            var q1 = Vector3.Lerp(point1, point2, t);
            var q2 = Vector3.Lerp(point2, point3, t);
            
            var r0 = Vector3.Lerp(q0, q1, t);
            var r1 = Vector3.Lerp(q1, q2, t);
            
            return Vector3.Lerp(r0, r1, t);
        }
        
        public static Vector3 CubicDerivative(Vector3 point0, Vector3 point1, Vector3 point2, Vector3 point3,  float t)
        {
            var tPower2 = Mathf.Pow(t, 2);
            
            var p0 = point0 * (-3 * tPower2 + 6 * t - 3);
            var p1 = point1 * (9 * tPower2 - 12 * t + 3);
            var p2 = point2 * (-9 * tPower2 + 6 * t);
            var p3 = point3 * (3 * tPower2);

            return p0 + p1 + p2 + p3;
        }
    }
}