using DJM.Utilities.Math;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities.MeshGeneration
{
    [BurstCompile]
    public static class PrimitiveMeshUtils
    {
        [BurstDiscard]
        public static void GenerateCircleMesh
        (
            float radius,
            float3 xAxis,
            float3 yAxis,
            int segmentCount,
            Mesh mesh
        )
        {
            GenerateCircleMeshData
            (
                radius, 
                xAxis, 
                yAxis, 
                segmentCount, 
                out var vertices, 
                out var indices, 
                out var bounds
            );
            
            MeshGenerationUtils.AllocateMeshData(vertices, indices, bounds, out var meshDataArray);
            
            vertices.Dispose();
            indices.Dispose();
            
            MeshGenerationUtils.ApplyMeshData(mesh, meshDataArray);
        }
        
        [BurstDiscard]
        public static Mesh GenerateCircleMesh
        (
            float radius,
            float3 xAxis,
            float3 yAxis,
            int segmentCount
        )
        {
            var mesh = new Mesh();
            GenerateCircleMesh(radius, xAxis, yAxis, segmentCount, mesh);
            return mesh;
        }
        
        [BurstDiscard]
        public static void GenerateRectMesh
        (
            float2 size,
            float3 xAxis,
            float3 yAxis,
            Mesh mesh
        )
        {
            GenerateRectMeshData
            (
                size, 
                xAxis, 
                yAxis, 
                out var vertices, 
                out var indices, 
                out var bounds
            );
            
            MeshGenerationUtils.AllocateMeshData(vertices, indices, bounds, out var meshDataArray);
            
            vertices.Dispose();
            indices.Dispose();
            
            MeshGenerationUtils.ApplyMeshData(mesh, meshDataArray);
        }
        
        [BurstDiscard]
        public static Mesh GenerateRectMesh
        (
            float2 size,
            float3 xAxis,
            float3 yAxis
        )
        {
            var mesh = new Mesh();
            GenerateRectMesh(size, xAxis, yAxis, mesh);
            return mesh;
        }
        
        [BurstCompile]
        private static void GenerateCircleMeshData
        (
            in float radius, 
            in float3 xAxis, 
            in float3 yAxis, 
            in int segmentCount, 
            out NativeArray<VertexData> vertices,
            out NativeArray<ushort> indices,
            out Bounds bounds
        )
        {
            MathUtils.GetNormalizedAxes(xAxis, yAxis, out var right, out var up, out var forward);
            var xAxisOffset = right * radius;
            var yAxisOffset = up * radius;
            var normal = -forward;
            
            var segmentCountClamped = math.max(segmentCount, 3);
            var vertexCount = segmentCountClamped + 1;
            var indexCount = segmentCountClamped * 3;
            var anglePerSegment = MathUtils.PI2 / segmentCountClamped;
            
            vertices = new NativeArray<VertexData>(vertexCount, Allocator.Temp);
            indices = new NativeArray<ushort>(indexCount, Allocator.Temp);
            
            vertices[0] = new VertexData(float3.zero, normal);
            
            for (var i = 0; i < segmentCountClamped; i++)
            {
                var angle = i * anglePerSegment;
                var x = math.cos(angle);
                var y = math.sin(angle);

                vertices[i + 1] = new VertexData(x * xAxisOffset + y * yAxisOffset, normal);
                
                indices[i * 3] = 0;
                indices[i * 3 + 1] = (ushort)(i + 2 <= segmentCountClamped ? i + 2 : 1);
                indices[i * 3 + 2] = (ushort)(i + 1);
            }

            bounds = new Bounds(Vector3.zero, (Vector2.one * radius).XYO());
        }

        [BurstCompile]
        private static void GenerateRectMeshData
        (
            in float2 size, 
            in float3 xAxis, 
            in float3 yAxis, 
            out NativeArray<VertexData> vertices,
            out NativeArray<ushort> indices,
            out Bounds bounds
        )
        { 
            const int vertexCount = 4;
            const int indexCount = 6;
            
            MathUtils.GetNormalizedAxes(xAxis, yAxis, out var right, out var up, out var forward);
            var xOffset = right * size.x;
            var yOffset = up * size.y;
            var originOffset = xOffset * -0.5f + yOffset * -0.5f;
            var normal = -forward;
            
            vertices = new NativeArray<VertexData>(vertexCount, Allocator.Temp);
            indices = new NativeArray<ushort>(indexCount, Allocator.Temp);
            
            vertices[0] = new VertexData(originOffset, normal);
            vertices[1] = new VertexData(originOffset + yOffset, normal);
            vertices[2] = new VertexData(originOffset + yOffset + xOffset, normal);
            vertices[3] = new VertexData(originOffset + xOffset, normal);
            
            indices[0] = 0;
            indices[1] = 1;
            indices[2] = 2;
            indices[3] = 0;
            indices[4] = 2;
            indices[5] = 3;

            bounds = new Bounds(Vector3.zero, size.XYO());
        }
    }
}