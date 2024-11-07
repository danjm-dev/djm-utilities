using Unity.Burst;
using Unity.Mathematics;

namespace DJM.Utilities.Bearings
{
    public enum OrdinalBearing : byte
    {
        NorthEast = 1,
        SouthEast = 3,
        SouthWest = 5,
        NorthWest = 7
    }
    
    [System.Flags]
    public enum OrdinalBearingFlags : byte
    {
        NorthEast = 1 << 1,
        SouthEast = 1 << 3,
        SouthWest = 1 << 5,
        NorthWest = 1 << 7,
        None = 0,
        All = NorthEast | SouthEast | SouthWest | NorthWest
    }
    
    [BurstCompile]
    public static class OrdinalBearingExtensions
    {
        [BurstCompile]
        public static OrdinalBearing WithOffset(this OrdinalBearing bearing, int offset)
        {
            return (OrdinalBearing)BearingUtils.WrapBearingIndex((int)bearing + offset * 2);
        }
        
        [BurstCompile]
        public static OrdinalBearing Flip(this OrdinalBearing bearing)
        {
            return (OrdinalBearing)BearingUtils.WrapBearingIndex((int)bearing + 4);
        }
        
        [BurstCompile]
        public static OrdinalBearing TurnLeft(this OrdinalBearing bearing)
        {
            return (OrdinalBearing)BearingUtils.WrapBearingIndex((int)bearing - 2);
        }
        
        [BurstCompile]
        public static OrdinalBearing TurnRight(this OrdinalBearing bearing)
        {
            return (OrdinalBearing)BearingUtils.WrapBearingIndex((int)bearing + 2);
        }
        
        
        
        [BurstCompile]
        public static int AsIndex(this OrdinalBearing bearing)
        {
            return (int)bearing;
        }
        
        [BurstCompile]
        public static byte AsRawValue(this OrdinalBearing bearing)
        {
            return (byte)bearing;
        }
        
        [BurstCompile]
        public static OrdinalBearingFlags AsFlags(this OrdinalBearing bearing)
        {
            return BearingUtils.GetFlags(bearing);
        }
        
        [BurstCompile]
        public static CardinalBearing AsLeftCardinal(this OrdinalBearing bearing)
        {
            return (CardinalBearing)BearingUtils.WrapBearingIndex((int)bearing - 1);
        }
        
        [BurstCompile]
        public static CardinalBearing AsRightCardinal(this OrdinalBearing bearing)
        {
            return (CardinalBearing)BearingUtils.WrapBearingIndex((int)bearing + 1);
        }
        
        [BurstCompile]
        public static Bearing AsBearing(this OrdinalBearing bearing)
        {
            return (Bearing)bearing;
        }
        
        

        [BurstCompile]
        public static void GetCoordinateOffset(this OrdinalBearing bearing, out int2 coordinateOffset)
        {
            BearingUtils.GetCoordinateOffset((int)bearing, out coordinateOffset);
        }
        
        [BurstDiscard]
        public static int2 GetCoordinateOffset(this OrdinalBearing bearing)
        {
            BearingUtils.GetCoordinateOffset((int)bearing, out var coordinateOffset);
            return coordinateOffset;
        }
        
        [BurstCompile]
        public static void GetDirection(this OrdinalBearing bearing, out float2 direction)
        {
            BearingUtils.GetDirection((int)bearing, out direction);
        }
        
        [BurstDiscard]
        public static float2 GetDirection(this OrdinalBearing bearing)
        {
            BearingUtils.GetDirection((int)bearing, out var direction);
            return direction;
        }
    }
    
    [BurstCompile]
    public static class OrdinalBearingFlagsExtensions
    {
        [BurstCompile]
        public static OrdinalBearingFlags With(this OrdinalBearingFlags bearingFlags, OrdinalBearingFlags other)
        {
            return BearingFlagsUtils.AppendFlags(bearingFlags, other);
        }
        
        [BurstCompile]
        public static OrdinalBearingFlags With(this OrdinalBearingFlags bearingFlags, BearingFlags other)
        {
            return BearingFlagsUtils.AppendFlags(bearingFlags, (OrdinalBearingFlags)other & OrdinalBearingFlags.All);
        }
        
        [BurstCompile]
        public static OrdinalBearingFlags With(this OrdinalBearingFlags bearingFlags, OrdinalBearing other)
        {
            return BearingFlagsUtils.AppendFlags(bearingFlags, BearingUtils.GetFlags(other));
        }
        
