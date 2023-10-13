using UnityEngine;

namespace DJM.Utilities.Curves
{
    public static class BezierCurve // https://www.youtube.com/watch?v=jvPPXbo87ds
    {
        public static Vector3 Quadratic(Vector3 point0, Vector3 point1, Vector3 point2,  float t)
        {
            var q0 = Vector3.Lerp(point0, point1, t);
            var q1 = Vector3.Lerp(point1, point2, t);
            return Vector3.Lerp(q0, q1, t);
        }
        
        // Bernstein
        public static Vector3 Cubic(Vector3 point0, Vector3 point1, Vector3 point2, Vector3 point3,  float t)
        {
            var tPow2 = Mathf.Pow(t, 2);
            var tPow3 = Mathf.Pow(t, 3);
            
            var p0 = point0 * (-tPow3 + 3 * tPow2 - 3 * t + 1);
            var p1 = point1 * (3 * tPow3 - 6 * tPow2 + 3 * t);
            var p2 = point2 * (-3 * tPow3 + 3 * tPow2); 
            var p3 = point3 * tPow3;

            return p0 + p1 + p2 + p3;
        }
        
        // Bernstein derivative
        public static Vector3 CubicDerivative(Vector3 point0, Vector3 point1, Vector3 point2, Vector3 point3,  float t)
        {
            var tPower2 = Mathf.Pow(t, 2);
            
            var p0 = point0 * (-3 * tPower2 + 6 * t - 3);
            var p1 = point1 * (9 * tPower2 - 12 * t + 3);
            var p2 = point2 * (-9 * tPower2 + 6 * t);
            var p3 = point3 * (3 * tPower2);

            return p0 + p1 + p2 + p3;
        }
        
        // // DeCasteljau
        // public static Vector3 Cubic(Vector3 point0, Vector3 point1, Vector3 point2, Vector3 point3,  float t)
        // {
        //     var q0 = Vector3.Lerp(point0, point1, t);
        //     var q1 = Vector3.Lerp(point1, point2, t);
        //     var q2 = Vector3.Lerp(point2, point3, t);
        //     
        //     var r0 = Vector3.Lerp(q0, q1, t);
        //     var r1 = Vector3.Lerp(q1, q2, t);
        //     
        //     return Vector3.Lerp(r0, r1, t);
        // }
        
        // // polynomial coefficients
        // public static Vector3 Cubic(Vector3 point0, Vector3 point1, Vector3 point2, Vector3 point3,  float t)
        // {
        //     var a = t * (-3 * point0 + 3 * point1);
        //     var b = Mathf.Pow(t, 2) * (3 * point0 - 6 * point1 + 3 * point2);
        //     var c = Mathf.Pow(t, 3) * (-point0 + 3 * point1 - 3 * point2 + point3);
        //     return point0 + a + b + c;
        // }
    }
}