using System;
using System.Diagnostics;
using DJM.Utilities.MeshGeneration;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    [InitializeOnLoad]
    public static partial class Gizmos2
    {
        public static UnityEngine.Color Color
        {
            get => Gizmos.color;
            set => Gizmos.color = value;
        } 
        
        public static Matrix4x4 Matrix
        {
            get => Gizmos.matrix;
            set => Gizmos.matrix = value;
        }

        [Conditional("UNITY_EDITOR")]
        public static void Set2DConfiguration(AxisAlignedPlane plane, float depth)
        {
#if UNITY_EDITOR
            _2DPlane = plane;
            _depth2D = depth;
#endif
        }
        
#if UNITY_EDITOR
        private static readonly Vector3[] PointBuffer = new Vector3[256];
        private static UnityEngine.Color _originalColor = Gizmos.color;
        
        // todo: set these in project settings
        private static float _depth2D = 0f;
        private static AxisAlignedPlane _2DPlane = AxisAlignedPlane.XY;


        private static readonly Mesh _rectMesh;
        private static readonly Mesh _circleMesh;
        
        
        static Gizmos2()
        {
            _rectMesh = PrimitiveMeshUtils.GenerateRectMesh(1f, math.right(), math.up());
            _circleMesh = PrimitiveMeshUtils.GenerateCircleMesh(1f, math.right(), math.up(), CirclePointCount);
            
            // _rectMesh = new Mesh
            // {
            //     vertices = new[]
            //     {
            //         new Vector3(-0.5f, -0.5f, 0f),
            //         new Vector3(0.5f, -0.5f, 0f),
            //         new Vector3(0.5f, 0.5f, 0f),
            //         new Vector3(-0.5f, 0.5f, 0f)
            //     },
            //     triangles = new[] { 0, 1, 2, 0, 2, 3 },
            //     normals = new[] { Vector3.back, Vector3.back, Vector3.back, Vector3.back }
            // };
            
            
            
        }
        
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
            
            var plane = planeOverride ?? _2DPlane;
            var (xAxis, yAxis) = plane.GetAxes();
            
            var offset = Vector3.zero;
            offset += xAxis * rectSize.x * 0.5f;
            offset += yAxis * rectSize.y * 0.5f;
            
            return position - offset;
        }
        
        private static Vector3 Get3DPosition(Vector2 position, AxisAlignedPlane? planeOverride, float? depthOverride)
        {
            var plane = planeOverride ?? _2DPlane;
            var depth = depthOverride ?? _depth2D;
            return plane switch
            {
                AxisAlignedPlane.XY => position.XYO(depth),
                AxisAlignedPlane.XZ => position.XOY(depth),
                AxisAlignedPlane.ZY => position.OYX(depth),
                _ => position.XYO(depth)
            };
        }
        
        private static Vector3 Get2DPlaneNormal(AxisAlignedPlane? planeOverride)
        {
            var plane = planeOverride ?? _2DPlane;
            return plane.GetNormal();
        }

        private static (Vector3, Vector3) Get2DPlaneAxes(AxisAlignedPlane? planeOverride)
        {
            var plane = planeOverride ?? _2DPlane;
            return plane.GetAxes();
        }
#endif
    }
}