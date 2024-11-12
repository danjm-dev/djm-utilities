using System.Diagnostics;
using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    public static partial class Gizmos2
    {
        [Conditional("UNITY_EDITOR")]
        public static void DrawLine(Vector3 from, Vector3 to, UnityEngine.Color? color = null)
        {
#if UNITY_EDITOR
            SetColor(color);
            Gizmos.DrawLine(from, to);
            RevertColor();
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawLine
        (
            Vector2 from, 
            Vector2 to, 
            float? positionDepth = null, 
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR

            var fromPosition = Get3DPosition(from, plane, positionDepth);
            var toPosition = Get3DPosition(to, plane, positionDepth);
            DrawLine(fromPosition, toPosition, color);
#endif
        }
    }
}