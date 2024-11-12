using System.Diagnostics;
using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    public static partial class Gizmos2
    {
        public static UnityEngine.Color Color
        {
            get => Gizmos.color;
            set => Gizmos.color = value;
        } 
        
        public static Matrix4x4 Matrix
        {
            get => Gizmos.matrix;
            set => Gizmos.matrix = value;
        }

        [Conditional("UNITY_EDITOR")]
        public static void Set2DConfiguration(AxisAlignedPlane plane, float depth)
        {
#if UNITY_EDITOR
            _2DPlane = plane;
            _depth2D = depth;
#endif
        }
        
#if UNITY_EDITOR
        private static readonly Vector3[] PointBuffer = new Vector3[256];
        private static UnityEngine.Color _originalColor = Gizmos.color;
        
        private static float _depth2D = 0f;
        private static AxisAlignedPlane _2DPlane = AxisAlignedPlane.XY;
        
        private static void SetColor(UnityEngine.Color? color = null)
        {
            if(!color.HasValue) return;
            _originalColor = Gizmos.color;
            Gizmos.color = color.Value;
        }
        
        private static void RevertColor()
        {
            if(Gizmos.color == _originalColor) return;
            Gizmos.color = _originalColor;
        }
        
        private static Vector2 GetRectOriginPosition(Vector2 position, Vector2 rectSize, RectPivot pivot)
        {
            if(pivot == RectPivot.Origin) return position;
            return position - rectSize * 0.5f;
        }

        private static Vector3 GetPositionFor2D(Vector2 position)
        {
            return _2DPlane switch
            {
                AxisAlignedPlane.XY => position.XY0(_depth2D),
                AxisAlignedPlane.XZ => position.X0Y(_depth2D),
                AxisAlignedPlane.YZ => position.X0Y(_depth2D),
                _ => position.XY0(_depth2D)
            };
        }
        
#endif
    }
}