using System;
using DJM.Utilities.Debugging;
using UnityEngine;

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
        
        
        
        public IGizmoContext DrawRect(Vector3 position, Vector2 size, RectPivot pivot = RectPivot.Center)
        {
            RectCustomGizmoUtils.DrawRect(position, size, _rightAxis, _upAxis, pivot);
            return this;
        }
        
        public IGizmoContext DrawRect(Vector2 position, Vector2 size, RectPivot pivot = RectPivot.Center)
        {
            return DrawRect(Get3DPosition(position), size, pivot);
        }
        
        public IGizmoContext DrawRectOutline(Vector3 position, Vector2 size, RectPivot pivot = RectPivot.Center)
        {
            RectCustomGizmoUtils.DrawRectOutline(position, size, _rightAxis, _upAxis, pivot);
            return this;
        }
        
        public IGizmoContext DrawRectOutline(Vector2 position, Vector2 size, RectPivot pivot = RectPivot.Center)
        {
            return DrawRectOutline(Get3DPosition(position), size, pivot);
        }

        
        
        public IGizmoContext DrawSphere(Vector3 position, float radius)
        {
            Gizmos.DrawSphere(position, radius);
            return this;
        }

        public IGizmoContext DrawSphere(Vector2 position, float radius)
        {
            return DrawSphere(Get3DPosition(position), radius);
        }

        public IGizmoContext DrawWireSphere(Vector3 position, float radius)
        {
            Gizmos.DrawWireSphere(position, radius);
            return this;
        }

        public IGizmoContext DrawWireSphere(Vector2 position, float radius)
        {
            return DrawWireSphere(Get3DPosition(position), radius);
        }


        
        public IGizmoContext DrawCircle(Vector3 position, float radius)
        {
            CircleCustomGizmoUtils.DrawCircle(position, radius, _rightAxis, _upAxis);
            return this;
        }
        
        public IGizmoContext DrawCircle(Vector2 position, float radius)
        {
            return DrawCircle(Get3DPosition(position), radius);
        }
        
        public IGizmoContext DrawCircleOutline(Vector3 position, float radius)
        {
            CircleCustomGizmoUtils.DrawCircleOutline(position, radius, _rightAxis, _upAxis);
            return this;
        }
        
        public IGizmoContext DrawCircleOutline(Vector2 position, float radius)
        {
            return DrawCircleOutline(Get3DPosition(position), radius);
        }
        
        
        
        private void SetDefaultSettings()
        {
            Gizmos.color = UnityEngine.Color.white;
            Gizmos.matrix = Matrix4x4.identity;
            _rightAxis = CustomGizmosSettings.DefaultRightAxis.GetDirection();
            _upAxis = CustomGizmosSettings.DefaultUpAxis.GetDirection();
            _forwardDepth = CustomGizmosSettings.DefaultForwardDepth;
        }

        private Vector3 Get3DPosition(Vector2 position2D)
        {
            return CustomGizmoUtils.Get3DPosition(position2D, _rightAxis, _upAxis, _forwardDepth);
        }
    }

    // internal class DefaultGizmoContext : IGizmoContext
    // {
    //     public IGizmoContext SetColor(UnityEngine.Color color) => this;
    //     public IGizmoContext SetMatrix(Matrix4x4 matrix) => this;
    //
    //     public void Dispose() { }
    // }
    
    public static class Giz
    {
        public static readonly IGizmoContext Instance;
        
        static Giz()
        {
#if UNITY_EDITOR
            Instance = new CustomGizmoContext();
#else
            //Instance = new DefaultGizmoContext();
#endif
        }
        
    }
    
    public interface IGizmoContext : IDisposable
    {
        public IGizmoContext SetColor(UnityEngine.Color color);
        public IGizmoContext SetMatrix(Matrix4x4 matrix);

        public IGizmoContext Set2DAxes(SignedAxis rightAxis, SignedAxis upAxis, float forwardDepth = 0f);
        public IGizmoContext Set2DAxes(Vector3 rightAxis, Vector3 upAxis, float forwardDepth = 0f);

        
        public IGizmoContext DrawLine(Vector3 from, Vector3 to);
        public IGizmoContext DrawLine(Vector2 from, Vector2 to);
        
        
        
        public IGizmoContext DrawRect(Vector3 position, Vector2 size, RectPivot pivot = RectPivot.Center);
        public IGizmoContext DrawRect(Vector2 position, Vector2 size, RectPivot pivot = RectPivot.Center);
        public IGizmoContext DrawRectOutline(Vector3 position, Vector2 size, RectPivot pivot = RectPivot.Center);
        public IGizmoContext DrawRectOutline(Vector2 position, Vector2 size, RectPivot pivot = RectPivot.Center);

        public IGizmoContext DrawSphere(Vector3 position, float radius);
        public IGizmoContext DrawSphere(Vector2 position, float radius);
        public IGizmoContext DrawWireSphere(Vector3 position, float radius);
        public IGizmoContext DrawWireSphere(Vector2 position, float radius);
        
        public IGizmoContext DrawCircle(Vector3 position, float radius);
        public IGizmoContext DrawCircle(Vector2 position, float radius);
        public IGizmoContext DrawCircleOutline(Vector3 position, float radius);
        public IGizmoContext DrawCircleOutline(Vector2 position, float radius);
    }
}