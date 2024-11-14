using System;
using UnityEngine;

namespace DJM.Utilities.Gizmos
{
    public interface IGizmoContext : IDisposable
    {
        public IGizmoContext SetColor(UnityEngine.Color color);
        public IGizmoContext SetMatrix(Matrix4x4 matrix);

        public IGizmoContext SetPivot(RectPivot pivot);
        
        public IGizmoContext Set2DAxes(SignedAxis rightAxis, SignedAxis upAxis);
        public IGizmoContext Set2DAxes(Vector3 rightAxis, Vector3 upAxis);
        public IGizmoContext Set2DDepth(float depth);
        
        public IGizmoContext SetSize(float size);
        public IGizmoContext SetSize(Vector2 size);
        public IGizmoContext SetSize(Vector3 size);
        
        public IGizmoContext DrawLine(Vector3 from, Vector3 to);
        public IGizmoContext DrawLine(Vector2 from, Vector2 to);
        
        public IGizmoContext DrawCube(Vector3 position, Vector3? size = null, RectPivot? pivot = null);
        public IGizmoContext DrawWireCube(Vector3 position, Vector3? size = null, RectPivot? pivot = null);
        
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