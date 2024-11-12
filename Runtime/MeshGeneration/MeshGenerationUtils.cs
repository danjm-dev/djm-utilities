using DJM.Utilities.Math;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

namespace DJM.Utilities.MeshGeneration
{
    [BurstCompile]
    public static class MeshGenerationUtils
    {
        private const MeshUpdateFlags NoCalculationFlags = MeshUpdateFlags.DontRecalculateBounds | 
                                                       MeshUpdateFlags.DontValidateIndices | 
                                                       MeshUpdateFlags.DontNotifyMeshUsers | 
                                                       MeshUpdateFlags.DontResetBoneBounds;

        
        [BurstCompile]
        public static void AllocateMeshData
        (
            in NativeArray<VertexData> vertices, 
            in NativeArray<ushort> indices, 
            in Bounds bounds,
            out Mesh.MeshDataArray meshDataArray
        )
        {
            var vertexCount = vertices.Length;
            var indexCount = indices.Length;
            
            meshDataArray = Mesh.AllocateWritableMeshData(1);
            var meshData = meshDataArray[0];
            
            meshData.SetIndexBufferParams(indexCount, IndexFormat.UInt16);
            
            var attributes = new NativeArray<VertexAttributeDescriptor>(2, Allocator.Temp);
            attributes[0] = new VertexAttributeDescriptor(VertexAttribute.Position, VertexAttributeFormat.Float32, 3);
            attributes[1] = new VertexAttributeDescriptor(VertexAttribute.Normal, VertexAttributeFormat.Float32, 3);
            meshData.SetVertexBufferParams(vertexCount, attributes);
            attributes.Dispose();

            meshData.GetVertexData<VertexData>().CopyFrom(vertices);
            meshData.GetIndexData<ushort>().CopyFrom(indices);
            
            meshData.subMeshCount = 1;
            var subMeshDescriptor = new SubMeshDescriptor(0, indexCount, MeshTopology.Triangles)
            {
                bounds = bounds,
                firstVertex = 0,
                vertexCount = vertexCount
            };
            meshData.SetSubMesh(0, subMeshDescriptor, NoCalculationFlags);
        }
        
        [BurstDiscard]
        public static void ApplyMeshData(Mesh mesh, Mesh.MeshDataArray meshDataArray)
        {
            var bounds = meshDataArray[0].GetSubMesh(0).bounds;
            Mesh.ApplyAndDisposeWritableMeshData(meshDataArray, mesh, NoCalculationFlags);
            mesh.bounds = bounds;
        }
    }
    
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly struct VertexData 
    {
        public readonly float3 Position;
        public readonly float3 Normal;
        
        public VertexData(float3 position, float3 normal)
        {
            Position = position;
            Normal = normal;
        }
    }
}