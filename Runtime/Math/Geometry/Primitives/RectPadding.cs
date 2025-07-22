using System;
using UnityEngine;

namespace DJM.Utilities.Math.Geometry.Primitives
{
    public readonly struct RectPadding : IEquatable<RectPadding>
    {
        private readonly Vector4 _padding;
        
        public float Left => _padding.x;
        public float Top => _padding.y;
        public float Right => _padding.z;
        public float Bottom => _padding.w;

        public RectPadding(Vector4 padding)
        {
            _padding = padding; 
        }
        
        public RectPadding(float left, float top, float right, float bottom)
        {
            _padding = new Vector4(left, top, right, bottom);
        }

        public bool Equals(RectPadding other) => _padding.Equals(other._padding);
        public override bool Equals(object obj) => obj is RectPadding other && Equals(other);
        public override int GetHashCode() => _padding.GetHashCode();
        
        public static bool operator ==(RectPadding left, RectPadding right) => left.Equals(right);
        public static bool operator !=(RectPadding left, RectPadding right) => !left.Equals(right);
        
        public static implicit operator Vector4(RectPadding rectPadding) => rectPadding._padding;
        public static implicit operator RectPadding(Vector4 vector4) => new(vector4);
    }
}