using System.Collections.Generic;
using DJM.Utilities.Bearings;
using DJM.Utilities.Math;
using NUnit.Framework;
using Unity.Mathematics;

namespace DJM.Utilities.Tests.Bearings
{
    [TestFixture]
    internal sealed class BearingExtensionsTests
    {
        [TestCase(Bearing.North, 0, Bearing.North)]
        [TestCase(Bearing.SouthEast, 8, Bearing.SouthEast)]
        [TestCase(Bearing.West, -8, Bearing.West)]
        [TestCase(Bearing.SouthEast, 1, Bearing.South)]
        [TestCase(Bearing.West, -1, Bearing.SouthWest)]
        [TestCase(Bearing.SouthEast, 7, Bearing.East)]
        [TestCase(Bearing.West, -7, Bearing.NorthWest)]
        [TestCase(Bearing.SouthEast, 35, Bearing.West)]
        [TestCase(Bearing.West, -35, Bearing.SouthEast)]
        public void WithOffset_MatchingResult(Bearing initialBearing, int offsetAmount, Bearing expectedResult)
        {
            Assert.AreEqual(initialBearing.WithOffset(offsetAmount), expectedResult);
        }
        
        [TestCase(Bearing.North, Bearing.South)]
        [TestCase(Bearing.NorthEast, Bearing.SouthWest)]
        [TestCase(Bearing.East, Bearing.West)]
        [TestCase(Bearing.SouthEast, Bearing.NorthWest)]
        [TestCase(Bearing.South, Bearing.North)]
        [TestCase(Bearing.SouthWest, Bearing.NorthEast)]
        [TestCase(Bearing.West, Bearing.East)]
        [TestCase(Bearing.NorthWest, Bearing.SouthEast)]
        public void Flip_MatchingResult(Bearing initialBearing, Bearing expectedResult)
        {
            Assert.AreEqual(initialBearing.Flip(), expectedResult);
        }
        
        [TestCase(Bearing.North, Bearing.NorthWest)]
        [TestCase(Bearing.NorthEast, Bearing.North)]
        [TestCase(Bearing.East, Bearing.NorthEast)]
        [TestCase(Bearing.SouthEast, Bearing.East)]
        [TestCase(Bearing.South, Bearing.SouthEast)]
        [TestCase(Bearing.SouthWest, Bearing.South)]
        [TestCase(Bearing.West, Bearing.SouthWest)]
        [TestCase(Bearing.NorthWest, Bearing.West)]
        public void TurnLeft_MatchingResult(Bearing initialBearing, Bearing expectedResult)
        {
            Assert.AreEqual(initialBearing.TurnLeft(), expectedResult);
        }
        
        [TestCase(Bearing.North, Bearing.NorthEast)]
        [TestCase(Bearing.NorthEast, Bearing.East)]
        [TestCase(Bearing.East, Bearing.SouthEast)]
        [TestCase(Bearing.SouthEast, Bearing.South)]
        [TestCase(Bearing.South, Bearing.SouthWest)]
        [TestCase(Bearing.SouthWest, Bearing.West)]
        [TestCase(Bearing.West, Bearing.NorthWest)]
        [TestCase(Bearing.NorthWest, Bearing.North)]
        public void TurnRight_MatchingResult(Bearing initialBearing, Bearing expectedResult)
        {
            Assert.AreEqual(initialBearing.TurnRight(), expectedResult);
        }

        [TestCase(Bearing.North, true)]
        [TestCase(Bearing.NorthEast, false)]
        [TestCase(Bearing.East, true)]
        [TestCase(Bearing.SouthEast, false)]
        [TestCase(Bearing.South, true)]
        [TestCase(Bearing.SouthWest, false)]
        [TestCase(Bearing.West, true)]
        [TestCase(Bearing.NorthWest, false)]
        public void IsCardinal_MatchingResult(Bearing bearing, bool expectedResult)
        {
            Assert.AreEqual(bearing.IsCardinal(), expectedResult);
        }
        
        [TestCase(Bearing.North, false)]
        [TestCase(Bearing.NorthEast, true)]
        [TestCase(Bearing.East, false)]
        [TestCase(Bearing.SouthEast, true)]
        [TestCase(Bearing.South, false)]
        [TestCase(Bearing.SouthWest, true)]
        [TestCase(Bearing.West, false)]
        [TestCase(Bearing.NorthWest, true)]
        public void IsOrdinal_MatchingResult(Bearing bearing, bool expectedResult)
        {
            Assert.AreEqual(bearing.IsOrdinal(), expectedResult);
        }
        
