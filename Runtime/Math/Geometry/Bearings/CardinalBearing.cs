using Unity.Burst;
using Unity.Mathematics;

namespace DJM.Utilities.Math.Geometry
{
    public enum CardinalBearing : byte
    {
        North = 0,
        East = 2,
        South = 4,
        West = 6
    }
    
    [System.Flags]
    public enum CardinalBearingFlags : byte
    {
        North = 1 << 0,
        East = 1 << 2,
        South = 1 << 4,
        West = 1 << 6,
        None = 0,
        All = North | East | South | West
    }
    
    [BurstCompile]
    public static class CardinalBearingExtensions
    {
        [BurstCompile]
        public static CardinalBearing WithOffset(this CardinalBearing bearing, int offset)
        {
            return (CardinalBearing)BearingUtils.WrapBearingIndex((int)bearing + offset * 2);
        }
        
        [BurstCompile]
        public static CardinalBearing Flip(this CardinalBearing bearing)
        {
            return (CardinalBearing)BearingUtils.WrapBearingIndex((int)bearing + 4);
        }
        
        [BurstCompile]
        public static CardinalBearing TurnLeft(this CardinalBearing bearing)
        {
            return (CardinalBearing)BearingUtils.WrapBearingIndex((int)bearing - 2);
        }
        
        [BurstCompile]
        public static CardinalBearing TurnRight(this CardinalBearing bearing)
        {
            return (CardinalBearing)BearingUtils.WrapBearingIndex((int)bearing + 2);
        }
        
        
        
        [BurstCompile]
        public static int AsIndex(this CardinalBearing bearing)
        {
            return (int)bearing;
        }
        
        [BurstCompile]
        public static byte AsRawValue(this CardinalBearing bearing)
        {
            return (byte)bearing;
        }
        
        [BurstCompile]
        public static CardinalBearingFlags AsFlags(this CardinalBearing bearing)
        {
            return BearingUtils.GetFlags(bearing);
        }
        
        [BurstCompile]
        public static OrdinalBearing AsLeftOrdinal(this CardinalBearing bearing)
        {
            return (OrdinalBearing)BearingUtils.WrapBearingIndex((int)bearing - 1);
        }
        
        [BurstCompile]
        public static OrdinalBearing AsRightOrdinal(this CardinalBearing bearing)
        {
            return (OrdinalBearing)BearingUtils.WrapBearingIndex((int)bearing + 1);
        }
        
        [BurstCompile]
        public static Bearing AsFullBearing(this CardinalBearing bearing)
        {
            return (Bearing)bearing;
        }
        
        

        [BurstCompile]
        public static void GetCoordinateOffset(this CardinalBearing bearing, out int2 coordinateOffset)
        {
            BearingUtils.GetCoordinateOffset((int)bearing, out coordinateOffset);
        }
        
        [BurstDiscard]
        public static int2 GetCoordinateOffset(this CardinalBearing bearing)
        {
            BearingUtils.GetCoordinateOffset((int)bearing, out var coordinateOffset);
            return coordinateOffset;
        }
        
        [BurstCompile]
        public static void GetDirection(this CardinalBearing bearing, out float2 direction)
        {
            BearingUtils.GetDirection((int)bearing, out direction);
        }
        
        [BurstDiscard]
        public static float2 GetDirection(this CardinalBearing bearing)
        {
            BearingUtils.GetDirection((int)bearing, out var direction);
            return direction;
        }
    }

    [BurstCompile]
    public static class CardinalBearingFlagsExtensions
    {
        [BurstCompile]
        public static CardinalBearingFlags WithFlags(this CardinalBearingFlags bearingFlags, CardinalBearingFlags other)
        {
            return BearingFlagsUtils.AppendFlags(bearingFlags, other);
        }
        
        [BurstCompile]
        public static CardinalBearingFlags WithFlags(this CardinalBearingFlags bearingFlags, BearingFlags other)
        {
            return BearingFlagsUtils.AppendFlags(bearingFlags, (CardinalBearingFlags)other & CardinalBearingFlags.All);
        }
        
        [BurstCompile]
        public static CardinalBearingFlags WithFlags(this CardinalBearingFlags bearingFlags, CardinalBearing other)
        {
            return BearingFlagsUtils.AppendFlags(bearingFlags, BearingUtils.GetFlags(other));
        }
        
