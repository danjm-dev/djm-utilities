using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    public static partial class Gizmos2
    {
#if UNITY_EDITOR
        private static UnityEngine.Color _originalColor = Gizmos.color;
        
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

        private static Vector3 GetRectOriginPosition
        (
            Vector3 position, 
            Vector2 rectSize, 
            RectPivot pivot, 
            AxisAlignedPlane? planeOverride
        )
        {
            if(pivot == RectPivot.Origin) return position;
            
            var plane = planeOverride ?? CustomGizmosSettings.DefaultPlane;
            var (xAxis, yAxis) = plane.GetAxes();
            
            var offset = Vector3.zero;
            offset += xAxis * rectSize.x * 0.5f;
            offset += yAxis * rectSize.y * 0.5f;
            
            return position - offset;
        }
        
        private static Vector3 Get3DPosition(Vector2 position, AxisAlignedPlane? planeOverride, float? depthOverride)
        {
            var plane = planeOverride ?? CustomGizmosSettings.DefaultPlane;
            var depth = depthOverride ?? CustomGizmosSettings.DefaultForwardDepth;
            return plane switch
            {
                AxisAlignedPlane.XY => position.XYO(depth),
                AxisAlignedPlane.XZ => position.XOY(depth),
                AxisAlignedPlane.ZY => position.OYX(depth),
                _ => position.XYO(depth)
            };
        }

        private static (Vector3, Vector3) Get2DPlaneAxes(AxisAlignedPlane? planeOverride)
        {
            var plane = planeOverride ?? CustomGizmosSettings.DefaultPlane;
            return plane.GetAxes();
        }
#endif
    }
}