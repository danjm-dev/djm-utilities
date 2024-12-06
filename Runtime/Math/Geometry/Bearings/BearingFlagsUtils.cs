using Unity.Burst;
using Unity.Mathematics;

namespace DJM.Utilities.Math.Geometry
{
    [BurstCompile]
    internal static class BearingFlagsUtils
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