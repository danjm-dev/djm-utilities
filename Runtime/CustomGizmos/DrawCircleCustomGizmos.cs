﻿using System;
using System.Diagnostics;
using DJM.Utilities.Math;
using DJM.Utilities.MeshGeneration;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities.CustomGizmos
{
    public static partial class Gizmos2
    {
        [Conditional("UNITY_EDITOR")]
        public static void DrawCircle
        (
            Vector3 center, 
            Vector3 normal, 
            float radius, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            DrawCircleInternal(center, normal, radius, color);
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawCircle
        (
            Vector2 center, 
            float radius, 
            float? positionDepth = null, 
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            DrawCircleInternal(Get3DPosition(center, plane, positionDepth), Get2DPlaneNormal(plane), radius, color);
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawCircle
        (
            Vector3 center, 
            float radius, 
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            DrawCircleInternal(center, Get2DPlaneNormal(plane), radius, color);
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawCircleOutline(Vector3 center, Vector3 normal, float radius, UnityEngine.Color? color = null)
        {
#if UNITY_EDITOR
            DrawCircleOutlineInternal(center, normal, radius, color);
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawCircleOutline
        (
            Vector2 center, 
            float radius, 
            float? positionDepth = null, 
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            DrawCircleOutlineInternal(Get3DPosition(center, plane, positionDepth), Get2DPlaneNormal(plane), radius, color);
#endif
        }
        
        [Conditional("UNITY_EDITOR")]
        public static void DrawCircleOutline
        (
            Vector3 center, 
            float radius, 
            AxisAlignedPlane? plane = null, 
            UnityEngine.Color? color = null
        )
        {
#if UNITY_EDITOR
            DrawCircleOutlineInternal(center, Get2DPlaneNormal(plane), radius, color);
#endif
        }
        
#if UNITY_EDITOR       
        
        private const int CirclePointCount = 36;
        private const float CircleRadiansPerPoint = MathUtils.PI2 / CirclePointCount;
        
        private static void DrawCircleOutlineInternal
        (
            Vector3 center, 
            Vector3 normal, 
            float radius, 
            UnityEngine.Color? color = null
        )
        {
            if(radius <= Mathf.Epsilon) return;
            if(normal == Vector3.zero) return;
            
            SetColor(color);
            
            normal = normal.normalized;
            var xDirection = normal != Vector3.up
                ? Vector3.Cross(normal, Vector3.up).normalized
                : Vector3.Cross(normal, Vector3.right).normalized;
            var yDirection = Vector3.Cross(normal, xDirection).normalized;
            
            for (var i = 0; i < CirclePointCount; i++)
            {
                var angle = i * CircleRadiansPerPoint;
                var x = Mathf.Cos(angle);
                var y = Mathf.Sin(angle);
                PointBuffer[i] = center + x * xDirection * radius + y * yDirection * radius;
            }
            
            Gizmos.DrawLineStrip(new ReadOnlySpan<Vector3>(PointBuffer, 0, CirclePointCount), true);
            
            RevertColor();
        }

        private static void DrawCircleInternal
        (
            Vector3 center,
            Vector3 normal,
            float radius,
            UnityEngine.Color? color = null
        )
        {
            SetColor(color);
            Gizmos.DrawMesh(_circleMesh, center, Quaternion.LookRotation(normal), Vector3.one * radius);
            RevertColor();
        }
#endif
    }
}