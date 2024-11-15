using DJM.Utilities.BezierCurves;
using UnityEngine;

namespace DJM.Utilities.Gizmos
{
    internal class DefaultGizmoContext : IGizmoContext
    {
        public IGizmoContext SetColor(UnityEngine.Color color) => this;
        public IGizmoContext SetMatrix(Matrix4x4 matrix) => this;
        public IGizmoContext SetMatrix(Vector3 rightAxis, Vector3 upAxis, Vector3 originPosition = default) => this;
        public IGizmoContext SetMatrix(SignedAxis rightAxis, SignedAxis upAxis, Vector3 originPosition = default) => this;
        public IGizmoContext SetDefaultMatrix(Vector3 originPosition = default) => this;
        public IGizmoContext SetWorldSpaceMatrix(Vector3 originPosition = default) => this;
        public IGizmoContext SetPivot(RectPivot pivot) => this;
        public IGizmoContext SetDefaultPivot() => this;
        public IGizmoContext Set2dDepth(float depth) => this;
        public IGizmoContext SetDefault2dDepth() => this;
        public IGizmoContext SetSize(float size) => this;
        public IGizmoContext SetSize(Vector2 size) => this;
        public IGizmoContext SetSize(Vector3 size) => this;
        public IGizmoContext SetDefaultSize() => this;
        public IGizmoContext DrawLine(Vector3 from, Vector3 to) => this;
        public IGizmoContext DrawLine(Vector2 from, Vector2 to) => this;
        public IGizmoContext DrawCube(Vector3 position, Vector3? size = null, RectPivot? pivot = null) => this;
        public IGizmoContext DrawCube(Vector2 position, Vector3? size = null, RectPivot? pivot = null) => this;
        public IGizmoContext DrawWireCube(Vector3 position, Vector3? size = null, RectPivot? pivot = null) => this;
        public IGizmoContext DrawWireCube(Vector2 position, Vector3? size = null, RectPivot? pivot = null) => this;
        public IGizmoContext DrawRect(Vector3 position, Vector2? size = null, RectPivot? pivot = null) => this;
        public IGizmoContext DrawRect(Vector2 position, Vector2? size = null, RectPivot? pivot = null) => this;
        public IGizmoContext DrawRectOutline(Vector3 position, Vector2? size = null, RectPivot? pivot = null) => this;
        public IGizmoContext DrawRectOutline(Vector2 position, Vector2? size = null, RectPivot? pivot = null) => this;
        public IGizmoContext DrawSphere(Vector3 position, float? radius = null) => this;
        public IGizmoContext DrawSphere(Vector2 position, float? radius = null) => this;
        public IGizmoContext DrawWireSphere(Vector3 position, float? radius = null) => this;
        public IGizmoContext DrawWireSphere(Vector2 position, float? radius = null) => this;
        public IGizmoContext DrawCircle(Vector3 position, float? radius = null) => this;
        public IGizmoContext DrawCircle(Vector2 position, float? radius = null) => this;
        public IGizmoContext DrawCircleOutline(Vector3 position, float? radius = null) => this;
        public IGizmoContext DrawCircleOutline(Vector2 position, float? radius = null) => this;
        public IGizmoContext DrawEclipse(Vector3 position, Vector2? axisRadii = null) => this;
        public IGizmoContext DrawEclipse(Vector2 position, Vector2? axisRadii = null) => this;
        public IGizmoContext DrawEclipseOutline(Vector3 position, Vector2? axisRadii = null) => this;
        public IGizmoContext DrawEclipseOutline(Vector2 position, Vector2? axisRadii = null) => this;
        public IGizmoContext DrawBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) => this;
        public IGizmoContext DrawBezierCurve(CubicBezierCurve curve) => this;
        public IGizmoContext DrawBezierCurve(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) => this;
        public IGizmoContext DrawBezierCurve(CubicBezierCurve2D curve) => this;
        public IGizmoContext DrawBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2) => this;
        public IGizmoContext DrawBezierCurve(QuadraticBezierCurve curve) => this;
        public IGizmoContext DrawBezierCurve(Vector2 p0, Vector2 p1, Vector2 p2) => this;
        public IGizmoContext DrawBezierCurve(QuadraticBezierCurve2D curve) => this;
        public IGizmoContext DrawGridLines(Vector3 position, Vector2Int gridResolution, Vector2 cellSize, RectPivot? pivot = null) => this;
        public IGizmoContext DrawGridLines(Vector2 position, Vector2Int gridResolution, Vector2 cellSize, RectPivot? pivot = null) => this;
        public IGizmoContext DrawGridLines(Vector3 position, Vector3Int gridResolution, Vector3 cellSize, RectPivot? pivot = null) => this;
        public IGizmoContext DrawGridNodes(Vector3 position, Vector2Int gridResolution, Vector2 cellSize, RectPivot? pivot = null) => this;
        public IGizmoContext DrawGridNodes(Vector2 position, Vector2Int gridResolution, Vector2 cellSize, RectPivot? pivot = null) => this;
        public IGizmoContext DrawGridNodes(Vector3 position, Vector3Int gridResolution, Vector3 cellSize, RectPivot? pivot = null) => this;
        public void Dispose() { }
    }
}