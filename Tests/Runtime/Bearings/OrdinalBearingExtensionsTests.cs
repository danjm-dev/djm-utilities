using System.Collections.Generic;
using DJM.Utilities.Bearings;
using DJM.Utilities.Math;
using NUnit.Framework;
using Unity.Mathematics;

namespace DJM.Utilities.Tests.Bearings
{
    [TestFixture]
    internal sealed class OrdinalBearingExtensionsTests
    {
        [TestCase(OrdinalBearing.NorthWest, 0, OrdinalBearing.NorthWest)]
        [TestCase(OrdinalBearing.SouthEast, 4, OrdinalBearing.SouthEast)]
        [TestCase(OrdinalBearing.SouthEast, -4, OrdinalBearing.SouthEast)]
        [TestCase(OrdinalBearing.SouthEast, 1, OrdinalBearing.SouthWest)]
        [TestCase(OrdinalBearing.NorthWest, -1, OrdinalBearing.SouthWest)]
        [TestCase(OrdinalBearing.SouthEast, 3, OrdinalBearing.NorthEast)]
        [TestCase(OrdinalBearing.NorthWest, -3, OrdinalBearing.NorthEast)]
        [TestCase(OrdinalBearing.SouthEast, 34, OrdinalBearing.NorthWest)]
        [TestCase(OrdinalBearing.NorthWest, -34, OrdinalBearing.SouthEast)]
        public void WithOffset_MatchingResult(OrdinalBearing initialBearing, int offsetAmount, OrdinalBearing expectedResult)
        {
            Assert.AreEqual(initialBearing.WithOffset(offsetAmount), expectedResult);
        }
        
        [TestCase(OrdinalBearing.NorthEast, OrdinalBearing.SouthWest)]
        [TestCase(OrdinalBearing.SouthEast, OrdinalBearing.NorthWest)]
        [TestCase(OrdinalBearing.SouthWest, OrdinalBearing.NorthEast)]
        [TestCase(OrdinalBearing.NorthWest, OrdinalBearing.SouthEast)]
        public void Flip_MatchingResult(OrdinalBearing initialBearing, OrdinalBearing expectedResult)
        {
            Assert.AreEqual(initialBearing.Flip(), expectedResult);
        }
        
        [TestCase(OrdinalBearing.NorthEast, OrdinalBearing.NorthWest)]
        [TestCase(OrdinalBearing.SouthEast, OrdinalBearing.NorthEast)]
        [TestCase(OrdinalBearing.SouthWest, OrdinalBearing.SouthEast)]
        [TestCase(OrdinalBearing.NorthWest, OrdinalBearing.SouthWest)]
        public void TurnLeft_MatchingResult(OrdinalBearing initialBearing, OrdinalBearing expectedResult)
        {
            Assert.AreEqual(initialBearing.TurnLeft(), expectedResult);
        }
        
        [TestCase(OrdinalBearing.NorthEast, OrdinalBearing.SouthEast)]
        [TestCase(OrdinalBearing.SouthEast, OrdinalBearing.SouthWest)]
        [TestCase(OrdinalBearing.SouthWest, OrdinalBearing.NorthWest)]
        [TestCase(OrdinalBearing.NorthWest, OrdinalBearing.NorthEast)]
        public void TurnRight_MatchingResult(OrdinalBearing initialBearing, OrdinalBearing expectedResult)
        {
            Assert.AreEqual(initialBearing.TurnRight(), expectedResult);
        }
        
        [TestCase(OrdinalBearing.NorthEast, OrdinalBearingFlags.NorthEast)]
        [TestCase(OrdinalBearing.SouthEast, OrdinalBearingFlags.SouthEast)]
        [TestCase(OrdinalBearing.SouthWest, OrdinalBearingFlags.SouthWest)]
        [TestCase(OrdinalBearing.NorthWest, OrdinalBearingFlags.NorthWest)]
        public void AsFlags_MatchingResult(OrdinalBearing bearing, OrdinalBearingFlags expectedResult)
        {
            Assert.AreEqual(bearing.AsFlags(), expectedResult);
        }
        
        [TestCase(OrdinalBearing.NorthEast, CardinalBearing.North)]
        [TestCase(OrdinalBearing.SouthEast, CardinalBearing.East)]
        [TestCase(OrdinalBearing.SouthWest, CardinalBearing.South)]
        [TestCase(OrdinalBearing.NorthWest, CardinalBearing.West)]
        public void AsLeftCardinal_MatchingResult(OrdinalBearing bearing, CardinalBearing expectedResult)
        {
            Assert.AreEqual(bearing.AsLeftCardinal(), expectedResult);
        }
        
        [TestCase(OrdinalBearing.NorthEast, CardinalBearing.East)]
        [TestCase(OrdinalBearing.SouthEast, CardinalBearing.South)]
        [TestCase(OrdinalBearing.SouthWest, CardinalBearing.West)]
        [TestCase(OrdinalBearing.NorthWest, CardinalBearing.North)]
        public void AsRightCardinal_MatchingResult(OrdinalBearing bearing, CardinalBearing expectedResult)
        {
            Assert.AreEqual(bearing.AsRightCardinal(), expectedResult);
        }
        
        [TestCase(OrdinalBearing.NorthEast, Bearing.NorthEast)]
        [TestCase(OrdinalBearing.SouthEast, Bearing.SouthEast)]
        [TestCase(OrdinalBearing.SouthWest, Bearing.SouthWest)]
        [TestCase(OrdinalBearing.NorthWest, Bearing.NorthWest)]
        public void AsFullBearing_MatchingResult(OrdinalBearing bearing, Bearing expectedResult)
        {
            Assert.AreEqual(bearing.AsFullBearing(), expectedResult);
        }
        
        [TestCase(OrdinalBearing.NorthEast)]
        [TestCase(OrdinalBearing.SouthEast)]
        [TestCase(OrdinalBearing.SouthWest)]
        [TestCase(OrdinalBearing.NorthWest)]
        public void GetCoordinateOffset_MatchingResult(OrdinalBearing bearing)
        {
            var expectedOffsetTable = new Dictionary<OrdinalBearing, int2>
            {
                [OrdinalBearing.NorthEast] = Offset2D.UpRight,
                [OrdinalBearing.SouthEast] = Offset2D.DownRight,
                [OrdinalBearing.SouthWest] = Offset2D.DownLeft,
                [OrdinalBearing.NorthWest] = Offset2D.UpLeft
            };

            Assert.AreEqual(bearing.GetCoordinateOffset(), expectedOffsetTable[bearing]);
        }
        
        [TestCase(OrdinalBearing.NorthEast)]
        [TestCase(OrdinalBearing.SouthEast)]
        [TestCase(OrdinalBearing.SouthWest)]
        [TestCase(OrdinalBearing.NorthWest)]
        public void GetDirection_MatchingResult(OrdinalBearing bearing)
        {
            var expectedDirectionTable = new Dictionary<OrdinalBearing, float2>
            {
                [OrdinalBearing.NorthEast] = math.normalize(Offset2D.UpRight),
                [OrdinalBearing.SouthEast] = math.normalize(Offset2D.DownRight),
                [OrdinalBearing.SouthWest] = math.normalize(Offset2D.DownLeft),
                [OrdinalBearing.NorthWest] = math.normalize(Offset2D.UpLeft)
            };
            
            Assert.AreEqual(bearing.GetDirection(), expectedDirectionTable[bearing]);
        }
    }
}