using UnityEngine;

namespace DJM.Utilities
{
    public static class Rigidbody2DExtensions
    {
        public static void ClearVelocity(this Rigidbody2D rigidbody, Vector3 force)
        {
            rigidbody.linearVelocity = Vector2.zero;
            rigidbody.angularVelocity = 0f;
        }
    }
}