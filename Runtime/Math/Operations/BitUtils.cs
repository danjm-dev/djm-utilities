using Unity.Burst;

namespace DJM.Utilities.Math
{
    [BurstCompile]
    public static class BitUtils
    {
        [BurstCompile]
        public static int ShiftAndWrapBits(int bits, int bitCount, int offset)
        {
            var wrappedAmount = offset % bitCount;
            var leftShift = wrappedAmount < 0 ? wrappedAmount + bitCount : wrappedAmount;
            var rightShift = bitCount - leftShift;
            
            return (bits >> rightShift | bits << leftShift) & ((1 << bitCount) - 1);
        }
    }
}