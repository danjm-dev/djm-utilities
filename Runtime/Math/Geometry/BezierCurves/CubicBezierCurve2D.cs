using System;
using Unity.Mathematics;

namespace DJM.Utilities.Math.Geometry
{
    public readonly struct CubicBezierCurve2D : IEquatable<CubicBezierCurve2D>
    {
        public readonly float2 P0;
        public readonly float2 P1;
        public readonly float2 P2;
        public readonly float2 P3;
        
        public CubicBezierCurve2D Inverse => new(P3, P2, P1, P0);
        
        public CubicBezierCurve2D(float2 p0, float2 p1, float2 p2, float2 p3)
        {
            P0 = p0;
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public bool Equals(CubicBezierCurve2D other)
        {
            return P0.Equals(other.P0) && P1.Equals(other.P1) && P2.Equals(other.P2) && P3.Equals(other.P3);
        }
        
        public override bool Equals(object obj)
        {
            return obj is CubicBezierCurve2D other && Equals(other);
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
        
        public static bool operator ==(CubicBezierCurve2D left, CubicBezierCurve2D right) => left.Equals(right);
        public static bool operator !=(CubicBezierCurve2D left, CubicBezierCurve2D right) => !left.Equals(right);
    }
}