#if UNITY_EDITOR
using DJM.Utilities.Math;
using UnityEngine;

namespace DJM.Utilities.Gizmos
{
    internal static class CustomGizmoUtils
    {
        public static Vector3 Get3DPosition
        (
            Vector2 position2D, 
            float forwardDepth,
            Vector3 rightAxis, 
            Vector3 upAxis
            
        )
        {
            MathUtils.GetNormalizedAxes
            (
                rightAxis, 
                upAxis, 
                out var right, 
                out var up, 
                out var forward
            );
            
            return position2D.x * right + position2D.y * up + forwardDepth * forward;
        }
        
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