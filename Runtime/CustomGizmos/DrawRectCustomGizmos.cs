using System.Diagnostics;
using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    public static partial class Gizmos2
    {
        [Conditional("UNITY_EDITOR")]
        public static void DrawRect
        (
            Vector2 center, 
            Vector2 size, 
            RectPivot pivot = RectPivot.Center,
            SignedAxis? rightAxis = null,
            SignedAxis? upAxis = null,
            float? forwardDepth = null, 
            UnityEngine.Color? color = null
        )
        {
// #if UNITY_EDITOR
//             SetColor(color);
//             RectCustomGizmoUtils.DrawRect
//             (
//                 CustomGizmoUtils.Get3DPosition(center, rightAxis, upAxis, forwardDepth), 
//                 size,
//                 CustomGizmoUtils.GetRightAxis(rightAxis).GetDirection(), 
//                 CustomGizmoUtils.GetUpAxis(upAxis).GetDirection(),
//                 pivot
//             );
//             RevertColor();
// #endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawRect
        (
            Vector3 center, 
            Vector2 size, 
            RectPivot pivot = RectPivot.Center,
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
// #if UNITY_EDITOR
//             SetColor(color);
//
//             var (xAxis, yAxis) = Get2DPlaneAxes(plane);
//             RectCustomGizmoUtils.DrawRect(center, size, xAxis, yAxis, pivot);
//             RevertColor();
// #endif
        }
        
//         [Conditional("UNITY_EDITOR")]
//         public static void DrawRectOutline
//         (
//             Vector3 center, 
//             Vector3 normal, 
//             Vector2 size, 
//             UnityEngine.Color? color = null
//         )
//         {
// #if UNITY_EDITOR
//             SetColor(color);
//             RectCustomGizmoUtils.DrawRectOutline(center, normal, size);
//             RevertColor();
// #endif
//         }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawRectOutline
        (
            Vector2 center, 
            Vector2 size, 
            RectPivot pivot = RectPivot.Center,
            float? positionDepth = null, 
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            SetColor(color);
            var (xAxis, yAxis) = Get2DPlaneAxes(plane);
            RectCustomGizmoUtils.DrawRectOutline
            (
                Get3DPosition(center, plane, positionDepth), 
                size,
                xAxis,
                yAxis,
                pivot
            );
            RevertColor();
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawRectOutline
        (
            Vector3 center, 
            Vector2 size, 
            RectPivot pivot = RectPivot.Center,
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            SetColor(color);
            var (xAxis, yAxis) = Get2DPlaneAxes(plane);
            RectCustomGizmoUtils.DrawRectOutline(center, size, xAxis, yAxis, pivot);
            RevertColor();
#endif
        }
    }
}