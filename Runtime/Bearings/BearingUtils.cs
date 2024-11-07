using DJM.Utilities.Math;
using Unity.Burst;
using Unity.Mathematics;

namespace DJM.Utilities.Bearings
{
    [BurstCompile]
    internal static class BearingUtils
    {
        public const int BearingCount = 8;

        private static readonly int2[] CoordinateOffsets =
        {
            Offset2D.Up,
            Offset2D.UpRight,
            Offset2D.Right,
            Offset2D.DownRight,
            Offset2D.Down,
            Offset2D.DownLeft,
            Offset2D.Left,
            Offset2D.UpLeft
        };

        private static readonly float2[] Directions =
        {
            Direction2D.Up,
            Direction2D.UpRight,
            Direction2D.Right,
            Direction2D.DownRight,
            Direction2D.Down,
            Direction2D.DownLeft,
            Direction2D.Left,
            Direction2D.UpLeft
        };
        
        [BurstCompile]
        public static bool IsBearingIndexCardinal(int index)
        {
            return index % 2 == 0;
        }
        
        [BurstCompile]
        public static bool IsBearingIndexOrdinal(int index)
        {
            return !IsBearingIndexCardinal(index);
        }
        
        [BurstCompile]
        public static int WrapBearingIndex(int index)
        {
            return MathUtils.WrapIndex(index, BearingCount);
        }
        
        [BurstCompile]
        public static void GetCoordinateOffset(int bearingIndex, out int2 offset)
        {
            offset = CoordinateOffsets[bearingIndex];
        }

        [BurstCompile]
        public static void GetDirection(int bearingIndex, out float2 offset)
        {
            offset = Directions[bearingIndex];
        }
        
        [BurstCompile]
        public static BearingFlags GetFlags(Bearing bearing)
        {
            return (BearingFlags)(1 << (int)bearing) & BearingFlags.All;
        }
        
        [BurstCompile]
        public static CardinalBearingFlags GetFlags(CardinalBearing bearing)
        {
            return (CardinalBearingFlags)(1 << (int)bearing) & CardinalBearingFlags.All;
        }

        [BurstCompile]
        public static OrdinalBearingFlags GetFlags(OrdinalBearing bearing)
        {
            return (OrdinalBearingFlags)(1 << (int)bearing) & OrdinalBearingFlags.All;
        }
    }
}