        [BurstCompile]
        public static OrdinalBearingFlags With(this OrdinalBearingFlags bearingFlags, Bearing other)
        {
            return BearingFlagsUtils.AppendFlags
            (
                bearingFlags, 
                (OrdinalBearingFlags)BearingUtils.GetFlags(other) & OrdinalBearingFlags.All
            );
        }
        
        [BurstCompile]
        public static OrdinalBearingFlags Without(this OrdinalBearingFlags bearingFlags, OrdinalBearingFlags other)
        {
            return BearingFlagsUtils.RemoveFlags(bearingFlags, other);
        }
        
        [BurstCompile]
        public static OrdinalBearingFlags Without(this OrdinalBearingFlags bearingFlags, BearingFlags other)
        {
            return BearingFlagsUtils.RemoveFlags(bearingFlags, (OrdinalBearingFlags)other & OrdinalBearingFlags.All);
        }
        
        [BurstCompile]
        public static OrdinalBearingFlags Without(this OrdinalBearingFlags bearingFlags, OrdinalBearing other)
        {
            return BearingFlagsUtils.RemoveFlags(bearingFlags, BearingUtils.GetFlags(other));
        }
        
        [BurstCompile]
        public static OrdinalBearingFlags Without(this OrdinalBearingFlags bearingFlags, Bearing other)
        {
            return BearingFlagsUtils.RemoveFlags
            (
                bearingFlags, 
                (OrdinalBearingFlags)BearingUtils.GetFlags(other) & OrdinalBearingFlags.All
            );
        }
        
        
        
        [BurstCompile]
        public static bool HasAny(this OrdinalBearingFlags bearingFlags, OrdinalBearingFlags other)
        {
            return BearingFlagsUtils.HasAnyFlags(bearingFlags, other);
        }
        
        [BurstCompile]
        public static bool HasAny(this OrdinalBearingFlags bearingFlags, BearingFlags other)
        {
            return BearingFlagsUtils.HasAnyFlags(bearingFlags, (OrdinalBearingFlags)other);
        }
        
        [BurstCompile]
        public static bool HasAll(this OrdinalBearingFlags bearingFlags, OrdinalBearingFlags other)
        {
            return BearingFlagsUtils.HasAllFlags(bearingFlags, other);
        }
        
        [BurstCompile]
        public static bool HasAll(this OrdinalBearingFlags bearingFlags, BearingFlags other)
        {
            return BearingFlagsUtils.HasAllFlags(bearingFlags, (OrdinalBearingFlags)other);
        }
        
        [BurstCompile]
        public static bool Has(this OrdinalBearingFlags bearingFlags, OrdinalBearing other)
        {
            return BearingFlagsUtils.HasAllFlags(bearingFlags, BearingUtils.GetFlags(other));
        }
        
        [BurstCompile]
        public static bool Has(this OrdinalBearingFlags bearingFlags, Bearing other)
        {
            return BearingFlagsUtils.HasAllFlags(bearingFlags, (OrdinalBearingFlags)BearingUtils.GetFlags(other));
        }
        
        
        
        [BurstCompile]
        public static OrdinalBearingFlags WithOffset(this OrdinalBearingFlags bearingFlags, int offset)
        {
            return BearingFlagsUtils.OffsetFlags(bearingFlags, offset * 2);
        }
        
        [BurstCompile]
        public static OrdinalBearingFlags Flip(this OrdinalBearingFlags bearingFlags)
        {
            return BearingFlagsUtils.OffsetFlags(bearingFlags, 4);
        }
        
        [BurstCompile]
        public static OrdinalBearingFlags TurnLeft(this OrdinalBearingFlags bearingFlags)
        {
            return BearingFlagsUtils.OffsetFlags(bearingFlags, -2);
        }
        
        [BurstCompile]
        public static OrdinalBearingFlags TurnRight(this OrdinalBearingFlags bearingFlags)
        {
            return BearingFlagsUtils.OffsetFlags(bearingFlags, 2);
        }
        
        
        
        [BurstCompile]
        public static byte AsRawValue(this OrdinalBearingFlags bearingFlags)
        {
            return (byte) bearingFlags;
        }
        
        [BurstCompile]
        public static BearingFlags AsBearingFlags(this OrdinalBearingFlags bearingFlags)
        {
            return (BearingFlags)bearingFlags;
        }
        
        
        
        [BurstCompile]
        public static int GetCount(this OrdinalBearingFlags bearingFlags)
        {
            return BearingFlagsUtils.GetFlagCount(bearingFlags);
        }
    }
}