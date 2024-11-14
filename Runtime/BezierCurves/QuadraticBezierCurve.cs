using System;
using Unity.Mathematics;

namespace DJM.Utilities.BezierCurves
{
    public readonly struct QuadraticBezierCurve : IEquatable<QuadraticBezierCurve>
    {
        public readonly float3 P0;
        public readonly float3 P1;
        public readonly float3 P2;
        
        public QuadraticBezierCurve Inverse => new(P2, P1, P0);
        
        public QuadraticBezierCurve(float3 p0, float3 p1, float3 p2)
        {
            P0 = p0;
            P1 = p1;
            P2 = p2;
        }

        public bool Equals(QuadraticBezierCurve other)
        {
            return P0.Equals(other.P0) && P1.Equals(other.P1) && P2.Equals(other.P2);
        }
        
        public override bool Equals(object obj)
        {
            return obj is QuadraticBezierCurve other && Equals(other);
        }
        
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = P0.GetHashCode();
                hashCode = (hashCode * 397) ^ P1.GetHashCode();
                hashCode = (hashCode * 397) ^ P2.GetHashCode();
                return hashCode;
            }
        }
        
        public static bool operator ==(QuadraticBezierCurve left, QuadraticBezierCurve right) => left.Equals(right);
        public static bool operator !=(QuadraticBezierCurve left, QuadraticBezierCurve right) => !left.Equals(right);
    }
}