﻿using System;
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
        
        public IGizmoContext Set2DPlane(Vector3 rightAxis, Vector3 upAxis, float forwardDepth = 0)
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
        
        public IGizmoContext Set2DPlane(SignedAxis rightAxis, SignedAxis upAxis, float forwardDepth = 0)
        {
            return Set2DPlane(rightAxis.GetDirection(), upAxis.GetDirection(), forwardDepth);
        }

        
        

        
        public IGizmoContext DrawRect(Vector3 position, Vector2 size, RectPivot pivot = RectPivot.Center)
        {
            RectCustomGizmoUtils.DrawRect(position, size, _rightAxis, _upAxis, pivot);
            return this;
        }
        
        public IGizmoContext DrawRect(Vector2 position, Vector2 size, RectPivot pivot = RectPivot.Center)
        {
            var position3D = CustomGizmoUtils.Get3DPosition(position, _rightAxis, _upAxis, _forwardDepth);
            return DrawRect(position3D, size, pivot);
        }
        
        public IGizmoContext DrawRectOutline(Vector3 position, Vector2 size, RectPivot pivot = RectPivot.Center)
        {
            RectCustomGizmoUtils.DrawRectOutline(position, size, _rightAxis, _upAxis, pivot);
            return this;
        }
        
        public IGizmoContext DrawRectOutline(Vector2 position, Vector2 size, RectPivot pivot = RectPivot.Center)
        {
            var position3D = CustomGizmoUtils.Get3DPosition(position, _rightAxis, _upAxis, _forwardDepth);
            return DrawRectOutline(position3D, size, pivot);
        }
        
        
        
        
        private void SetDefaultSettings()
        {
            Gizmos.color = UnityEngine.Color.white;
            Gizmos.matrix = Matrix4x4.identity;
            _rightAxis = CustomGizmosSettings.DefaultRightAxis.GetDirection();
            _upAxis = CustomGizmosSettings.DefaultUpAxis.GetDirection();
            _forwardDepth = CustomGizmosSettings.DefaultForwardDepth;
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

        public IGizmoContext Set2DPlane(SignedAxis rightAxis, SignedAxis upAxis, float forwardDepth = 0f);
        public IGizmoContext Set2DPlane(Vector3 rightAxis, Vector3 upAxis, float forwardDepth = 0f);

        public IGizmoContext DrawRect(Vector3 position, Vector2 size, RectPivot pivot = RectPivot.Center);
        public IGizmoContext DrawRect(Vector2 position, Vector2 size, RectPivot pivot = RectPivot.Center);
        public IGizmoContext DrawRectOutline(Vector3 position, Vector2 size, RectPivot pivot = RectPivot.Center);
        public IGizmoContext DrawRectOutline(Vector2 position, Vector2 size, RectPivot pivot = RectPivot.Center);
    }
}