using Unity.Burst;
using Unity.Mathematics;

namespace DJM.Utilities.Bearings
{
    public enum Bearing : byte
    {
        North = 0,
        NorthEast = 1,
        East = 2,
        SouthEast = 3,
        South = 4,
        SouthWest = 5,
        West = 6,
        NorthWest = 7
    }
    
    [System.Flags]
    public enum BearingFlags : byte
    {
        North = 1 << 0,
        NorthEast = 1 << 1,
        East = 1 << 2,
        SouthEast = 1 << 3,
        South = 1 << 4,
        SouthWest = 1 << 5,
        West = 1 << 6,
        NorthWest = 1 << 7,
        None = 0,
        All = North | NorthEast | East | SouthEast | South | SouthWest | West | NorthWest,
        AllCardinals = North | East | South | West,
        AllOrdinals = NorthEast | SouthEast | SouthWest | NorthWest
    }
    
    [BurstCompile]
    public static class BearingExtensions
    {
        [BurstCompile]
        public static Bearing WithOffset(this Bearing bearing, int offset)
        {
            return (Bearing)BearingUtils.WrapBearingIndex((int)bearing + offset);
        }
        
        [BurstCompile]
        public static Bearing Flip(this Bearing bearing)
        {
            return (Bearing)BearingUtils.WrapBearingIndex((int)bearing + 4);
        }
        
        [BurstCompile]
        public static Bearing TurnLeft(this Bearing bearing)
        {
            return (Bearing)BearingUtils.WrapBearingIndex((int)bearing - 1);
        }
        
        [BurstCompile]
        public static Bearing TurnRight(this Bearing bearing)
        {
            return (Bearing)BearingUtils.WrapBearingIndex((int)bearing + 1);
        }
        
        
        
        [BurstCompile]
        public static bool IsCardinal(this Bearing bearing)
        {
            return BearingUtils.IsBearingIndexCardinal((int)bearing);
        }
        
        [BurstCompile]
        public static bool IsOrdinal(this Bearing bearing)
        {
            return BearingUtils.IsBearingIndexOrdinal((int)bearing);
        }
        
        
        
        [BurstCompile]
        public static int AsIndex(this Bearing bearing)
        {
            return (int)bearing;
        }
        
        [BurstCompile]
        public static byte AsRawValue(this Bearing bearing)
        {
            return (byte)bearing;
        }
        
        [BurstCompile]
        public static BearingFlags AsFlags(this Bearing bearing)
        {
            return BearingUtils.GetFlags(bearing);
        }
        
        [BurstCompile]
        public static CardinalBearing AsCardinalBearing(this Bearing bearing)
        {
            return (CardinalBearing)bearing;
        }
        
        [BurstCompile]
        public static OrdinalBearing AsOrdinalBearing(this Bearing bearing)
        {
            return (OrdinalBearing)bearing;
        }
        
        
        
        [BurstCompile]
        public static void GetCoordinateOffset(this Bearing bearing, out int2 coordinateOffset)
        {
            BearingUtils.GetCoordinateOffset((int)bearing, out coordinateOffset);
        }
        
        [BurstDiscard]
        public static int2 GetCoordinateOffset(this Bearing bearing)
        {
            BearingUtils.GetCoordinateOffset((int)bearing, out var coordinateOffset);
            return coordinateOffset;
        }
        
        [BurstCompile]
        public static void GetDirection(this Bearing bearing, out float2 direction)
        {
            BearingUtils.GetDirection((int)bearing, out direction);
        }
        
        [BurstDiscard]
        public static float2 GetDirection(this Bearing bearing)
        {
            BearingUtils.GetDirection((int)bearing, out var direction);
            return direction;
        }
    }
    
    [BurstCompile]
    public static class BearingFlagsExtensions
    {
        [BurstCompile]
        public static BearingFlags WithFlags(this BearingFlags bearingFlags, BearingFlags other)
        {
            return BearingFlagsUtils.AppendFlags(bearingFlags, other);
        }
        
        [BurstCompile]
        public static BearingFlags WithFlags(this BearingFlags bearingFlags, CardinalBearingFlags other)
        {
            return BearingFlagsUtils.AppendFlags(bearingFlags, (BearingFlags)other);
        }
        
        [BurstCompile]
        public static BearingFlags WithFlags(this BearingFlags bearingFlags, OrdinalBearingFlags other)
        {
            return BearingFlagsUtils.AppendFlags(bearingFlags, (BearingFlags)other);
        }
        
        [BurstCompile]
        public static BearingFlags WithFlags(this BearingFlags bearingFlags, Bearing other)
        {
            return BearingFlagsUtils.AppendFlags(bearingFlags, BearingUtils.GetFlags(other));
        }
        
        [BurstCompile]
        public static BearingFlags WithFlags(this BearingFlags bearingFlags, CardinalBearing other)
        {
            return BearingFlagsUtils.AppendFlags(bearingFlags, (BearingFlags)BearingUtils.GetFlags(other));
        }
        
        [BurstCompile]
        public static BearingFlags WithFlags(this BearingFlags bearingFlags, OrdinalBearing other)
        {
            return BearingFlagsUtils.AppendFlags(bearingFlags, (BearingFlags)BearingUtils.GetFlags(other));
        }
        
