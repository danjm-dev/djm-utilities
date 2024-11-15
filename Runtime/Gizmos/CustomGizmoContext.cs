#if UNITY_EDITOR
using DJM.Utilities.BezierCurves;
using DJM.Utilities.Debugging;
using UnityEngine;

namespace DJM.Utilities.Gizmos
{
    internal sealed class CustomGizmoContext : IGizmoContext
    {
        private Vector3 _rightAxis;
        private Vector3 _upAxis;
        private float _forwardDepth;
        private Vector3 _size = Vector3.one;
        private RectPivot _pivot;
        
        public CustomGizmoContext() => SetDefaultSettings();
        public void Dispose() => SetDefaultSettings();

        public IGizmoContext SetColor(UnityEngine.Color color)
        {
            UnityEngine.Gizmos.color = color;
            return this;
        }

        public IGizmoContext SetMatrix(Matrix4x4 matrix)
        {
            UnityEngine.Gizmos.matrix = matrix;
            return this;
        }
        
        public IGizmoContext SetMatrix(Vector3 rightAxis, Vector3 upAxis, Vector3 originPosition = default)
        {
            if (!CustomGizmoUtils.AreAxesValid(rightAxis, upAxis))
            {
                DebugUtils.LogError("CustomGizmos: Axes are invalid and could not be set.");
                return this;
            }
            
            var forward = Vector3.Cross(rightAxis, upAxis).normalized;
            var rotation = Quaternion.LookRotation(forward, upAxis);
            return SetMatrix(Matrix4x4.TRS(originPosition, rotation, Vector3.one));
        }
        
        public IGizmoContext SetMatrix(SignedAxis rightAxis, SignedAxis upAxis, Vector3 originPosition = default)
        {
            return SetMatrix(rightAxis.GetDirection(), upAxis.GetDirection(), originPosition);
        }
        
        public IGizmoContext SetDefaultMatrix(Vector3 originPosition = default)
        {
            return SetMatrix(CustomGizmosSettings.DefaultRightAxis, CustomGizmosSettings.DefaultUpAxis, originPosition);
        }

        public IGizmoContext SetWorldSpaceMatrix(Vector3 originPosition = default)
        {
            SetMatrix(Matrix4x4.Translate(originPosition));
            return this;
        }

        public IGizmoContext SetPivot(RectPivot pivot)
        {
            _pivot = pivot;
            return this;
        }
        
        public IGizmoContext Set2DDepth(float depth)
        {
            _forwardDepth = depth;
            return this;
        }
        
        public IGizmoContext SetSize(float size)
        {
            _size = Vector3.one.WithX(Mathf.Max(size, 0));
            return this;
        }
        
        public IGizmoContext SetSize(Vector2 size)
        {
            _size = Vector2.Max(size, Vector2.zero).XYO(1f);
            return this;
        }
        
        public IGizmoContext SetSize(Vector3 size)
        {
            _size = Vector3.Max(size, Vector3.zero);
            return this;
        }
        
        
        
        public IGizmoContext DrawLine(Vector3 from, Vector3 to)
        {
            UnityEngine.Gizmos.DrawLine(from, to);
            return this;
        }

        public IGizmoContext DrawLine(Vector2 from, Vector2 to)
        {
            return DrawLine(Get3DPosition(from), Get3DPosition(to));
        }
        
        
        
        public IGizmoContext DrawCube(Vector3 position, Vector3? size = null, RectPivot? pivot = null)
        {
            var size2 = GetSize(size);
            var offset = GetPivot(pivot) == RectPivot.Center ? Vector3.zero : size2 * 0.5f;
            UnityEngine.Gizmos.DrawCube(position + offset, size2);
            return this;
        }
        
        public IGizmoContext DrawCube(Vector2 position, Vector3? size = null, RectPivot? pivot = null)
        {
            return DrawCube(Get3DPosition(position), size, pivot);
        }


