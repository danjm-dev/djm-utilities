using DJM.Utilities.Bearings;
using NUnit.Framework;

namespace DJM.Utilities.Tests.Bearings
{
    [TestFixture]
    internal sealed class BearingFlagsExtensionsTests
    {
        [TestCase(BearingFlags.North, BearingFlags.North, BearingFlags.North)]
        [TestCase(BearingFlags.None, BearingFlags.South, BearingFlags.South)]
        [TestCase(BearingFlags.North, BearingFlags.None, BearingFlags.North)]
        [TestCase(BearingFlags.North, BearingFlags.South, BearingFlags.North | BearingFlags.South)]
        [TestCase(BearingFlags.SouthWest, BearingFlags.AllCardinals, BearingFlags.AllCardinals | BearingFlags.SouthWest)]
        [TestCase(BearingFlags.South, BearingFlags.AllOrdinals, BearingFlags.AllOrdinals | BearingFlags.South)]
        public void WithFlags_OtherBearingFlags_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            BearingFlags other, 
            BearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithFlags(other), expectedResult);
        }
        
        [TestCase(BearingFlags.North, CardinalBearingFlags.North, BearingFlags.North)]
        [TestCase(BearingFlags.None, CardinalBearingFlags.South, BearingFlags.South)]
        [TestCase(BearingFlags.North, CardinalBearingFlags.None, BearingFlags.North)]
        [TestCase(BearingFlags.North, CardinalBearingFlags.South, BearingFlags.North | BearingFlags.South)]
        [TestCase(BearingFlags.SouthWest, CardinalBearingFlags.All, BearingFlags.AllCardinals | BearingFlags.SouthWest)]
        public void WithFlags_OtherCardinalBearingFlags_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            CardinalBearingFlags other, 
            BearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithFlags(other), expectedResult);
        }
        
        [TestCase(BearingFlags.NorthEast, OrdinalBearingFlags.NorthEast, BearingFlags.NorthEast)]
        [TestCase(BearingFlags.None, OrdinalBearingFlags.SouthWest, BearingFlags.SouthWest)]
        [TestCase(BearingFlags.NorthEast, OrdinalBearingFlags.None, BearingFlags.NorthEast)]
        [TestCase(BearingFlags.NorthEast, OrdinalBearingFlags.SouthWest, BearingFlags.NorthEast | BearingFlags.SouthWest)]
        [TestCase(BearingFlags.North, OrdinalBearingFlags.All, BearingFlags.AllOrdinals | BearingFlags.North)]
        public void WithFlags_OtherOrdinalBearingFlags_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            OrdinalBearingFlags other, 
            BearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithFlags(other), expectedResult);
        }
        
        [TestCase(BearingFlags.North, Bearing.North, BearingFlags.North)]
        [TestCase(BearingFlags.None, Bearing.South, BearingFlags.South)]
        [TestCase(BearingFlags.North, Bearing.South, BearingFlags.North | BearingFlags.South)]
        public void WithFlags_OtherBearing_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            Bearing other, 
            BearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithFlags(other), expectedResult);
        }
        
        [TestCase(BearingFlags.North, CardinalBearing.North, BearingFlags.North)]
        [TestCase(BearingFlags.None, CardinalBearing.South, BearingFlags.South)]
        [TestCase(BearingFlags.North, CardinalBearing.South, BearingFlags.North | BearingFlags.South)]
        [TestCase(BearingFlags.NorthWest, CardinalBearing.South, BearingFlags.NorthWest | BearingFlags.South)]
        public void WithFlags_OtherCardinalBearing_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            CardinalBearing other, 
            BearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithFlags(other), expectedResult);
        }
        
        [TestCase(BearingFlags.NorthWest, OrdinalBearing.NorthWest, BearingFlags.NorthWest)]
        [TestCase(BearingFlags.None, OrdinalBearing.SouthWest, BearingFlags.SouthWest)]
        [TestCase(BearingFlags.NorthWest, OrdinalBearing.SouthWest, BearingFlags.NorthWest | BearingFlags.SouthWest)]
        [TestCase(BearingFlags.North, OrdinalBearing.SouthWest, BearingFlags.North | BearingFlags.SouthWest)]
        public void WithFlags_OtherOrdinalBearing_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            OrdinalBearing other, 
            BearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithFlags(other), expectedResult);
        }
        
        [TestCase(BearingFlags.North, BearingFlags.North, BearingFlags.None)]
        [TestCase(BearingFlags.North, BearingFlags.None, BearingFlags.North)]
        [TestCase(BearingFlags.None, BearingFlags.South, BearingFlags.None)]
        [TestCase(BearingFlags.North, BearingFlags.South, BearingFlags.North)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, BearingFlags.North, BearingFlags.NorthEast)]
        [TestCase(BearingFlags.All, BearingFlags.AllOrdinals, BearingFlags.AllCardinals)]
        [TestCase(BearingFlags.All, BearingFlags.AllCardinals, BearingFlags.AllOrdinals)]
        public void WithoutFlags_OtherBearingFlags_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            BearingFlags other, 
            BearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithoutFlags(other), expectedResult);
        }
        
        [TestCase(BearingFlags.North, CardinalBearingFlags.North, BearingFlags.None)]
        [TestCase(BearingFlags.North, CardinalBearingFlags.None, BearingFlags.North)]
        [TestCase(BearingFlags.None, CardinalBearingFlags.South, BearingFlags.None)]
        [TestCase(BearingFlags.North, CardinalBearingFlags.South, BearingFlags.North)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, CardinalBearingFlags.North, BearingFlags.NorthEast)]
        [TestCase(BearingFlags.All, CardinalBearingFlags.All, BearingFlags.AllOrdinals)]
        public void WithoutFlags_OtherCardinalBearingFlags_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            CardinalBearingFlags other, 
            BearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithoutFlags(other), expectedResult);
        }
        
        [TestCase(BearingFlags.NorthEast, OrdinalBearingFlags.NorthEast, BearingFlags.None)]
        [TestCase(BearingFlags.North, OrdinalBearingFlags.None, BearingFlags.North)]
        [TestCase(BearingFlags.None, OrdinalBearingFlags.SouthWest, BearingFlags.None)]
        [TestCase(BearingFlags.North, OrdinalBearingFlags.SouthWest, BearingFlags.North)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, OrdinalBearingFlags.NorthEast, BearingFlags.North)]
        [TestCase(BearingFlags.All, OrdinalBearingFlags.All, BearingFlags.AllCardinals)]
        public void WithoutFlags_OtherOrdinalBearingFlags_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            OrdinalBearingFlags other, 
            BearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithoutFlags(other), expectedResult);
        }
        
        [TestCase(BearingFlags.North, Bearing.North, BearingFlags.None)]
        [TestCase(BearingFlags.None, Bearing.South, BearingFlags.None)]
        [TestCase(BearingFlags.North, Bearing.South, BearingFlags.North)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, Bearing.North, BearingFlags.NorthEast)]
        public void WithoutFlags_OtherBearing_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            Bearing other, 
            BearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithoutFlags(other), expectedResult);
        }
        
        [TestCase(BearingFlags.North, CardinalBearing.North, BearingFlags.None)]
        [TestCase(BearingFlags.None, CardinalBearing.South, BearingFlags.None)]
        [TestCase(BearingFlags.North, CardinalBearing.South, BearingFlags.North)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, CardinalBearing.North, BearingFlags.NorthEast)]
        public void WithoutFlags_OtherCardinalBearing_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            CardinalBearing other, 
            BearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithoutFlags(other), expectedResult);
        }
        
        [TestCase(BearingFlags.NorthEast, OrdinalBearing.NorthEast, BearingFlags.None)]
        [TestCase(BearingFlags.None, OrdinalBearing.SouthWest, BearingFlags.None)]
        [TestCase(BearingFlags.North, OrdinalBearing.SouthWest, BearingFlags.North)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, OrdinalBearing.NorthEast, BearingFlags.North)]
        public void WithoutFlags_OtherOrdinalBearing_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            OrdinalBearing other, 
            BearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithoutFlags(other), expectedResult);
        }
        
        [TestCase(BearingFlags.North, BearingFlags.North, true)]
        [TestCase(BearingFlags.North, BearingFlags.South, false)]
        [TestCase(BearingFlags.North, BearingFlags.None, false)]
        [TestCase(BearingFlags.None, BearingFlags.South, false)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, BearingFlags.North, true)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, BearingFlags.NorthEast | BearingFlags.West, true)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, BearingFlags.SouthEast | BearingFlags.West, false)]
        [TestCase(BearingFlags.All, BearingFlags.AllOrdinals, true)]
        [TestCase(BearingFlags.All, BearingFlags.AllCardinals, true)]
        [TestCase(BearingFlags.AllCardinals, BearingFlags.AllOrdinals, false)]
        [TestCase(BearingFlags.AllOrdinals, BearingFlags.AllCardinals, false)]
        public void HasAny_OtherBearingFlags_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            BearingFlags other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.HasAny(other), expectedResult);
        }

        [TestCase(BearingFlags.North, CardinalBearingFlags.North, true)]
        [TestCase(BearingFlags.North, CardinalBearingFlags.South, false)]
        [TestCase(BearingFlags.North, CardinalBearingFlags.None, false)]
        [TestCase(BearingFlags.None, CardinalBearingFlags.South, false)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, CardinalBearingFlags.North, true)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, CardinalBearingFlags.North | CardinalBearingFlags.West, true)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, CardinalBearingFlags.South | CardinalBearingFlags.West, false)]
        [TestCase(BearingFlags.All, CardinalBearingFlags.All, true)]
        [TestCase(BearingFlags.AllCardinals, CardinalBearingFlags.All, true)]
        [TestCase(BearingFlags.AllOrdinals, CardinalBearingFlags.All, false)]
        public void HasAny_OtherCardinalBearingFlags_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            CardinalBearingFlags other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.HasAny(other), expectedResult);
        }
        
        [TestCase(BearingFlags.NorthEast, OrdinalBearingFlags.NorthEast, true)]
        [TestCase(BearingFlags.North, OrdinalBearingFlags.SouthWest, false)]
        [TestCase(BearingFlags.North, OrdinalBearingFlags.None, false)]
        [TestCase(BearingFlags.None, OrdinalBearingFlags.SouthEast, false)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, OrdinalBearingFlags.NorthEast, true)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, OrdinalBearingFlags.NorthEast | OrdinalBearingFlags.SouthWest, true)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, OrdinalBearingFlags.SouthEast | OrdinalBearingFlags.NorthWest, false)]
        [TestCase(BearingFlags.All, OrdinalBearingFlags.All, true)]
        [TestCase(BearingFlags.AllOrdinals, OrdinalBearingFlags.All, true)]
        [TestCase(BearingFlags.AllCardinals, OrdinalBearingFlags.All, false)]
        public void HasAny_OtherOrdinalBearingFlags_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            OrdinalBearingFlags other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.HasAny(other), expectedResult);
        }
        
        [TestCase(BearingFlags.North, BearingFlags.North, true)]
        [TestCase(BearingFlags.North, BearingFlags.South, false)]
        [TestCase(BearingFlags.North, BearingFlags.None, true)]
        [TestCase(BearingFlags.None, BearingFlags.South, false)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, BearingFlags.North, true)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, BearingFlags.NorthEast | BearingFlags.North | BearingFlags.West, false)]
        [TestCase(BearingFlags.All, BearingFlags.AllOrdinals, true)]
        [TestCase(BearingFlags.All, BearingFlags.AllCardinals, true)]
        [TestCase(BearingFlags.AllCardinals, BearingFlags.AllOrdinals, false)]
        [TestCase(BearingFlags.AllOrdinals, BearingFlags.AllCardinals, false)]
        public void HasAll_OtherBearingFlags_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            BearingFlags other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.HasAll(other), expectedResult);
        }

        [TestCase(BearingFlags.North, CardinalBearingFlags.North, true)]
        [TestCase(BearingFlags.North, CardinalBearingFlags.South, false)]
        [TestCase(BearingFlags.North, CardinalBearingFlags.None, true)]
        [TestCase(BearingFlags.None, CardinalBearingFlags.South, false)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, CardinalBearingFlags.North, true)]
        [TestCase(BearingFlags.North | BearingFlags.East, CardinalBearingFlags.East | CardinalBearingFlags.North | CardinalBearingFlags.West, false)]
        [TestCase(BearingFlags.All, CardinalBearingFlags.All, true)]
        [TestCase(BearingFlags.AllCardinals, CardinalBearingFlags.All, true)]
        [TestCase(BearingFlags.AllOrdinals, CardinalBearingFlags.All, false)]
        public void HasAll_OtherCardinalBearingFlags_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            CardinalBearingFlags other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.HasAll(other), expectedResult);
        }
        
        [TestCase(BearingFlags.NorthEast, OrdinalBearingFlags.NorthEast, true)]
        [TestCase(BearingFlags.North, OrdinalBearingFlags.SouthWest, false)]
        [TestCase(BearingFlags.North, OrdinalBearingFlags.None, true)]
        [TestCase(BearingFlags.None, OrdinalBearingFlags.SouthWest, false)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, OrdinalBearingFlags.NorthEast, true)]
        [TestCase(BearingFlags.NorthWest | BearingFlags.SouthWest, OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.SouthWest | OrdinalBearingFlags.SouthEast, false)]
        [TestCase(BearingFlags.All, OrdinalBearingFlags.All, true)]
        [TestCase(BearingFlags.AllCardinals, OrdinalBearingFlags.All, false)]
        [TestCase(BearingFlags.AllOrdinals, OrdinalBearingFlags.All, true)]
        public void HasAll_OtherOrdinalBearingFlags_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            OrdinalBearingFlags other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.HasAll(other), expectedResult);
        }
        
        [TestCase(BearingFlags.North, Bearing.North, true)]
        [TestCase(BearingFlags.North, Bearing.South, false)]
        [TestCase(BearingFlags.None, Bearing.South, false)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, Bearing.North, true)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, Bearing.West, false)]
        [TestCase(BearingFlags.All, Bearing.NorthEast, true)]
        public void Has_OtherBearingFlags_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            Bearing other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.Has(other), expectedResult);
        }

        [TestCase(BearingFlags.North, CardinalBearing.North, true)]
        [TestCase(BearingFlags.North, CardinalBearing.South, false)]
        [TestCase(BearingFlags.None, CardinalBearing.South, false)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, CardinalBearing.North, true)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, CardinalBearing.West, false)]
        [TestCase(BearingFlags.All, CardinalBearing.North, true)]
        public void Has_OtherCardinalBearingFlags_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            CardinalBearing other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.Has(other), expectedResult);
        }
        
        [TestCase(BearingFlags.NorthEast, OrdinalBearing.NorthEast, true)]
        [TestCase(BearingFlags.North, OrdinalBearing.NorthEast, false)]
        [TestCase(BearingFlags.None, OrdinalBearing.SouthWest, false)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, OrdinalBearing.NorthEast, true)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast, OrdinalBearing.SouthEast, false)]
        [TestCase(BearingFlags.All, OrdinalBearing.SouthWest, true)]
        public void Has_OtherOrdinalBearingFlags_MatchingResult
        (
            BearingFlags initialBearingFlags, 
            OrdinalBearing other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.Has(other), expectedResult);
        }
        
        [TestCase(BearingFlags.North, 0, BearingFlags.North)]
        [TestCase(BearingFlags.SouthEast | BearingFlags.NorthEast, 8, BearingFlags.SouthEast | BearingFlags.NorthEast)]
        [TestCase(BearingFlags.West, -8, BearingFlags.West)]
        [TestCase(BearingFlags.North | BearingFlags.East, 1, BearingFlags.NorthEast | BearingFlags.SouthEast)]
        [TestCase(BearingFlags.North | BearingFlags.East, -1, BearingFlags.NorthWest | BearingFlags.NorthEast)]
        [TestCase(BearingFlags.North | BearingFlags.East, 7, BearingFlags.NorthWest | BearingFlags.NorthEast)]
        [TestCase(BearingFlags.North | BearingFlags.East, -7, BearingFlags.NorthEast | BearingFlags.SouthEast)]
        [TestCase(BearingFlags.North | BearingFlags.East, 35, BearingFlags.SouthEast | BearingFlags.SouthWest)]
        [TestCase(BearingFlags.North | BearingFlags.East, -35, BearingFlags.SouthWest | BearingFlags.NorthWest)]
        public void WithOffset_MatchingResult(BearingFlags initialBearingFlags, int offsetAmount, BearingFlags expectedResult)
        {
            Assert.AreEqual(initialBearingFlags.WithOffset(offsetAmount), expectedResult);
        }
        
        [TestCase(BearingFlags.NorthEast, BearingFlags.SouthWest)]
        [TestCase(BearingFlags.North | BearingFlags.East, BearingFlags.South | BearingFlags.West)]
        public void Flip_MatchingResult(BearingFlags initialBearingFlags, BearingFlags expectedResult)
        {
            Assert.AreEqual(initialBearingFlags.Flip(), expectedResult);
        }
        
        [TestCase(BearingFlags.NorthEast, BearingFlags.North)]
        [TestCase(BearingFlags.North | BearingFlags.East, BearingFlags.NorthWest | BearingFlags.NorthEast)]
        public void TurnLeft_MatchingResult(BearingFlags initialBearingFlags, BearingFlags expectedResult)
        {
            Assert.AreEqual(initialBearingFlags.TurnLeft(), expectedResult);
        }
        
        [TestCase(BearingFlags.NorthEast, BearingFlags.East)]
        [TestCase(BearingFlags.North | BearingFlags.East, BearingFlags.NorthEast | BearingFlags.SouthEast)]
        public void TurnRight_MatchingResult(BearingFlags initialBearingFlags, BearingFlags expectedResult)
        {
            Assert.AreEqual(initialBearingFlags.TurnRight(), expectedResult);
        }
        
        [TestCase(BearingFlags.North, CardinalBearingFlags.North)]
        [TestCase(BearingFlags.None, CardinalBearingFlags.None)]
        [TestCase(BearingFlags.SouthWest, CardinalBearingFlags.None)]
        [TestCase(BearingFlags.North | BearingFlags.NorthEast | BearingFlags.East, CardinalBearingFlags.North | CardinalBearingFlags.East)]
        public void AsCardinalFlags_MatchingResult(BearingFlags bearingFlags, CardinalBearingFlags expectedResult)
        {
            Assert.AreEqual(bearingFlags.AsCardinalFlags(), expectedResult);
        }
        
        [TestCase(BearingFlags.NorthEast, OrdinalBearingFlags.NorthEast)]
        [TestCase(BearingFlags.None, OrdinalBearingFlags.None)]
        [TestCase(BearingFlags.South, OrdinalBearingFlags.None)]
        [TestCase(BearingFlags.NorthEast | BearingFlags.East | BearingFlags.SouthEast, OrdinalBearingFlags.NorthEast | OrdinalBearingFlags.SouthEast)]
        public void AsOrdinalFlags_MatchingResult(BearingFlags bearingFlags, OrdinalBearingFlags expectedResult)
        {
            Assert.AreEqual(bearingFlags.AsOrdinalFlags(), expectedResult);
        }
        
        [TestCase(BearingFlags.All, 8)]
        [TestCase(BearingFlags.None, 0)]
        [TestCase(BearingFlags.South, 1)]
        [TestCase(BearingFlags.NorthEast | BearingFlags.East, 2)]
        [TestCase(BearingFlags.NorthEast | BearingFlags.East | BearingFlags.SouthEast, 3)]
        [TestCase(BearingFlags.AllOrdinals, 4)]
        [TestCase(BearingFlags.AllCardinals, 4)]
        public void GetCount_MatchingResult(BearingFlags bearingFlags, int expectedResult)
        {
            Assert.AreEqual(bearingFlags.GetCount(), expectedResult);
        }
    }
}