        [BurstCompile]
        public static BearingFlags WithoutFlags(this BearingFlags bearingFlags, BearingFlags other)
        {
            return BearingFlagsUtils.RemoveFlags(bearingFlags, other);
        }
        
        [BurstCompile]
        public static BearingFlags WithoutFlags(this BearingFlags bearingFlags, CardinalBearingFlags other)
        {
            return BearingFlagsUtils.RemoveFlags(bearingFlags, (BearingFlags)other);
        }
        
        [BurstCompile]
        public static BearingFlags WithoutFlags(this BearingFlags bearingFlags, OrdinalBearingFlags other)
        {
            return BearingFlagsUtils.RemoveFlags(bearingFlags, (BearingFlags)other);
        }
        
        [BurstCompile]
        public static BearingFlags WithoutFlags(this BearingFlags bearingFlags, Bearing other)
        {
            return BearingFlagsUtils.RemoveFlags(bearingFlags, BearingUtils.GetFlags(other));
        }
        
        [BurstCompile]
        public static BearingFlags WithoutFlags(this BearingFlags bearingFlags, CardinalBearing other)
        {
            return BearingFlagsUtils.RemoveFlags(bearingFlags, (BearingFlags)BearingUtils.GetFlags(other));
        }
        
        [BurstCompile]
        public static BearingFlags WithoutFlags(this BearingFlags bearingFlags, OrdinalBearing other)
        {
            return BearingFlagsUtils.RemoveFlags(bearingFlags, (BearingFlags)BearingUtils.GetFlags(other));
        }
        
        
        
        [BurstCompile]
        public static bool HasAny(this BearingFlags bearingFlags, BearingFlags other)
        {
            return BearingFlagsUtils.HasAnyFlags(bearingFlags, other);
        }
        
        [BurstCompile]
        public static bool HasAny(this BearingFlags bearingFlags, CardinalBearingFlags other)
        {
            return BearingFlagsUtils.HasAnyFlags(bearingFlags, (BearingFlags)other);
        }
        
        [BurstCompile]
        public static bool HasAny(this BearingFlags bearingFlags, OrdinalBearingFlags other)
        {
            return BearingFlagsUtils.HasAnyFlags(bearingFlags, (BearingFlags)other);
        }
        
        [BurstCompile]
        public static bool HasAll(this BearingFlags bearingFlags, BearingFlags other)
        {
            return BearingFlagsUtils.HasAllFlags(bearingFlags, other);
        }
        
        [BurstCompile]
        public static bool HasAll(this BearingFlags bearingFlags, CardinalBearingFlags other)
        {
            return BearingFlagsUtils.HasAllFlags(bearingFlags, (BearingFlags)other);
        }
        
        [BurstCompile]
        public static bool HasAll(this BearingFlags bearingFlags, OrdinalBearingFlags other)
        {
            return BearingFlagsUtils.HasAllFlags(bearingFlags, (BearingFlags)other);
        }
        
        [BurstCompile]
        public static bool Has(this BearingFlags bearingFlags, Bearing other)
        {
            return BearingFlagsUtils.HasAllFlags(bearingFlags, BearingUtils.GetFlags(other));
        }
        
        [BurstCompile]
        public static bool Has(this BearingFlags bearingFlags, CardinalBearing other)
        {
            return BearingFlagsUtils.HasAllFlags(bearingFlags, (BearingFlags)BearingUtils.GetFlags(other));
        }
        
        [BurstCompile]
        public static bool Has(this BearingFlags bearingFlags, OrdinalBearing other)
        {
            return BearingFlagsUtils.HasAllFlags(bearingFlags, (BearingFlags)BearingUtils.GetFlags(other));
        }
        
        
        
        [BurstCompile]
        public static BearingFlags WithOffset(this BearingFlags bearingFlags, int offset)
        {
            return BearingFlagsUtils.OffsetFlags(bearingFlags, offset);
        }
        
        [BurstCompile]
        public static BearingFlags Flip(this BearingFlags bearingFlags)
        {
            return BearingFlagsUtils.OffsetFlags(bearingFlags, 4);
        }
        
        [BurstCompile]
        public static BearingFlags TurnLeft(this BearingFlags bearingFlags)
        {
            return BearingFlagsUtils.OffsetFlags(bearingFlags, -1);
        }
        
        [BurstCompile]
        public static BearingFlags TurnRight(this BearingFlags bearingFlags)
        {
            return BearingFlagsUtils.OffsetFlags(bearingFlags, 1);
        }
        
        
        
        [BurstCompile]
        public static byte AsRawValue(this BearingFlags bearingFlags)
        {
            return (byte)bearingFlags;
        }
        
        [BurstCompile]
        public static CardinalBearingFlags AsCardinalFlags(this BearingFlags bearingFlags)
        {
            return (CardinalBearingFlags)bearingFlags & CardinalBearingFlags.All;
        }
        
        [BurstCompile]
        public static OrdinalBearingFlags AsOrdinalFlags(this BearingFlags bearingFlags)
        {
            return (OrdinalBearingFlags)bearingFlags & OrdinalBearingFlags.All;
        }
        
        
        
        [BurstCompile]
        public static int GetCount(this BearingFlags bearingFlags)
        {
            return BearingFlagsUtils.GetFlagCount(bearingFlags);
        }
    }
}