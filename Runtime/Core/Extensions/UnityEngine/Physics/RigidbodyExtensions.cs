using UnityEngine;

namespace DJM.Utilities
{
    public static class RigidbodyExtensions
    {
        public static void ClearVelocity(this Rigidbody rigidbody, Vector3 force)
        {
            rigidbody.linearVelocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }
    }
}