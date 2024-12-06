using System.Collections.Generic;
using DJM.Utilities.Math;
using DJM.Utilities.Math.Geometry;
using NUnit.Framework;
using Unity.Mathematics;

namespace DJM.Utilities.Tests.Bearings
{
    [TestFixture]
    internal sealed class CardinalBearingExtensionsTests
    {
        [TestCase(CardinalBearing.North, 0, CardinalBearing.North)]
        [TestCase(CardinalBearing.South, 4, CardinalBearing.South)]
        [TestCase(CardinalBearing.West, -4, CardinalBearing.West)]
        [TestCase(CardinalBearing.South, 1, CardinalBearing.West)]
        [TestCase(CardinalBearing.West, -1, CardinalBearing.South)]
        [TestCase(CardinalBearing.South, 3, CardinalBearing.East)]
        [TestCase(CardinalBearing.West, -3, CardinalBearing.North)]
        [TestCase(CardinalBearing.South, 34, CardinalBearing.North)]
        [TestCase(CardinalBearing.West, -34, CardinalBearing.East)]
        public void WithOffset_MatchingResult(CardinalBearing initialBearing, int offsetAmount, CardinalBearing expectedResult)
        {
            Assert.AreEqual(initialBearing.WithOffset(offsetAmount), expectedResult);
        }
        
        [TestCase(CardinalBearing.North, CardinalBearing.South)]
        [TestCase(CardinalBearing.East, CardinalBearing.West)]
        [TestCase(CardinalBearing.South, CardinalBearing.North)]
        [TestCase(CardinalBearing.West, CardinalBearing.East)]
        public void Flip_MatchingResult(CardinalBearing initialBearing, CardinalBearing expectedResult)
        {
            Assert.AreEqual(initialBearing.Flip(), expectedResult);
        }
        
        [TestCase(CardinalBearing.North, CardinalBearing.West)]
        [TestCase(CardinalBearing.East, CardinalBearing.North)]
        [TestCase(CardinalBearing.South, CardinalBearing.East)]
        [TestCase(CardinalBearing.West, CardinalBearing.South)]
        public void TurnLeft_MatchingResult(CardinalBearing initialBearing, CardinalBearing expectedResult)
        {
            Assert.AreEqual(initialBearing.TurnLeft(), expectedResult);
        }
        
        [TestCase(CardinalBearing.North, CardinalBearing.East)]
        [TestCase(CardinalBearing.East, CardinalBearing.South)]
        [TestCase(CardinalBearing.South, CardinalBearing.West)]
        [TestCase(CardinalBearing.West, CardinalBearing.North)]
        public void TurnRight_MatchingResult(CardinalBearing initialBearing, CardinalBearing expectedResult)
        {
            Assert.AreEqual(initialBearing.TurnRight(), expectedResult);
        }
        
        [TestCase(CardinalBearing.North, CardinalBearingFlags.North)]
        [TestCase(CardinalBearing.East, CardinalBearingFlags.East)]
        [TestCase(CardinalBearing.South, CardinalBearingFlags.South)]
        [TestCase(CardinalBearing.West, CardinalBearingFlags.West)]
        public void AsFlags_MatchingResult(CardinalBearing bearing, CardinalBearingFlags expectedResult)
        {
            Assert.AreEqual(bearing.AsFlags(), expectedResult);
        }
        
        [TestCase(CardinalBearing.North, OrdinalBearing.NorthWest)]
        [TestCase(CardinalBearing.East, OrdinalBearing.NorthEast)]
        [TestCase(CardinalBearing.South, OrdinalBearing.SouthEast)]
        [TestCase(CardinalBearing.West, OrdinalBearing.SouthWest)]
        public void AsLeftOrdinal_MatchingResult(CardinalBearing bearing, OrdinalBearing expectedResult)
        {
            Assert.AreEqual(bearing.AsLeftOrdinal(), expectedResult);
        }
        
        [TestCase(CardinalBearing.North, OrdinalBearing.NorthEast)]
        [TestCase(CardinalBearing.East, OrdinalBearing.SouthEast)]
        [TestCase(CardinalBearing.South, OrdinalBearing.SouthWest)]
        [TestCase(CardinalBearing.West, OrdinalBearing.NorthWest)]
        public void AsRightOrdinal_MatchingResult(CardinalBearing bearing, OrdinalBearing expectedResult)
        {
            Assert.AreEqual(bearing.AsRightOrdinal(), expectedResult);
        }
        
        [TestCase(CardinalBearing.North, Bearing.North)]
        [TestCase(CardinalBearing.East, Bearing.East)]
        [TestCase(CardinalBearing.South, Bearing.South)]
        [TestCase(CardinalBearing.West, Bearing.West)]
        public void AsFullBearing_MatchingResult(CardinalBearing bearing, Bearing expectedResult)
        {
            Assert.AreEqual(bearing.AsFullBearing(), expectedResult);
        }
        
        [TestCase(CardinalBearing.North)]
        [TestCase(CardinalBearing.East)]
        [TestCase(CardinalBearing.South)]
        [TestCase(CardinalBearing.West)]
        public void GetCoordinateOffset_MatchingResult(CardinalBearing bearing)
        {
            var expectedOffsetTable = new Dictionary<CardinalBearing, int2>
            {
                [CardinalBearing.North] = Offset2D.Up,
                [CardinalBearing.East] = Offset2D.Right,
                [CardinalBearing.South] = Offset2D.Down,
                [CardinalBearing.West] = Offset2D.Left
            };

            Assert.AreEqual(bearing.GetCoordinateOffset(), expectedOffsetTable[bearing]);
        }
        
        [TestCase(CardinalBearing.North)]
        [TestCase(CardinalBearing.East)]
        [TestCase(CardinalBearing.South)]
        [TestCase(CardinalBearing.West)]
        public void GetDirection_MatchingResult(CardinalBearing bearing)
        {
            var expectedDirectionTable = new Dictionary<CardinalBearing, float2>
            {
                [CardinalBearing.North] = Offset2D.Up,
                [CardinalBearing.East] = Offset2D.Right,
                [CardinalBearing.South] = Offset2D.Down,
                [CardinalBearing.West] = Offset2D.Left
            };
            
            Assert.AreEqual(bearing.GetDirection(), expectedDirectionTable[bearing]);
        }
    }
}