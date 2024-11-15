#if UNITY_EDITOR
using UnityEngine;

namespace DJM.Utilities.Gizmos
{
    internal static class CustomGizmoUtils
    {
        public static bool AreAxesValid(SignedAxis right, SignedAxis up)
        {
            return right.GetUnsignedAxis() != up.GetUnsignedAxis();
        }
        
        public static bool AreAxesValid(Vector3 right, Vector3 up)
        {
            if(right == Vector3.zero || up == Vector3.zero) return false;
            return Mathf.Abs(Vector3.Dot(right.normalized, up.normalized)) < 0.99f;
        }
    }
}
#endif