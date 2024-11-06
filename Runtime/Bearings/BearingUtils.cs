using DJM.Utilities.Math;
using Unity.Burst;
using Unity.Mathematics;

namespace DJM.Utilities.Bearings
{
    [BurstCompile]
    public static class BearingUtils
    {
        public const int BearingCount = 8;
        public const int CardinalBearingCount = 4;
        public const int OrdinalBearingCount = 4;
        
        public const int FlipOffset = 4;
        public const int LeftTurnOffset = -1;
        public const int RightTurnOffset = 1;

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
    
    [BurstCompile]
    public static class BearingFlagsUtils
    {
        [BurstCompile]
        public static BearingFlags AppendFlags(BearingFlags flags, BearingFlags other)
        {
            return flags | other;
        }
        
        [BurstCompile]
        public static CardinalBearingFlags AppendFlags(CardinalBearingFlags flags, CardinalBearingFlags other)
        {
            return (flags | other) & CardinalBearingFlags.All;
        }
        
        [BurstCompile]
        public static OrdinalBearingFlags AppendFlags(OrdinalBearingFlags flags, OrdinalBearingFlags other)
        {
            return (flags | other) & OrdinalBearingFlags.All;
        }
        
        [BurstCompile]
        public static BearingFlags RemoveFlags(BearingFlags flags, BearingFlags other)
        {
            return flags & ~other;
        }
        
        [BurstCompile]
        public static CardinalBearingFlags RemoveFlags(CardinalBearingFlags flags, CardinalBearingFlags other)
        {
            return flags & ~other;
        }
        
        [BurstCompile]
        public static OrdinalBearingFlags RemoveFlags(OrdinalBearingFlags flags, OrdinalBearingFlags other)
        {
            return flags & ~other;
        }
        
        
        
        [BurstCompile]
        public static bool HasAnyFlags(BearingFlags flags, BearingFlags other)
        {
            return (flags & other) > 0;
        }
        
        [BurstCompile]
        public static bool HasAnyFlags(CardinalBearingFlags flags, CardinalBearingFlags other)
        {
            return (flags & other) > 0;
        }
        
        [BurstCompile]
        public static bool HasAnyFlags(OrdinalBearingFlags flags, OrdinalBearingFlags other)
        {
            return (flags & other) > 0;
        }
        
        [BurstCompile]
        public static bool HasAllFlags(BearingFlags flags, BearingFlags other)
        {
            return (flags & other) == other;
        }
        
        [BurstCompile]
        public static bool HasAllFlags(CardinalBearingFlags flags, CardinalBearingFlags other)
        {
            return (flags & other) == other;
        }
        
        [BurstCompile]
        public static bool HasAllFlags(OrdinalBearingFlags flags, OrdinalBearingFlags other)
        {
            return (flags & other) == other;
        }
        
        
        
        [BurstCompile]
        public static BearingFlags OffsetFlags(BearingFlags flags, int amount)
        {
            return (BearingFlags)OffsetFlags((int)flags, amount) & BearingFlags.All;
        }
        
        [BurstCompile]
        public static CardinalBearingFlags OffsetFlags(CardinalBearingFlags flags, int amount)
        {
            return (CardinalBearingFlags)OffsetFlags((int)flags, amount) & CardinalBearingFlags.All;
        }
        
        [BurstCompile]
        public static OrdinalBearingFlags OffsetFlags(OrdinalBearingFlags flags, int amount)
        {
            return (OrdinalBearingFlags)OffsetFlags((int)flags, amount) & OrdinalBearingFlags.All;  
        }
        
        
        
        [BurstCompile]
        public static int GetFlagCount(BearingFlags bearingFlags)
        {
            return math.countbits((int)(bearingFlags & BearingFlags.All));
        }
        
        [BurstCompile]
        public static int GetFlagCount(CardinalBearingFlags bearingFlags)
        {
            return math.countbits((int)(bearingFlags & CardinalBearingFlags.All));
        }
        
        [BurstCompile]
        public static int GetFlagCount(OrdinalBearingFlags bearingFlags)
        {
            return math.countbits((int)(bearingFlags & OrdinalBearingFlags.All));
        }
        
        
        
        [BurstCompile]
        private static int OffsetFlags(int flags, int amount)
        {
            return BitUtils.ShiftAndWrapBits(flags, BearingUtils.BearingCount, amount);
        }
    }
    
}