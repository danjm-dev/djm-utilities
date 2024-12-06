#if UNITY_EDITOR
using DJM.Utilities.Math;
using DJM.Utilities.Math.Geometry;
using UnityEngine;

namespace DJM.Utilities.EditorTools.Gizmos
{
    internal static class BezierCurveCustomGizmoUtils
    {
        public static void DrawCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, int segmentResolution)
        {
            var segmentResolutionClamped = Mathf.Max(segmentResolution, 1);
            var tIncrement = 1f / segmentResolutionClamped;
            
            BezierCurveUtils.EvaluatePosition(p0, p1, p2, p3, 0f, out var previousPosition);
            
            for (var i = 1; i <= segmentResolutionClamped; i++)
            {
                BezierCurveUtils.EvaluatePosition(p0, p1, p2, p3, i * tIncrement, out var position);
                UnityEngine.Gizmos.DrawLine(previousPosition, position);
                previousPosition = position;
            }
        }
        
        public static void DrawCurve(Vector3 p0, Vector3 p1, Vector3 p2, int segmentResolution)
        {
            var segmentResolutionClamped = Mathf.Max(segmentResolution, 1);
            var tIncrement = 1f / segmentResolutionClamped;
            
            BezierCurveUtils.EvaluatePosition(p0, p1, p2, 0f, out var previousPosition);
            
            for (var i = 1; i <= segmentResolutionClamped; i++)
            {
                BezierCurveUtils.EvaluatePosition(p0, p1, p2, i * tIncrement, out var position);
                UnityEngine.Gizmos.DrawLine(previousPosition, position);
                previousPosition = position;
            }
        }
    }
}
#endif