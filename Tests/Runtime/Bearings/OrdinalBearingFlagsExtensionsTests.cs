using DJM.Utilities.Math;
using DJM.Utilities.Math.Geometry;
using NUnit.Framework;
using Bearing = DJM.Utilities.Math.Geometry.Bearing;
using BearingFlags = DJM.Utilities.Math.Geometry.BearingFlags;

namespace DJM.Utilities.Tests.Bearings
{
    [TestFixture]
    internal sealed class OrdinalBearingFlagsExtensionsTests
    {
        [TestCase(OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.NorthEast)]
        [TestCase(OrdinalBearingFlags.None, OrdinalBearingFlags.SouthWest, OrdinalBearingFlags.SouthWest)]
        [TestCase(OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.None, OrdinalBearingFlags.NorthEast)]
        [TestCase(OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.SouthWest, OrdinalBearingFlags.NorthEast | OrdinalBearingFlags.SouthWest)]
        [TestCase(OrdinalBearingFlags.SouthEast, OrdinalBearingFlags.All, OrdinalBearingFlags.All)]
        public void WithFlags_OtherOrdinalBearingFlags_MatchingResult
        (
            OrdinalBearingFlags initialBearingFlags, 
            OrdinalBearingFlags other, 
            OrdinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithFlags(other), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthEast, BearingFlags.NorthEast, OrdinalBearingFlags.NorthEast)]
        [TestCase(OrdinalBearingFlags.None, BearingFlags.SouthWest, OrdinalBearingFlags.SouthWest)]
        [TestCase(OrdinalBearingFlags.NorthEast, BearingFlags.None, OrdinalBearingFlags.NorthEast)]
        [TestCase(OrdinalBearingFlags.NorthEast, BearingFlags.North, OrdinalBearingFlags.NorthEast)]
        [TestCase(OrdinalBearingFlags.NorthEast, BearingFlags.SouthWest, OrdinalBearingFlags.NorthEast | OrdinalBearingFlags.SouthWest)]
        [TestCase(OrdinalBearingFlags.SouthWest, BearingFlags.AllCardinals, OrdinalBearingFlags.SouthWest)]
        [TestCase(OrdinalBearingFlags.SouthWest, BearingFlags.AllOrdinals, OrdinalBearingFlags.All)]
        public void WithFlags_OtherBearingFlags_MatchingResult
        (
            OrdinalBearingFlags initialBearingFlags, 
            BearingFlags other, 
            OrdinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithFlags(other), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthWest, OrdinalBearing.NorthWest, OrdinalBearingFlags.NorthWest)]
        [TestCase(OrdinalBearingFlags.None, OrdinalBearing.SouthWest, OrdinalBearingFlags.SouthWest)]
        [TestCase(OrdinalBearingFlags.NorthWest, OrdinalBearing.SouthWest, OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.SouthWest)]
        public void WithFlags_OtherOrdinalBearing_MatchingResult
        (
            OrdinalBearingFlags initialBearingFlags, 
            OrdinalBearing other, 
            OrdinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithFlags(other), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthEast, Bearing.NorthEast, OrdinalBearingFlags.NorthEast)]
        [TestCase(OrdinalBearingFlags.None, Bearing.SouthWest, OrdinalBearingFlags.SouthWest)]
        [TestCase(OrdinalBearingFlags.NorthWest, Bearing.SouthEast, OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.SouthEast)]
        [TestCase(OrdinalBearingFlags.SouthEast, Bearing.South, OrdinalBearingFlags.SouthEast)]
        public void WithFlags_OtherBearing_MatchingResult
        (
            OrdinalBearingFlags initialBearingFlags, 
            Bearing other, 
            OrdinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithFlags(other), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.None)]
        [TestCase(OrdinalBearingFlags.NorthWest, OrdinalBearingFlags.None, OrdinalBearingFlags.NorthWest)]
        [TestCase(OrdinalBearingFlags.None, OrdinalBearingFlags.SouthWest, OrdinalBearingFlags.None)]
        [TestCase(OrdinalBearingFlags.NorthWest, OrdinalBearingFlags.SouthWest, OrdinalBearingFlags.NorthWest)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.NorthWest)]
        [TestCase(OrdinalBearingFlags.All, OrdinalBearingFlags.All, OrdinalBearingFlags.None)]
        public void WithoutFlags_OtherOrdinalBearingFlags_MatchingResult
        (
            OrdinalBearingFlags initialBearingFlags, 
            OrdinalBearingFlags other, 
            OrdinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithoutFlags(other), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthWest, BearingFlags.NorthWest, OrdinalBearingFlags.None)]
        [TestCase(OrdinalBearingFlags.NorthWest, BearingFlags.None, OrdinalBearingFlags.NorthWest)]
        [TestCase(OrdinalBearingFlags.None, BearingFlags.South, OrdinalBearingFlags.None)]
        [TestCase(OrdinalBearingFlags.NorthWest, BearingFlags.North, OrdinalBearingFlags.NorthWest)]
        [TestCase(OrdinalBearingFlags.NorthWest, BearingFlags.South, OrdinalBearingFlags.NorthWest)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, BearingFlags.NorthEast, OrdinalBearingFlags.NorthWest)]
        [TestCase(OrdinalBearingFlags.All, BearingFlags.AllOrdinals, OrdinalBearingFlags.None)]
        [TestCase(OrdinalBearingFlags.All, BearingFlags.AllCardinals, OrdinalBearingFlags.All)]
        public void WithoutFlags_OtherBearingFlags_MatchingResult
        (
            OrdinalBearingFlags initialBearingFlags, 
            BearingFlags other, 
            OrdinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithoutFlags(other), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthEast, OrdinalBearing.NorthEast, OrdinalBearingFlags.None)]
        [TestCase(OrdinalBearingFlags.None, OrdinalBearing.SouthWest, OrdinalBearingFlags.None)]
        [TestCase(OrdinalBearingFlags.NorthWest, OrdinalBearing.SouthWest, OrdinalBearingFlags.NorthWest)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, OrdinalBearing.NorthEast, OrdinalBearingFlags.NorthWest)]
        public void WithoutFlags_OtherOrdinalBearing_MatchingResult
        (
            OrdinalBearingFlags initialBearingFlags, 
            OrdinalBearing other, 
            OrdinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithoutFlags(other), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthWest, Bearing.NorthWest, OrdinalBearingFlags.None)]
        [TestCase(OrdinalBearingFlags.None, Bearing.South, OrdinalBearingFlags.None)]
        [TestCase(OrdinalBearingFlags.NorthWest, Bearing.South, OrdinalBearingFlags.NorthWest)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, Bearing.NorthWest, OrdinalBearingFlags.NorthEast)]
        public void WithoutFlags_OtherBearing_MatchingResult
        (
            OrdinalBearingFlags initialBearingFlags, 
            Bearing other, 
            OrdinalBearingFlags expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.WithoutFlags(other), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.NorthEast, true)]
        [TestCase(OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.SouthWest, false)]
        [TestCase(OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.None, false)]
        [TestCase(OrdinalBearingFlags.None, OrdinalBearingFlags.SouthEast, false)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.NorthEast, true)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.NorthEast | OrdinalBearingFlags.SouthWest, true)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.SouthEast | OrdinalBearingFlags.SouthWest, false)]
        [TestCase(OrdinalBearingFlags.All, OrdinalBearingFlags.All, true)]
        public void HasAny_OtherOrdinalBearingFlags_MatchingResult
        (
            OrdinalBearingFlags initialBearingFlags, 
            OrdinalBearingFlags other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.HasAny(other), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthWest, BearingFlags.NorthWest, true)]
        [TestCase(OrdinalBearingFlags.NorthWest, BearingFlags.South, false)]
        [TestCase(OrdinalBearingFlags.NorthWest, BearingFlags.None, false)]
        [TestCase(OrdinalBearingFlags.None, BearingFlags.South, false)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, BearingFlags.NorthWest, true)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, BearingFlags.NorthEast | BearingFlags.West, true)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, BearingFlags.SouthEast | BearingFlags.West, false)]
        [TestCase(OrdinalBearingFlags.All, BearingFlags.AllOrdinals, true)]
        [TestCase(OrdinalBearingFlags.All, BearingFlags.AllCardinals, false)]
        public void HasAny_OtherBearingFlags_MatchingResult
        (
            OrdinalBearingFlags initialBearingFlags, 
            BearingFlags other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.HasAny(other), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.NorthEast, true)]
        [TestCase(OrdinalBearingFlags.NorthWest, OrdinalBearingFlags.SouthWest, false)]
        [TestCase(OrdinalBearingFlags.NorthWest, OrdinalBearingFlags.None, true)]
        [TestCase(OrdinalBearingFlags.None, OrdinalBearingFlags.SouthWest, false)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.NorthEast, true)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.SouthWest, OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.SouthWest | OrdinalBearingFlags.SouthEast, false)]
        [TestCase(OrdinalBearingFlags.All, OrdinalBearingFlags.All, true)]
        public void HasAll_OtherOrdinalBearingFlags_MatchingResult
        (
            OrdinalBearingFlags initialBearingFlags, 
            OrdinalBearingFlags other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.HasAll(other), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthWest, BearingFlags.NorthWest, true)]
        [TestCase(OrdinalBearingFlags.NorthWest, BearingFlags.SouthWest, false)]
        [TestCase(OrdinalBearingFlags.NorthWest, BearingFlags.None, true)]
        [TestCase(OrdinalBearingFlags.None, BearingFlags.South, false)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, BearingFlags.NorthWest, true)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, BearingFlags.NorthEast | BearingFlags.North | BearingFlags.West, false)]
        [TestCase(OrdinalBearingFlags.All, BearingFlags.AllOrdinals, true)]
        [TestCase(OrdinalBearingFlags.All, BearingFlags.AllCardinals, false)]
        public void HasAll_OtherBearingFlags_MatchingResult
        (
            OrdinalBearingFlags initialBearingFlags, 
            BearingFlags other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.HasAll(other), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthEast, OrdinalBearing.NorthEast, true)]
        [TestCase(OrdinalBearingFlags.NorthWest, OrdinalBearing.NorthEast, false)]
        [TestCase(OrdinalBearingFlags.None, OrdinalBearing.SouthWest, false)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, OrdinalBearing.NorthEast, true)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, OrdinalBearing.SouthEast, false)]
        [TestCase(OrdinalBearingFlags.All, OrdinalBearing.SouthWest, true)]
        public void Has_OtherOrdinalBearingFlags_MatchingResult
        (
            OrdinalBearingFlags initialBearingFlags, 
            OrdinalBearing other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.Has(other), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthWest, Bearing.NorthWest, true)]
        [TestCase(OrdinalBearingFlags.NorthWest, Bearing.South, false)]
        [TestCase(OrdinalBearingFlags.None, Bearing.South, false)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, Bearing.NorthWest, true)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, Bearing.West, false)]
        [TestCase(OrdinalBearingFlags.All, Bearing.NorthEast, true)]
        [TestCase(OrdinalBearingFlags.All, Bearing.North, false)]
        public void Has_OtherBearingFlags_MatchingResult
        (
            OrdinalBearingFlags initialBearingFlags, 
            Bearing other, 
            bool expectedResult
        )
        {
            Assert.AreEqual(initialBearingFlags.Has(other), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthEast, 0, OrdinalBearingFlags.NorthEast)]
        [TestCase(OrdinalBearingFlags.SouthEast | OrdinalBearingFlags.NorthEast, 4, OrdinalBearingFlags.SouthEast | OrdinalBearingFlags.NorthEast)]
        [TestCase(OrdinalBearingFlags.SouthWest, -4, OrdinalBearingFlags.SouthWest)]
        [TestCase(OrdinalBearingFlags.NorthEast | OrdinalBearingFlags.SouthEast, 1, OrdinalBearingFlags.SouthEast | OrdinalBearingFlags.SouthWest)]
        [TestCase(OrdinalBearingFlags.NorthEast | OrdinalBearingFlags.SouthEast, -1, OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast)]
        [TestCase(OrdinalBearingFlags.NorthEast | OrdinalBearingFlags.SouthEast, 3, OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast)]
        [TestCase(OrdinalBearingFlags.NorthEast | OrdinalBearingFlags.SouthEast, -3, OrdinalBearingFlags.SouthWest | OrdinalBearingFlags.SouthEast)]
        [TestCase(OrdinalBearingFlags.NorthEast | OrdinalBearingFlags.SouthEast, 34, OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.SouthWest)]
        [TestCase(OrdinalBearingFlags.NorthEast | OrdinalBearingFlags.SouthEast, -34, OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.SouthWest)]
        public void WithOffset_MatchingResult(OrdinalBearingFlags initialBearingFlags, int offsetAmount, OrdinalBearingFlags expectedResult)
        {
            Assert.AreEqual(initialBearingFlags.WithOffset(offsetAmount), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthEast, OrdinalBearingFlags.SouthWest)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.SouthWest, OrdinalBearingFlags.SouthEast | OrdinalBearingFlags.NorthEast)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.SouthEast, OrdinalBearingFlags.SouthEast | OrdinalBearingFlags.NorthWest)]
        public void Flip_MatchingResult(OrdinalBearingFlags initialBearingFlags, OrdinalBearingFlags expectedResult)
        {
            Assert.AreEqual(initialBearingFlags.Flip(), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthWest, OrdinalBearingFlags.SouthWest)]
        [TestCase(OrdinalBearingFlags.NorthEast | OrdinalBearingFlags.SouthEast, OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast)]
        public void TurnLeft_MatchingResult(OrdinalBearingFlags initialBearingFlags, OrdinalBearingFlags expectedResult)
        {
            Assert.AreEqual(initialBearingFlags.TurnLeft(), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthWest, OrdinalBearingFlags.NorthEast)]
        [TestCase(OrdinalBearingFlags.NorthEast | OrdinalBearingFlags.SouthEast, OrdinalBearingFlags.SouthWest | OrdinalBearingFlags.SouthEast)]
        public void TurnRight_MatchingResult(OrdinalBearingFlags initialBearingFlags, OrdinalBearingFlags expectedResult)
        {
            Assert.AreEqual(initialBearingFlags.TurnRight(), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.NorthWest, BearingFlags.NorthWest)]
        [TestCase(OrdinalBearingFlags.None, BearingFlags.None)]
        [TestCase(OrdinalBearingFlags.NorthWest | OrdinalBearingFlags.NorthEast, BearingFlags.NorthWest | BearingFlags.NorthEast)]
        [TestCase(OrdinalBearingFlags.All, BearingFlags.AllOrdinals)]
        public void AsFullBearingFlags_MatchingResult(OrdinalBearingFlags bearingFlags, BearingFlags expectedResult)
        {
            Assert.AreEqual(bearingFlags.AsFullBearingFlags(), expectedResult);
        }
        
        [TestCase(OrdinalBearingFlags.All, 4)]
        [TestCase(OrdinalBearingFlags.None, 0)]
        [TestCase(OrdinalBearingFlags.SouthWest, 1)]
        [TestCase(OrdinalBearingFlags.NorthEast | OrdinalBearingFlags.SouthEast, 2)]
        [TestCase(OrdinalBearingFlags.NorthEast | OrdinalBearingFlags.SouthEast | OrdinalBearingFlags.SouthWest, 3)]
        [TestCase(OrdinalBearingFlags.All, 4)]
        public void GetCount_MatchingResult(OrdinalBearingFlags bearingFlags, int expectedResult)
        {
            Assert.AreEqual(bearingFlags.GetCount(), expectedResult);
        }
    }
}