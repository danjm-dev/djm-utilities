using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    public static partial class Gizmos2
    {
#if UNITY_EDITOR
        private static readonly Vector3[] PointBuffer = new Vector3[256];
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
        
        private static Vector2 GetRectOriginPosition(Vector2 position, Vector2 rectSize, RectPivot pivot)
        {
            if(pivot == RectPivot.Origin) return position;
            return position - rectSize * 0.5f;
        }
        
#endif
    }
}