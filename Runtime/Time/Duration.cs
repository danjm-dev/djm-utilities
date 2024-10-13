using UnityEngine;

namespace DJM.Utilities.Time
{
    public readonly struct Duration
    {
        public readonly float BaseDuration;
        public readonly float RandomOffset;
        public float Value => BaseDuration + Random.Range(-RandomOffset, RandomOffset);
        
        public Duration(float baseDuration, float randomOffset = 0f)
        {
            BaseDuration = Mathf.Max(0f, baseDuration);
            RandomOffset = Mathf.Max(0f, randomOffset);
        }
        
        public static implicit operator float(Duration duration) => duration.Value; 
    }
}