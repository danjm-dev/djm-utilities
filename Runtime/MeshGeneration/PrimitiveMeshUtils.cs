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
            var segmentCountClamped = math.max(segmentCount, 3);
            var vertexCount = segmentCountClamped + 1;
            var indexCount = segmentCountClamped * 3;
            
            vertices = new NativeArray<VertexData>(vertexCount, Allocator.Temp);
            indices = new NativeArray<ushort>(indexCount, Allocator.Temp);

            var xAxisOffset = math.normalizesafe(xAxis, math.right());
            var yAxisOffset = math.normalizesafe(yAxis, math.up());
            var normal = math.normalize(math.cross(xAxisOffset, yAxisOffset));
            
            xAxisOffset *= radius;
            yAxisOffset *= radius;
            
            var anglePerSegment = MathUtils.PI2 / segmentCountClamped;
            
            vertices[0] = new VertexData(float3.zero, normal);
            
            for (var i = 0; i < segmentCountClamped; i++)
            {
                var angle = i * anglePerSegment;
                var x = math.cos(angle);
                var y = math.sin(angle);

                vertices[i + 1] = new VertexData(x * xAxisOffset + y * yAxisOffset, normal);
                
                indices[i * 3] = 0;
                indices[i * 3 + 1] = (ushort)(i + 1);
                indices[i * 3 + 2] = (ushort)(i + 2 <= segmentCountClamped ? i + 2 : 1);
            }

            bounds = new Bounds(Vector3.zero, (Vector2.one * radius).XYO());
        }

    }
}