        public IGizmoContext DrawWireCube(Vector3 position, Vector3? size = null, RectPivot? pivot =  null)
        {
            var size2 = GetSize(size);
            var offset = GetPivot(pivot) == RectPivot.Center ? Vector3.zero : size2 * 0.5f;
            UnityEngine.Gizmos.DrawWireCube(position + offset, size2);
            return this;
        }
        
        public IGizmoContext DrawWireCube(Vector2 position, Vector3? size = null, RectPivot? pivot = null)
        {
            return DrawWireCube(Get3DPosition(position), size, pivot);
        }
        
        
        public IGizmoContext DrawRect(Vector3 position, Vector2? size = null, RectPivot? pivot = null)
        {
            RectCustomGizmoUtils.DrawRect(position, GetSize(size), GetPivot(pivot));
            return this;
        }
        
        public IGizmoContext DrawRect(Vector2 position, Vector2? size = null, RectPivot? pivot = null)
        {
            return DrawRect(Get3DPosition(position), size, pivot);
        }
        
        public IGizmoContext DrawRectOutline(Vector3 position, Vector2? size = null, RectPivot? pivot = null)
        {
            RectCustomGizmoUtils.DrawRectOutline(position, GetSize(size), GetPivot(pivot));
            return this;
        }
        
        public IGizmoContext DrawRectOutline(Vector2 position, Vector2? size = null, RectPivot? pivot = null)
        {
            return DrawRectOutline(Get3DPosition(position), size, pivot);
        }
        
        
        
        public IGizmoContext DrawSphere(Vector3 position, float? radius = null)
        {
            UnityEngine.Gizmos.DrawSphere(position, GetSize(radius));
            return this;
        }
        
        public IGizmoContext DrawSphere(Vector2 position, float? radius = null)
        {
            return DrawSphere(Get3DPosition(position), radius);
        }

        public IGizmoContext DrawWireSphere(Vector3 position, float? radius = null)
        {
            UnityEngine.Gizmos.DrawWireSphere(position, GetSize(radius));
            return this;
        }
        
        public IGizmoContext DrawWireSphere(Vector2 position, float? radius = null)
        {
            return DrawWireSphere(Get3DPosition(position), radius);
        }
        
        
        public IGizmoContext DrawCircle(Vector3 position, float? radius = null)
        {
            CircleCustomGizmoUtils.DrawCircle(position, GetSize(radius));
            return this;
        }
        
        public IGizmoContext DrawCircle(Vector2 position, float? radius = null)
        {
            return DrawCircle(Get3DPosition(position), radius);
        }
        
        public IGizmoContext DrawCircleOutline(Vector3 position, float? radius = null)
        {
            CircleCustomGizmoUtils.DrawCircleOutline(position, GetSize(radius));
            return this;
        }
        
        public IGizmoContext DrawCircleOutline(Vector2 position, float? radius = null)
        {
            return DrawCircleOutline(Get3DPosition(position), radius);
        }

        
        
        public IGizmoContext DrawEclipse(Vector3 position, Vector2? axisRadii = null)
        {
            return this;
        }

        public IGizmoContext DrawEclipse(Vector2 position, Vector2? axisRadii = null)
        {
            return this;
        }

        public IGizmoContext DrawEclipseOutline(Vector3 position, Vector2? axisRadii = null)
        {
            return this;
        }

        public IGizmoContext DrawEclipseOutline(Vector2 position, Vector2? axisRadii = null)
        {
            return this;
        }



        public IGizmoContext DrawBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
        {
            return this;
        }

        public IGizmoContext DrawBezierCurve(CubicBezierCurve curve)
        {
            return this;
        }

        public IGizmoContext DrawBezierCurve(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
        {
            return this;
        }

        public IGizmoContext DrawBezierCurve(CubicBezierCurve2D curve)
        {
            return this;
        }

        public IGizmoContext DrawBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2)
        {
            return this;
        }

        public IGizmoContext DrawBezierCurve(QuadraticBezierCurve curve)
        {
            return this;
        }

