using DJM.Utilities.Bearings;
using NUnit.Framework;

namespace DJM.Utilities.Tests.Bearings
{
    [TestFixture]
    internal sealed class CardinalBearingFlagsExtensionsTests
    {
        [TestCase(CardinalBearingFlags.North, CardinalBearingFlags.North, CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.None, CardinalBearingFlags.South, CardinalBearingFlags.South)]
        [TestCase(CardinalBearingFlags.North, CardinalBearingFlags.None, CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.North, CardinalBearingFlags.South, CardinalBearingFlags.North | CardinalBearingFlags.South)]
        [TestCase(CardinalBearingFlags.South, CardinalBearingFlags.All, CardinalBearingFlags.All)]
        public void WithFlags_OtherCardinalBearingFlags_MatchingResult
        (
            CardinalBearingFlags initialBearingFlags, 
            CardinalBearingFlags other, 
            CardinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithFlags(other), expectedResult);
        }
        
        [TestCase(CardinalBearingFlags.North, BearingFlags.North, CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.None, BearingFlags.South, CardinalBearingFlags.South)]
        [TestCase(CardinalBearingFlags.North, BearingFlags.None, CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.North, BearingFlags.NorthEast, CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.North, BearingFlags.South, CardinalBearingFlags.North | CardinalBearingFlags.South)]
        [TestCase(CardinalBearingFlags.South, BearingFlags.All, CardinalBearingFlags.All)]
        [TestCase(CardinalBearingFlags.South, BearingFlags.AllOrdinals, CardinalBearingFlags.South)]
        [TestCase(CardinalBearingFlags.South, BearingFlags.AllCardinals, CardinalBearingFlags.All)]
        public void WithFlags_OtherBearingFlags_MatchingResult
        (
            CardinalBearingFlags initialBearingFlags, 
            BearingFlags other, 
            CardinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithFlags(other), expectedResult);
        }
        
        [TestCase(CardinalBearingFlags.North, CardinalBearing.North, CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.None, CardinalBearing.South, CardinalBearingFlags.South)]
        [TestCase(CardinalBearingFlags.North, CardinalBearing.South, CardinalBearingFlags.North | CardinalBearingFlags.South)]
        [TestCase(CardinalBearingFlags.West, CardinalBearing.South, CardinalBearingFlags.West | CardinalBearingFlags.South)]
        public void WithFlags_OtherCardinalBearing_MatchingResult
        (
            CardinalBearingFlags initialBearingFlags, 
            CardinalBearing other, 
            CardinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithFlags(other), expectedResult);
        }
        
        [TestCase(CardinalBearingFlags.North, Bearing.North, CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.None, Bearing.South, CardinalBearingFlags.South)]
        [TestCase(CardinalBearingFlags.North, Bearing.South, CardinalBearingFlags.North | CardinalBearingFlags.South)]
        [TestCase(CardinalBearingFlags.South, Bearing.SouthEast, CardinalBearingFlags.South)]
        public void WithFlags_OtherBearing_MatchingResult
        (
            CardinalBearingFlags initialBearingFlags, 
            Bearing other, 
            CardinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithFlags(other), expectedResult);
        }

        [TestCase(CardinalBearingFlags.North, CardinalBearingFlags.North, CardinalBearingFlags.None)]
        [TestCase(CardinalBearingFlags.North, CardinalBearingFlags.None, CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.None, CardinalBearingFlags.South, CardinalBearingFlags.None)]
        [TestCase(CardinalBearingFlags.North, CardinalBearingFlags.South, CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, CardinalBearingFlags.North, CardinalBearingFlags.East)]
        [TestCase(CardinalBearingFlags.All, CardinalBearingFlags.All, CardinalBearingFlags.None)]
        public void WithoutFlags_OtherCardinalBearingFlags_MatchingResult
        (
            CardinalBearingFlags initialBearingFlags, 
            CardinalBearingFlags other, 
            CardinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithoutFlags(other), expectedResult);
        }
        
        [TestCase(CardinalBearingFlags.North, BearingFlags.North, CardinalBearingFlags.None)]
        [TestCase(CardinalBearingFlags.North, BearingFlags.None, CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.None, BearingFlags.South, CardinalBearingFlags.None)]
        [TestCase(CardinalBearingFlags.North, BearingFlags.NorthEast, CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.North, BearingFlags.South, CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, BearingFlags.North, CardinalBearingFlags.East)]
        [TestCase(CardinalBearingFlags.All, BearingFlags.AllOrdinals, CardinalBearingFlags.All)]
        [TestCase(CardinalBearingFlags.All, BearingFlags.AllCardinals, CardinalBearingFlags.None)]
        public void WithoutFlags_OtherBearingFlags_MatchingResult
        (
            CardinalBearingFlags initialBearingFlags, 
            BearingFlags other, 
            CardinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithoutFlags(other), expectedResult);
        }
        
        [TestCase(CardinalBearingFlags.North, CardinalBearing.North, CardinalBearingFlags.None)]
        [TestCase(CardinalBearingFlags.None, CardinalBearing.South, CardinalBearingFlags.None)]
        [TestCase(CardinalBearingFlags.North, CardinalBearing.South, CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, CardinalBearing.North, CardinalBearingFlags.East)]
        public void WithoutFlags_OtherCardinalBearing_MatchingResult
        (
            CardinalBearingFlags initialBearingFlags, 
            CardinalBearing other, 
            CardinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithoutFlags(other), expectedResult);
        }
        
        [TestCase(CardinalBearingFlags.North, Bearing.North, CardinalBearingFlags.None)]
        [TestCase(CardinalBearingFlags.None, Bearing.South, CardinalBearingFlags.None)]
        [TestCase(CardinalBearingFlags.North, Bearing.South, CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, Bearing.North, CardinalBearingFlags.East)]
        public void WithoutFlags_OtherBearing_MatchingResult
        (
            CardinalBearingFlags initialBearingFlags, 
            Bearing other, 
            CardinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithoutFlags(other), expectedResult);
        }
        
        [TestCase(CardinalBearingFlags.North, CardinalBearingFlags.North, true)]
        [TestCase(CardinalBearingFlags.North, CardinalBearingFlags.South, false)]
        [TestCase(CardinalBearingFlags.North, CardinalBearingFlags.None, false)]
        [TestCase(CardinalBearingFlags.None, CardinalBearingFlags.South, false)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, CardinalBearingFlags.North, true)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, CardinalBearingFlags.North | CardinalBearingFlags.West, true)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, CardinalBearingFlags.South | CardinalBearingFlags.West, false)]
        [TestCase(CardinalBearingFlags.All, CardinalBearingFlags.All, true)]
        public void HasAny_OtherCardinalBearingFlags_MatchingResult
        (
            CardinalBearingFlags initialBearingFlags, 
            CardinalBearingFlags other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.HasAny(other), expectedResult);
        }
        
        [TestCase(CardinalBearingFlags.North, BearingFlags.North, true)]
        [TestCase(CardinalBearingFlags.North, BearingFlags.South, false)]
        [TestCase(CardinalBearingFlags.North, BearingFlags.None, false)]
        [TestCase(CardinalBearingFlags.None, BearingFlags.South, false)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, BearingFlags.North, true)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, BearingFlags.NorthEast | BearingFlags.East, true)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, BearingFlags.SouthEast | BearingFlags.West, false)]
        [TestCase(CardinalBearingFlags.All, BearingFlags.AllOrdinals, false)]
        [TestCase(CardinalBearingFlags.All, BearingFlags.AllCardinals, true)]
        public void HasAny_OtherBearingFlags_MatchingResult
        (
            CardinalBearingFlags initialBearingFlags, 
            BearingFlags other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.HasAny(other), expectedResult);
        }


        [TestCase(CardinalBearingFlags.North, CardinalBearingFlags.North, true)]
        [TestCase(CardinalBearingFlags.North, CardinalBearingFlags.South, false)]
        [TestCase(CardinalBearingFlags.North, CardinalBearingFlags.None, true)]
        [TestCase(CardinalBearingFlags.None, CardinalBearingFlags.South, false)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, CardinalBearingFlags.North, true)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, CardinalBearingFlags.East | CardinalBearingFlags.North | CardinalBearingFlags.West, false)]
        [TestCase(CardinalBearingFlags.All, CardinalBearingFlags.All, true)]
        public void HasAll_OtherCardinalBearingFlags_MatchingResult
        (
            CardinalBearingFlags initialBearingFlags, 
            CardinalBearingFlags other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.HasAll(other), expectedResult);
        }

        
        [TestCase(CardinalBearingFlags.North, BearingFlags.North, true)]
        [TestCase(CardinalBearingFlags.North, BearingFlags.South, false)]
        [TestCase(CardinalBearingFlags.North, BearingFlags.None, true)]
        [TestCase(CardinalBearingFlags.None, BearingFlags.South, false)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, BearingFlags.North, true)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, BearingFlags.NorthEast | BearingFlags.North | BearingFlags.West, false)]
        [TestCase(CardinalBearingFlags.All, BearingFlags.AllOrdinals, false)]
        [TestCase(CardinalBearingFlags.All, BearingFlags.AllCardinals, true)]
        public void HasAll_OtherBearingFlags_MatchingResult
        (
            CardinalBearingFlags initialBearingFlags, 
            BearingFlags other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.HasAll(other), expectedResult);
        }


        [TestCase(CardinalBearingFlags.North, CardinalBearing.North, true)]
        [TestCase(CardinalBearingFlags.North, CardinalBearing.South, false)]
        [TestCase(CardinalBearingFlags.None, CardinalBearing.South, false)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, CardinalBearing.North, true)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, CardinalBearing.West, false)]
        [TestCase(CardinalBearingFlags.All, CardinalBearing.North, true)]
        public void Has_OtherCardinalBearingFlags_MatchingResult
        (
            CardinalBearingFlags initialBearingFlags, 
            CardinalBearing other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.Has(other), expectedResult);
        }

        
        [TestCase(CardinalBearingFlags.North, Bearing.North, true)]
        [TestCase(CardinalBearingFlags.North, Bearing.South, false)]
        [TestCase(CardinalBearingFlags.None, Bearing.South, false)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, Bearing.North, true)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, Bearing.West, false)]
        [TestCase(CardinalBearingFlags.All, Bearing.NorthEast, false)]
        [TestCase(CardinalBearingFlags.All, Bearing.South, true)]
        public void Has_OtherBearingFlags_MatchingResult
        (
            CardinalBearingFlags initialBearingFlags, 
            Bearing other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.Has(other), expectedResult);
        }
        
        [TestCase(CardinalBearingFlags.North, 0, CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, 4, CardinalBearingFlags.North | CardinalBearingFlags.East)]
        [TestCase(CardinalBearingFlags.West, -4, CardinalBearingFlags.West)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, 1, CardinalBearingFlags.East | CardinalBearingFlags.South)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, -1, CardinalBearingFlags.West | CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, 3, CardinalBearingFlags.West | CardinalBearingFlags.North)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, -3, CardinalBearingFlags.East | CardinalBearingFlags.South)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, 34, CardinalBearingFlags.South | CardinalBearingFlags.West)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, -34, CardinalBearingFlags.South | CardinalBearingFlags.West)]
        public void WithOffset_MatchingResult
        (
            CardinalBearingFlags initialBearingFlags, 
            int offsetAmount, 
            CardinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithOffset(offsetAmount), expectedResult);
        }
        
        [TestCase(CardinalBearingFlags.East, CardinalBearingFlags.West)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, CardinalBearingFlags.South | CardinalBearingFlags.West)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.South, CardinalBearingFlags.North | CardinalBearingFlags.South)]
        public void Flip_MatchingResult(CardinalBearingFlags initialBearingFlags, CardinalBearingFlags expectedResult)
        {
            Assert.AreEqual(initialBearingFlags.Flip(), expectedResult);
        }
        
        [TestCase(CardinalBearingFlags.West, CardinalBearingFlags.South)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, CardinalBearingFlags.West | CardinalBearingFlags.North)]
        public void TurnLeft_MatchingResult(CardinalBearingFlags initialBearingFlags, CardinalBearingFlags expectedResult)
        {
            Assert.AreEqual(initialBearingFlags.TurnLeft(), expectedResult);
        }
        
        [TestCase(CardinalBearingFlags.North, CardinalBearingFlags.East)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, CardinalBearingFlags.East | CardinalBearingFlags.South)]
        public void TurnRight_MatchingResult(CardinalBearingFlags initialBearingFlags, CardinalBearingFlags expectedResult)
        {
            Assert.AreEqual(initialBearingFlags.TurnRight(), expectedResult);
        }
        
        [TestCase(CardinalBearingFlags.North, BearingFlags.North)]
        [TestCase(CardinalBearingFlags.None, BearingFlags.None)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, BearingFlags.North | BearingFlags.East)]
        [TestCase(CardinalBearingFlags.All, BearingFlags.AllCardinals)]
        public void AsFullBearingFlags_MatchingResult(CardinalBearingFlags bearingFlags, BearingFlags expectedResult)
        {
            Assert.AreEqual(bearingFlags.AsFullBearingFlags(), expectedResult);
        }
        
        [TestCase(CardinalBearingFlags.All, 4)]
        [TestCase(CardinalBearingFlags.None, 0)]
        [TestCase(CardinalBearingFlags.South, 1)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East, 2)]
        [TestCase(CardinalBearingFlags.North | CardinalBearingFlags.East | CardinalBearingFlags.South, 3)]
        [TestCase(CardinalBearingFlags.All, 4)]
        public void GetCount_MatchingResult(CardinalBearingFlags bearingFlags, int expectedResult)
        {
            Assert.AreEqual(bearingFlags.GetCount(), expectedResult);
        }
    }
}