using Unity.Mathematics;

namespace DJM.Utilities.Math
{
    public static class Offset2D
    {
        public static readonly int2 Up = new(0, 1);
        public static readonly int2 UpRight = new(1, 1);
        public static readonly int2 Right = new(1, 0);
        public static readonly int2 DownRight = new(1, -1);
        public static readonly int2 Down = new(0, -1);
        public static readonly int2 DownLeft = new(-1, -1);
        public static readonly int2 Left = new(-1, 0);
        public static readonly int2 UpLeft = new(-1, 1);
    }
}