using Unity.Mathematics;

namespace DJM.Utilities.Math
{
    public static class Direction3D
    {
        public static readonly float3 Right = new(1, 0, 0);
        public static readonly float3 Up = new(0, 1, 0);
        public static readonly float3 Forward = new(0, 0, 1);
        public static readonly float3 Left = -Right;
        public static readonly float3 Down = -Up;
        public static readonly float3 Back = -Forward;
    }
}