        [BurstCompile]
        public static CardinalBearingFlags WithFlags(this CardinalBearingFlags bearingFlags, Bearing other)
        {
            return BearingFlagsUtils.AppendFlags
            (
                bearingFlags, 
                (CardinalBearingFlags)BearingUtils.GetFlags(other) & CardinalBearingFlags.All
            );
        }
        
        [BurstCompile]
        public static CardinalBearingFlags WithoutFlags(this CardinalBearingFlags bearingFlags, CardinalBearingFlags other)
        {
            return BearingFlagsUtils.RemoveFlags(bearingFlags, other);
        }
        
        [BurstCompile]
        public static CardinalBearingFlags WithoutFlags(this CardinalBearingFlags bearingFlags, BearingFlags other)
        {
            return BearingFlagsUtils.RemoveFlags(bearingFlags, (CardinalBearingFlags)other & CardinalBearingFlags.All);
        }
        
        [BurstCompile]
        public static CardinalBearingFlags WithoutFlags(this CardinalBearingFlags bearingFlags, CardinalBearing other)
        {
            return BearingFlagsUtils.RemoveFlags(bearingFlags, BearingUtils.GetFlags(other));
        }
        
        [BurstCompile]
        public static CardinalBearingFlags WithoutFlags(this CardinalBearingFlags bearingFlags, Bearing other)
        {
            return BearingFlagsUtils.RemoveFlags
            (
                bearingFlags, 
                (CardinalBearingFlags)BearingUtils.GetFlags(other) & CardinalBearingFlags.All
            );
        }
        
        
        [BurstCompile]
        public static bool Any(this CardinalBearingFlags bearingFlags)
        {
            return bearingFlags != CardinalBearingFlags.None;
        }
        
        [BurstCompile]
        public static bool HasAny(this CardinalBearingFlags bearingFlags, CardinalBearingFlags other)
        {
            return BearingFlagsUtils.HasAnyFlags(bearingFlags, other);
        }
        
        [BurstCompile]
        public static bool HasAny(this CardinalBearingFlags bearingFlags, BearingFlags other)
        {
            return BearingFlagsUtils.HasAnyFlags(bearingFlags, (CardinalBearingFlags)other);
        }
        
        [BurstCompile]
        public static bool HasAll(this CardinalBearingFlags bearingFlags, CardinalBearingFlags other)
        {
            return BearingFlagsUtils.HasAllFlags(bearingFlags, other);
        }
        
        [BurstCompile]
        public static bool HasAll(this CardinalBearingFlags bearingFlags, BearingFlags other)
        {
            return BearingFlagsUtils.HasAllFlags(bearingFlags, (CardinalBearingFlags)other);
        }
        
        [BurstCompile]
        public static bool Has(this CardinalBearingFlags bearingFlags, CardinalBearing other)
        {
            return BearingFlagsUtils.HasAllFlags(bearingFlags, BearingUtils.GetFlags(other));
        }
        
        [BurstCompile]
        public static bool Has(this CardinalBearingFlags bearingFlags, Bearing other)
        {
            return BearingFlagsUtils.HasAllFlags(bearingFlags, (CardinalBearingFlags)BearingUtils.GetFlags(other));
        }
        
        
        
        [BurstCompile]
        public static CardinalBearingFlags WithOffset(this CardinalBearingFlags bearingFlags, int offset)
        {
            return BearingFlagsUtils.OffsetFlags(bearingFlags, offset * 2);
        }
        
        [BurstCompile]
        public static CardinalBearingFlags Flip(this CardinalBearingFlags bearingFlags)
        {
            return BearingFlagsUtils.OffsetFlags(bearingFlags, 4);
        }
        
        [BurstCompile]
        public static CardinalBearingFlags TurnLeft(this CardinalBearingFlags bearingFlags)
        {
            return BearingFlagsUtils.OffsetFlags(bearingFlags, -2);
        }
        
        [BurstCompile]
        public static CardinalBearingFlags TurnRight(this CardinalBearingFlags bearingFlags)
        {
            return BearingFlagsUtils.OffsetFlags(bearingFlags, 2);
        }
        
        
        
        [BurstCompile]
        public static byte AsRawValue(this CardinalBearingFlags bearingFlags)
        {
            return (byte) bearingFlags;
        }
        
        [BurstCompile]
        public static BearingFlags AsFullBearingFlags(this CardinalBearingFlags bearingFlags)
        {
            return (BearingFlags)bearingFlags;
        }
        
        
        
        [BurstCompile]
        public static int GetCount(this CardinalBearingFlags bearingFlags)
        {
            return BearingFlagsUtils.GetFlagCount(bearingFlags);
        }
    }
}