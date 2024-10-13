using UnityEngine;

namespace DJM.Utilities.Time
{
    public readonly struct Duration
    {
        public readonly float BaseDuration;
        public readonly float MaxRandomOffset;
        public float Value => BaseDuration + Random.Range(-MaxRandomOffset, MaxRandomOffset);
        
        public Duration(float baseDuration, float maxRandomOffset = 0f)
        {
            BaseDuration = Mathf.Max(0f, baseDuration);
            MaxRandomOffset = Mathf.Max(0f, maxRandomOffset);
        }
        
        public static implicit operator float(Duration duration) => duration.Value;
        public static implicit operator Duration(float duration) => new(duration);
    }
}