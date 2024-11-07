using System;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities.Floats
{
    [Serializable]
    public struct RandomOffsetFloat : IFormattable, IEquatable<RandomOffsetFloat>
    {
        [SerializeField] private float baseValue;
        [SerializeField, Min(0f)] private float maxOffset;
        
        public float BaseValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => baseValue;
        }

        public float MaxOffset
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => maxOffset;
        }

        public float Value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => baseValue + UnityEngine.Random.Range(-maxOffset, maxOffset);
        }

        public float MinValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => baseValue - maxOffset;
        }

        public float MaxValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => baseValue + maxOffset;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RandomOffsetFloat(float baseValue, float maxOffset = 0f)
        {
            this.baseValue = baseValue;
            this.maxOffset = math.max(0f, maxOffset);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return $"{MinValue.ToString(format, formatProvider)} - {MaxValue.ToString(format, formatProvider)}";
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(RandomOffsetFloat other)
        {
            return baseValue.Equals(other.baseValue) && maxOffset.Equals(other.maxOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] 
        public override string ToString() => $"{MinValue} - {MaxValue}";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj) => obj is RandomOffsetFloat other && Equals(other);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => (int)math.hash(new float2(baseValue, maxOffset));
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float(RandomOffsetFloat randomOffsetFloat) => randomOffsetFloat.Value;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator RandomOffsetFloat(float baseValue) => new(baseValue);
    }
}