using System;
using DJM.Utilities.Debugging;
using UnityEditor;
using UnityEngine;
using MathUtils = DJM.Utilities.Math.MathUtils;

namespace DJM.Utilities.CustomGizmos
{
    internal sealed class CustomGizmoContext : IGizmoContext
    {
        private Vector3 _rightAxis;
        private Vector3 _upAxis;
        private float _forwardDepth;

        public CustomGizmoContext() => SetDefaultSettings();
        public void Dispose() => SetDefaultSettings();
        
        public IGizmoContext SetColor(UnityEngine.Color color)
        {
            Gizmos.color = color;
            return this;
        }

        public IGizmoContext SetMatrix(Matrix4x4 matrix)
        {
            Gizmos.matrix = matrix;
            return this;
        }
        
        public IGizmoContext Set2DAxes(Vector3 rightAxis, Vector3 upAxis, float forwardDepth = 0)
        {
            if (!CustomGizmoUtils.AreAxesValid(rightAxis, upAxis))
            {
                DebugUtils.LogError("CustomGizmos: Axes are invalid and could not be set.");
                return this;
            }
            
            _rightAxis = rightAxis;
            _upAxis = upAxis;
            _forwardDepth = forwardDepth;
            return this;
        }

        public IGizmoContext Set2DAxes(SignedAxis rightAxis, SignedAxis upAxis, float forwardDepth = 0)
        {
            return Set2DAxes(rightAxis.GetDirection(), upAxis.GetDirection(), forwardDepth);
        }
        
        
        
        public IGizmoContext DrawLine(Vector3 from, Vector3 to)
        {
            Gizmos.DrawLine(from, to);
            return this;
        }

        public IGizmoContext DrawLine(Vector2 from, Vector2 to)
        {
            return DrawLine(Get3DPosition(from), Get3DPosition(to));
        }

        
        
        public IGizmoContext DrawCube(Vector3 position, Vector3 size, RectPivot pivot = RectPivot.Center)
        {
            size = MathUtils.Abs(size);
            var offset = pivot == RectPivot.Center ? Vector3.zero : size * 0.5f;
            Gizmos.DrawCube(position + offset, size);
            return this;
        }

        public IGizmoContext DrawWireCube(Vector3 position, Vector3 size, RectPivot pivot = RectPivot.Center)
        {
            size = MathUtils.Abs(size);
            var offset = pivot == RectPivot.Center ? Vector3.zero : size * 0.5f;
            Gizmos.DrawWireCube(position + offset, size);
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
            Gizmos.DrawSphere(position, Mathf.Abs(radius));
            return this;
        }

        public IGizmoContext DrawWireSphere(Vector3 position, float radius)
        {
            Gizmos.DrawWireSphere(position, Mathf.Abs(radius));
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
            Gizmos.color = UnityEngine.Color.white;
            Gizmos.matrix = Matrix4x4.identity;
            _rightAxis = CustomGizmosSettings.DefaultRightAxis.GetDirection();
            _upAxis = CustomGizmosSettings.DefaultUpAxis.GetDirection();
            _forwardDepth = CustomGizmosSettings.DefaultForwardDepth;
        }

        private Vector3 Get3DPosition(Vector2 position2D, Vector3 offset = default)
        {
            return CustomGizmoUtils.Get3DPosition
            (
                position2D + offset.XY(), 
                _forwardDepth + offset.z, 
                _rightAxis, 
                _upAxis
            );
        }
    }
    
    public static class Giz
    {
        public static readonly IGizmoContext Instance;
        
        static Giz()
        {
#if UNITY_EDITOR
            Instance = new CustomGizmoContext();
#else
            Instance = new DefaultGizmoContext();
#endif
        }

#if UNITY_EDITOR
        [InitializeOnLoadMethod]
        private static void Initialize() => Instance.Dispose();
#endif
    }
    
    public interface IGizmoContext : IDisposable
    {
        public IGizmoContext SetColor(UnityEngine.Color color);
        public IGizmoContext SetMatrix(Matrix4x4 matrix);

        public IGizmoContext Set2DAxes(SignedAxis rightAxis, SignedAxis upAxis, float forwardDepth = 0f);
        public IGizmoContext Set2DAxes(Vector3 rightAxis, Vector3 upAxis, float forwardDepth = 0f);
        
        public IGizmoContext DrawLine(Vector3 from, Vector3 to);
        public IGizmoContext DrawLine(Vector2 from, Vector2 to);
        
        public IGizmoContext DrawCube(Vector3 position, Vector3 size, RectPivot pivot = RectPivot.Center);
        public IGizmoContext DrawWireCube(Vector3 position, Vector3 size, RectPivot pivot = RectPivot.Center);
        
        public IGizmoContext DrawRect(Vector3 position, Vector2 size, RectPivot pivot = RectPivot.Center);
        public IGizmoContext DrawRect(Vector2 position, Vector2 size, RectPivot pivot = RectPivot.Center);
        public IGizmoContext DrawRectOutline(Vector3 position, Vector2 size, RectPivot pivot = RectPivot.Center);
        public IGizmoContext DrawRectOutline(Vector2 position, Vector2 size, RectPivot pivot = RectPivot.Center);

        public IGizmoContext DrawSphere(Vector3 position, float radius);
        public IGizmoContext DrawWireSphere(Vector3 position, float radius);
        
        public IGizmoContext DrawCircle(Vector3 position, float radius);
        public IGizmoContext DrawCircle(Vector2 position, float radius);
        public IGizmoContext DrawCircleOutline(Vector3 position, float radius);
        public IGizmoContext DrawCircleOutline(Vector2 position, float radius);
        
        public IGizmoContext DrawEclipse(Vector3 position, Vector2 axisRadii);
        public IGizmoContext DrawEclipse(Vector2 position, Vector2 axisRadii);
        public IGizmoContext DrawEclipseOutline(Vector3 position, Vector2 axisRadii);
        public IGizmoContext DrawEclipseOutline(Vector2 position, Vector2 axisRadii);
        
        public IGizmoContext DrawBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3);
        public IGizmoContext DrawBezierCurve(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3);
        public IGizmoContext DrawBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2);
        public IGizmoContext DrawBezierCurve(Vector2 p0, Vector2 p1, Vector2 p2);
        
        public IGizmoContext DrawGridLines(Vector3 position, Vector2Int gridResolution, Vector2 cellSize, RectPivot pivot = RectPivot.Center);
        public IGizmoContext DrawGridLines(Vector2 position, Vector2Int gridResolution, Vector2 cellSize, RectPivot pivot = RectPivot.Center);
        public IGizmoContext DrawGridLines(Vector3 position, Vector3Int gridResolution, Vector3 cellSize, RectPivot pivot = RectPivot.Center);
        
        public IGizmoContext DrawGridNodes(Vector3 position, Vector2Int gridResolution, Vector2 cellSize, RectPivot pivot = RectPivot.Center);
        public IGizmoContext DrawGridNodes(Vector2 position, Vector2Int gridResolution, Vector2 cellSize, RectPivot pivot = RectPivot.Center);
        public IGizmoContext DrawGridNodes(Vector3 position, Vector3Int gridResolution, Vector3 cellSize, RectPivot pivot = RectPivot.Center);
    }
}