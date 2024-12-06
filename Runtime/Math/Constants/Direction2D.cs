using Unity.Mathematics;

namespace DJM.Utilities.Math
{
    public static class Direction2D
    {
        private const float NormalizedOrdinalComponent = 0.70710678118654752440f;
        
        public static readonly float2 Up = new(0, 1);
        public static readonly float2 UpRight = new(NormalizedOrdinalComponent, NormalizedOrdinalComponent);
        public static readonly float2 Right = new(1, 0);
        public static readonly float2 DownRight = new(NormalizedOrdinalComponent, -NormalizedOrdinalComponent);
        public static readonly float2 Down = new(0, -1);
        public static readonly float2 DownLeft = new(-NormalizedOrdinalComponent, -NormalizedOrdinalComponent);
        public static readonly float2 Left = new(-1, 0);
        public static readonly float2 UpLeft = new(-NormalizedOrdinalComponent, NormalizedOrdinalComponent);
    }
}