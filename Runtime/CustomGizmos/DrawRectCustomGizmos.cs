using System.Diagnostics;
using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    public static partial class Gizmos2
    {
        [Conditional("UNITY_EDITOR")]
        public static void DrawRect
        (
            Vector3 center, 
            Vector3 normal, 
            Vector2 size, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            SetColor(color);
            RectCustomGizmoUtils.DrawRect(center, normal, size);
            RevertColor();
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawRect
        (
            Vector2 center, 
            Vector2 size, 
            float? positionDepth = null, 
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            SetColor(color);
            RectCustomGizmoUtils.DrawRect
            (
                Get3DPosition(center, plane, positionDepth), 
                Get2DPlaneNormal(plane), 
                size
            );
            RevertColor();
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawRect
        (
            Vector3 center, 
            Vector2 size, 
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            SetColor(color);
            RectCustomGizmoUtils.DrawRect(center, Get2DPlaneNormal(plane), size);
            RevertColor();
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawRectOutline
        (
            Vector3 center, 
            Vector3 normal, 
            Vector2 size, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            SetColor(color);
            RectCustomGizmoUtils.DrawRectOutline(center, normal, size);
            RevertColor();
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawRectOutline
        (
            Vector2 center, 
            Vector2 size, 
            float? positionDepth = null, 
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            SetColor(color);
            RectCustomGizmoUtils.DrawRectOutline
            (
                Get3DPosition(center, plane, positionDepth), 
                Get2DPlaneNormal(plane), 
                size
            );
            RevertColor();
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawRectOutline
        (
            Vector3 center, 
            Vector2 size, 
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            SetColor(color);
            RectCustomGizmoUtils.DrawRectOutline(center, Get2DPlaneNormal(plane), size);
            RevertColor();
#endif
        }
    }
}