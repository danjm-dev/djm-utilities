#if UNITY_EDITOR
using DJM.Utilities.Debugging;
using UnityEngine;
using MathUtils = DJM.Utilities.Math.MathUtils;

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
        
        public IGizmoContext SetPivot(RectPivot pivot)
        {
            _pivot = pivot;
            return this;
        }
        
        public IGizmoContext Set2DAxes(Vector3 rightAxis, Vector3 upAxis)
        {
            if (!CustomGizmoUtils.AreAxesValid(rightAxis, upAxis))
            {
                DebugUtils.LogError("CustomGizmos: Axes are invalid and could not be set.");
                return this;
            }
            
            _rightAxis = rightAxis;
            _upAxis = upAxis;
            return this;
        }

        public IGizmoContext Set2DAxes(SignedAxis rightAxis, SignedAxis upAxis)
        {
            return Set2DAxes(rightAxis.GetDirection(), upAxis.GetDirection());
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
            var pivot2 = GetPivot(pivot);
            var offset = pivot2 == RectPivot.Center ? Vector3.zero : size2 * 0.5f;
            UnityEngine.Gizmos.DrawCube(position + offset, size2);
            return this;
        }

        public IGizmoContext DrawWireCube(Vector3 position, Vector3? size = null, RectPivot? pivot =  null)
        {
            var size2 = GetSize(size);
            var pivot2 = GetPivot(pivot);
            var offset = pivot2 == RectPivot.Center ? Vector3.zero : size2 * 0.5f;
            UnityEngine.Gizmos.DrawWireCube(position + offset, size2);
            return this;
        }
        
        
        
        public IGizmoContext DrawRect(Vector3 position, Vector2 size, RectPivot pivot = RectPivot.Center)
        {
            RectCustomGizmoUtils.DrawRect(position, MathUtils.Abs(size), _rightAxis, _upAxis, pivot);
            return this;
        }
        
        public IGizmoContext DrawRect(Vector2 position, Vector2 size, RectPivot pivot = RectPivot.Center)
        {
            return DrawRect(Get3DPosition(position), size, pivot);
        }
        
        public IGizmoContext DrawRectOutline(Vector3 position, Vector2 size, RectPivot pivot = RectPivot.Center)
        {
            RectCustomGizmoUtils.DrawRectOutline(position, MathUtils.Abs(size), _rightAxis, _upAxis, pivot);
            return this;
        }
        
        public IGizmoContext DrawRectOutline(Vector2 position, Vector2 size, RectPivot pivot = RectPivot.Center)
        {
            return DrawRectOutline(Get3DPosition(position), size, pivot);
        }

        
        
        public IGizmoContext DrawSphere(Vector3 position, float radius)
        {
            UnityEngine.Gizmos.DrawSphere(position, Mathf.Abs(radius));
            return this;
        }

        public IGizmoContext DrawWireSphere(Vector3 position, float radius)
        {
            UnityEngine.Gizmos.DrawWireSphere(position, Mathf.Abs(radius));
            return this;
        }
        
        
        
        public IGizmoContext DrawCircle(Vector3 position, float radius)
        {
            CircleCustomGizmoUtils.DrawCircle(position, Mathf.Abs(radius), _rightAxis, _upAxis);
            return this;
        }
        
        public IGizmoContext DrawCircle(Vector2 position, float radius)
        {
            return DrawCircle(Get3DPosition(position), radius);
        }
        
        public IGizmoContext DrawCircleOutline(Vector3 position, float radius)
        {
            CircleCustomGizmoUtils.DrawCircleOutline(position, Mathf.Abs(radius), _rightAxis, _upAxis);
            return this;
        }
        
        public IGizmoContext DrawCircleOutline(Vector2 position, float radius)
        {
            return DrawCircleOutline(Get3DPosition(position), radius);
        }

        
        
        public IGizmoContext DrawEclipse(Vector3 position, Vector2 axisRadii)
        {
            return this;
        }

        public IGizmoContext DrawEclipse(Vector2 position, Vector2 axisRadii)
        {
            return this;
        }

        public IGizmoContext DrawEclipseOutline(Vector3 position, Vector2 axisRadii)
        {
            return this;
        }

        public IGizmoContext DrawEclipseOutline(Vector2 position, Vector2 axisRadii)
        {
            return this;
        }

        
        
        public IGizmoContext DrawBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
        {
            return this;
        }

        public IGizmoContext DrawBezierCurve(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3)
        {
            return this;
        }

        public IGizmoContext DrawBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2)
        {
            return this;
        }

        public IGizmoContext DrawBezierCurve(Vector2 p0, Vector2 p1, Vector2 p2)
        {
            return this;
        }

        
        
        public IGizmoContext DrawGridLines
        (
            Vector3 position, 
            Vector2Int gridResolution, 
            Vector2 cellSize,
            RectPivot pivot = RectPivot.Center
        )
        {
            GridCustomGizmoUtils.DrawGridLines(position, gridResolution, cellSize, _rightAxis, _upAxis, pivot);
            return this;
        }

        public IGizmoContext DrawGridLines
        (
            Vector2 position, 
            Vector2Int gridResolution, 
            Vector2 cellSize,
            RectPivot pivot = RectPivot.Center
        )
        {
            return DrawGridLines(Get3DPosition(position), gridResolution, cellSize, pivot);
        }

        public IGizmoContext DrawGridLines
        (
            Vector3 position, 
            Vector3Int gridResolution, 
            Vector3 cellSize,
            RectPivot pivot = RectPivot.Center
        )
        {
            return this;
        }

        public IGizmoContext DrawGridNodes
        (
            Vector3 position, 
            Vector2Int gridResolution, 
            Vector2 cellSize,
            RectPivot pivot = RectPivot.Center
        )
        {
            GridCustomGizmoUtils.DrawGridNodes(position, gridResolution, cellSize, _rightAxis, _upAxis, pivot);
            return this;
        }

        public IGizmoContext DrawGridNodes
        (
            Vector2 position, 
            Vector2Int gridResolution, 
            Vector2 cellSize,
            RectPivot pivot = RectPivot.Center
        )
        {
            return DrawGridNodes(Get3DPosition(position), gridResolution, cellSize, pivot);
        }

        public IGizmoContext DrawGridNodes
        (
            Vector3 position, 
            Vector3Int gridResolution, 
            Vector3 cellSize,
            RectPivot pivot = RectPivot.Center
        )
        {
            return this;
        }


        private void SetDefaultSettings()
        {
            UnityEngine.Gizmos.color = UnityEngine.Color.white;
            UnityEngine.Gizmos.matrix = Matrix4x4.identity;
            _rightAxis = CustomGizmosSettings.DefaultRightAxis.GetDirection();
            _upAxis = CustomGizmosSettings.DefaultUpAxis.GetDirection();
            _forwardDepth = CustomGizmosSettings.DefaultForwardDepth;
            _size = Vector3.one;
            _pivot = CustomGizmosSettings.DefaultPivot;
        }

        private Vector3 Get3DPosition(Vector2 position2D)
        {
            return CustomGizmoUtils.Get3DPosition
            (
                position2D, 
                _forwardDepth, 
                _rightAxis, 
                _upAxis
            );
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