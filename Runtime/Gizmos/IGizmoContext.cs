using System;
using DJM.Utilities.BezierCurves;
using UnityEngine;

namespace DJM.Utilities.Gizmos
{
    public interface IGizmoContext : IDisposable
    {
        public IGizmoContext SetColor(UnityEngine.Color color);
        public IGizmoContext SetMatrix(Matrix4x4 matrix);
        public IGizmoContext SetMatrix(Vector3 rightAxis, Vector3 upAxis, Vector3 originPosition = default);
        public IGizmoContext SetMatrix(SignedAxis rightAxis, SignedAxis upAxis, Vector3 originPosition = default);
        public IGizmoContext SetDefaultMatrix(Vector3 originPosition = default);
        public IGizmoContext SetWorldSpaceMatrix(Vector3 originPosition = default);
        public IGizmoContext SetPivot(RectPivot pivot);
        public IGizmoContext SetDefaultPivot();
        public IGizmoContext Set2dDepth(float depth);
        public IGizmoContext SetDefault2dDepth();
        
        public IGizmoContext SetSize(float size);
        public IGizmoContext SetSize(Vector2 size);
        public IGizmoContext SetSize(Vector3 size);
        public IGizmoContext SetDefaultSize();
        
        public IGizmoContext DrawLine(Vector3 from, Vector3 to);
        public IGizmoContext DrawLine(Vector2 from, Vector2 to);
        
        public IGizmoContext DrawCube(Vector3 position, Vector3? size = null, RectPivot? pivot = null);

        public IGizmoContext DrawCube(Vector2 position, Vector3? size = null, RectPivot? pivot = null);
        public IGizmoContext DrawWireCube(Vector3 position, Vector3? size = null, RectPivot? pivot = null);

        public IGizmoContext DrawWireCube(Vector2 position, Vector3? size = null, RectPivot? pivot = null);
        
        public IGizmoContext DrawRect(Vector3 position, Vector2? size = null, RectPivot? pivot = null);
        public IGizmoContext DrawRect(Vector2 position, Vector2? size = null, RectPivot? pivot = null);
        public IGizmoContext DrawRectOutline(Vector3 position, Vector2? size = null, RectPivot? pivot = null);
        public IGizmoContext DrawRectOutline(Vector2 position, Vector2? size = null, RectPivot? pivot = null);

        public IGizmoContext DrawSphere(Vector3 position, float? radius = null);
        public IGizmoContext DrawSphere(Vector2 position, float? radius = null);
        public IGizmoContext DrawWireSphere(Vector3 position, float? radius = null);
        public IGizmoContext DrawWireSphere(Vector2 position, float? radius = null);
        
        public IGizmoContext DrawCircle(Vector3 position, float? radius = null);
        public IGizmoContext DrawCircle(Vector2 position, float? radius = null);
        public IGizmoContext DrawCircleOutline(Vector3 position, float? radius = null);
        public IGizmoContext DrawCircleOutline(Vector2 position, float? radius = null);
        
        public IGizmoContext DrawEclipse(Vector3 position, Vector2? axisRadii = null);
        public IGizmoContext DrawEclipse(Vector2 position, Vector2? axisRadii = null);
        public IGizmoContext DrawEclipseOutline(Vector3 position, Vector2? axisRadii = null);
        public IGizmoContext DrawEclipseOutline(Vector2 position, Vector2? axisRadii = null);
        
        public IGizmoContext DrawBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, int? segmentResolution = null);
        public IGizmoContext DrawBezierCurve(CubicBezierCurve curve, int? segmentResolution = null);
        public IGizmoContext DrawBezierCurve(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, int? segmentResolution = null);
        public IGizmoContext DrawBezierCurve(CubicBezierCurve2D curve, int? segmentResolution = null);
        public IGizmoContext DrawBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, int? segmentResolution = null);
        public IGizmoContext DrawBezierCurve(QuadraticBezierCurve curve, int? segmentResolution = null);
        public IGizmoContext DrawBezierCurve(Vector2 p0, Vector2 p1, Vector2 p2, int? segmentResolution = null);
        public IGizmoContext DrawBezierCurve(QuadraticBezierCurve2D curve, int? segmentResolution = null);
        
        public IGizmoContext DrawGridLines(Vector3 position, Vector2Int gridResolution, Vector2 cellSize, RectPivot? pivot = null);
        public IGizmoContext DrawGridLines(Vector2 position, Vector2Int gridResolution, Vector2 cellSize, RectPivot? pivot = null);
        public IGizmoContext DrawGridLines(Vector3 position, Vector3Int gridResolution, Vector3 cellSize, RectPivot? pivot = null);
        
        public IGizmoContext DrawGridNodes(Vector3 position, Vector2Int gridResolution, Vector2 cellSize, RectPivot? pivot = null);
        public IGizmoContext DrawGridNodes(Vector2 position, Vector2Int gridResolution, Vector2 cellSize, RectPivot? pivot = null);
        public IGizmoContext DrawGridNodes(Vector3 position, Vector3Int gridResolution, Vector3 cellSize, RectPivot? pivot = null);
    }
}