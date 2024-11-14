using System;
using Unity.Mathematics;

namespace DJM.Utilities.BezierCurves
{
    public readonly struct CubicBezierCurve : IEquatable<CubicBezierCurve>
    {
        public readonly float3 P0;
        public readonly float3 P1;
        public readonly float3 P2;
        public readonly float3 P3;
        
        public CubicBezierCurve Inverse => new(P3, P2, P1, P0);
        
        public CubicBezierCurve(float3 p0, float3 p1, float3 p2, float3 p3)
        {
            P0 = p0;
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public bool Equals(CubicBezierCurve other)
        {
            return P0.Equals(other.P0) && P1.Equals(other.P1) && P2.Equals(other.P2) && P3.Equals(other.P3);
        }
        
        public override bool Equals(object obj)
        {
            return obj is CubicBezierCurve other && Equals(other);
        }
        
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = P0.GetHashCode();
                hashCode = (hashCode * 397) ^ P1.GetHashCode();
                hashCode = (hashCode * 397) ^ P2.GetHashCode();
                hashCode = (hashCode * 397) ^ P3.GetHashCode();
                return hashCode;
            }
        }
        
        public static bool operator ==(CubicBezierCurve left, CubicBezierCurve right) => left.Equals(right);
        public static bool operator !=(CubicBezierCurve left, CubicBezierCurve right) => !left.Equals(right);
    }
}