        public IGizmoContext DrawBezierCurve(Vector2 p0, Vector2 p1, Vector2 p2)
        {
            return this;
        }

        public IGizmoContext DrawBezierCurve(QuadraticBezierCurve2D curve)
        {
            return this;
        }

        
        
        public IGizmoContext DrawGridLines
        (
            Vector3 position, 
            Vector2Int gridResolution, 
            Vector2 cellSize,
            RectPivot? pivot = null
        )
        {
            var originPosition = GetRectOriginPosition(position, gridResolution * cellSize, pivot);
            GridCustomGizmoUtils.DrawGridLines(originPosition, gridResolution, cellSize);
            return this;
        }

        public IGizmoContext DrawGridLines
        (
            Vector2 position, 
            Vector2Int gridResolution, 
            Vector2 cellSize,
            RectPivot? pivot = null
        )
        {
            return DrawGridLines(Get3DPosition(position), gridResolution, cellSize, pivot);
        }

        public IGizmoContext DrawGridLines
        (
            Vector3 position, 
            Vector3Int gridResolution, 
            Vector3 cellSize,
            RectPivot? pivot = null
        )
        {
            return this;
        }

        public IGizmoContext DrawGridNodes
        (
            Vector3 position, 
            Vector2Int gridResolution, 
            Vector2 cellSize,
            RectPivot? pivot = null
        )
        {
            var originPosition = GetRectOriginPosition(position, gridResolution * cellSize, pivot);
            GridCustomGizmoUtils.DrawGridNodes(originPosition, gridResolution, cellSize);
            return this;
        }

        public IGizmoContext DrawGridNodes
        (
            Vector2 position, 
            Vector2Int gridResolution, 
            Vector2 cellSize,
            RectPivot? pivot = null
        )
        {
            return DrawGridNodes(Get3DPosition(position), gridResolution, cellSize, pivot);
        }

        public IGizmoContext DrawGridNodes
        (
            Vector3 position, 
            Vector3Int gridResolution, 
            Vector3 cellSize,
            RectPivot? pivot = null
        )
        {
            return this;
        }


        private void SetDefaultSettings()
        {
            UnityEngine.Gizmos.color = UnityEngine.Color.white;
            SetDefaultMatrix();
            
            _rightAxis = CustomGizmosSettings.DefaultRightAxis.GetDirection();
            _upAxis = CustomGizmosSettings.DefaultUpAxis.GetDirection();
            
            _forwardDepth = CustomGizmosSettings.DefaultForwardDepth;
            _size = Vector3.one;
            _pivot = CustomGizmosSettings.DefaultPivot;
        }

        private Vector3 Get3DPosition(Vector2 position2D)
        {
            return position2D.XYO(_forwardDepth);
        }
        
        private Vector3 GetRectOriginPosition(Vector3 position, Vector3 size, RectPivot? pivot)
        {
            return (pivot ?? _pivot) == RectPivot.Origin 
                ? position 
                : position - size * 0.5f;
        }
        
        private Vector3 GetRectOriginPosition(Vector3 position, Vector2 size, RectPivot? pivot)
        {
            return GetRectOriginPosition(position, size.XYO(), pivot);
        }
        
        private float GetSize(float? overrideValue)
        {
            return overrideValue.HasValue ? Mathf.Max(overrideValue.Value, 0f) : _size.x;
        }
        
        private Vector2 GetSize(Vector2? overrideValue)
        {
            return overrideValue.HasValue ? Vector2.Max(overrideValue.Value, Vector2.zero) : _size.XY();
        }
        
        private Vector3 GetSize(Vector3? overrideValue)
        {
            return overrideValue.HasValue ? Vector3.Max(overrideValue.Value, Vector3.zero) : _size;
        }

        private RectPivot GetPivot(RectPivot? overrideValue)
        {
            return overrideValue ?? _pivot;
        }
    }
}
#endif