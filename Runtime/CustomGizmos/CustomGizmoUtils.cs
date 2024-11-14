#if UNITY_EDITOR
using DJM.Utilities.Math;
using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    internal static class CustomGizmoUtils
    {
        // public static Vector3 Get3DPosition
        // (
        //     Vector2 position2D, 
        //     SignedAxis? rightAxis, 
        //     SignedAxis? upAxis,
        //     float? forwardDepth
        // )
        // {
        //     return Get3DPosition
        //     (
        //         position2D, 
        //         rightAxis?.GetDirection(), 
        //         upAxis?.GetDirection(),
        //         forwardDepth
        //     );
        // }
        //
        public static Vector3 Get3DPosition
        (
            Vector2 position2D, 
            Vector3 rightAxis, 
            Vector3 upAxis, 
            float forwardDepth
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

        // public static SignedAxis GetRightAxis(SignedAxis? rightAxis)
        // {
        //     return rightAxis ?? CustomGizmosSettings.CurrentRightAxis;
        // }
        //
        // public static SignedAxis GetUpAxis(SignedAxis? upAxis)
        // {
        //     return upAxis ?? CustomGizmosSettings.CurrentUpAxis;
        // }
        
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