        [TestCase(Bearing.North, BearingFlags.North)]
        [TestCase(Bearing.NorthEast, BearingFlags.NorthEast)]
        [TestCase(Bearing.East, BearingFlags.East)]
        [TestCase(Bearing.SouthEast, BearingFlags.SouthEast)]
        [TestCase(Bearing.South, BearingFlags.South)]
        [TestCase(Bearing.SouthWest, BearingFlags.SouthWest)]
        [TestCase(Bearing.West, BearingFlags.West)]
        [TestCase(Bearing.NorthWest, BearingFlags.NorthWest)]
        public void AsFlags_MatchingResult(Bearing bearing, BearingFlags expectedResult)
        {
            Assert.AreEqual(bearing.AsFlags(), expectedResult);
        }
        
        [TestCase(Bearing.North, CardinalBearing.North)]
        [TestCase(Bearing.East, CardinalBearing.East)]
        [TestCase(Bearing.South, CardinalBearing.South)]
        [TestCase(Bearing.West, CardinalBearing.West)]
        public void AsCardinalBearing_MatchingResult(Bearing bearing, CardinalBearing expectedResult)
        {
            Assert.AreEqual(bearing.AsCardinalBearing(), expectedResult);
        }
        
        [TestCase(Bearing.NorthEast, OrdinalBearing.NorthEast)]
        [TestCase(Bearing.SouthEast, OrdinalBearing.SouthEast)]
        [TestCase(Bearing.SouthWest, OrdinalBearing.SouthWest)]
        [TestCase(Bearing.NorthWest, OrdinalBearing.NorthWest)]
        public void AsOrdinalBearing_MatchingResult(Bearing bearing, OrdinalBearing expectedResult)
        {
            Assert.AreEqual(bearing.AsOrdinalBearing(), expectedResult);
        }
        
        [TestCase(Bearing.North)]
        [TestCase(Bearing.NorthEast)]
        [TestCase(Bearing.East)]
        [TestCase(Bearing.SouthEast)]
        [TestCase(Bearing.South)]
        [TestCase(Bearing.SouthWest)]
        [TestCase(Bearing.West)]
        [TestCase(Bearing.NorthWest)]
        public void GetCoordinateOffset_MatchingResult(Bearing bearing)
        {
            var expectedOffsetTable = new Dictionary<Bearing, int2>
            {
                [Bearing.North] = Offset2D.Up,
                [Bearing.NorthEast] = Offset2D.UpRight,
                [Bearing.East] = Offset2D.Right,
                [Bearing.SouthEast] = Offset2D.DownRight,
                [Bearing.South] = Offset2D.Down,
                [Bearing.SouthWest] = Offset2D.DownLeft,
                [Bearing.West] = Offset2D.Left,
                [Bearing.NorthWest] = Offset2D.UpLeft
            };

            Assert.AreEqual(bearing.GetCoordinateOffset(), expectedOffsetTable[bearing]);
        }
        
        [TestCase(Bearing.North)]
        [TestCase(Bearing.NorthEast)]
        [TestCase(Bearing.East)]
        [TestCase(Bearing.SouthEast)]
        [TestCase(Bearing.South)]
        [TestCase(Bearing.SouthWest)]
        [TestCase(Bearing.West)]
        [TestCase(Bearing.NorthWest)]
        public void GetDirection_MatchingResult(Bearing bearing)
        {
            var expectedDirectionTable = new Dictionary<Bearing, float2>
            {
                [Bearing.North] = Offset2D.Up,
                [Bearing.NorthEast] = math.normalize(Offset2D.UpRight),
                [Bearing.East] = Offset2D.Right,
                [Bearing.SouthEast] = math.normalize(Offset2D.DownRight),
                [Bearing.South] = Offset2D.Down,
                [Bearing.SouthWest] = math.normalize(Offset2D.DownLeft),
                [Bearing.West] = Offset2D.Left,
                [Bearing.NorthWest] = math.normalize(Offset2D.UpLeft)
            };
            
            Assert.AreEqual(bearing.GetDirection(), expectedDirectionTable[bearing]);
        }
    }
}