using Unity.Mathematics;

namespace DJM.Utilities.Math.Geometry
{
    public readonly struct QuadraticBezierCurve2D
    {
        public readonly float2 P0;
        public readonly float2 P1;
        public readonly float2 P2;
        
        public QuadraticBezierCurve2D Inverse => new(P2, P1, P0);
        
        public QuadraticBezierCurve2D(float2 p0, float2 p1, float2 p2)
        {
            P0 = p0;
            P1 = p1;
            P2 = p2;
        }

        public bool Equals(QuadraticBezierCurve2D other)
        {
            return P0.Equals(other.P0) && P1.Equals(other.P1) && P2.Equals(other.P2);
        }
        
        public override bool Equals(object obj)
        {
            return obj is QuadraticBezierCurve2D other && Equals(other);
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
        
        public static bool operator ==(QuadraticBezierCurve2D left, QuadraticBezierCurve2D right) => left.Equals(right);
        public static bool operator !=(QuadraticBezierCurve2D left, QuadraticBezierCurve2D right) => !left.Equals(right);
    }
}