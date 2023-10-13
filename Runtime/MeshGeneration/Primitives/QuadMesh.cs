using UnityEngine;
using UnityEngine.Rendering;

namespace DJM.Utilities.MeshGeneration
{
    public static class QuadMesh
    {
        public static readonly ushort[] Triangles = { 0, 1, 2, 0, 2, 3 };
        public static readonly Vector2[] Uvs = { new(0, 0), new(0, 1), new(1, 1), new(1, 0) };
        
        public static Mesh Create(Vector3 centerPosition, float width, float height, Vector3 normal)
        {
            // Check if normal is roughly pointing up/down
            var notParallel = Mathf.Abs(Vector3.Dot(normal, Vector3.up)) < 0.99f ? Vector3.up : Vector3.right; 
            
            var halfWidthOffset = Vector3.Normalize(Vector3.Cross(normal, notParallel)) * width * 0.5f;
            var halfHeightOffset = Vector3.Normalize(Vector3.Cross(halfWidthOffset, normal)) * height * 0.5f;
            
            var vertices = new[]
            {
                centerPosition - halfWidthOffset - halfHeightOffset,
                centerPosition - halfWidthOffset + halfHeightOffset,
                centerPosition + halfWidthOffset + halfHeightOffset,
                centerPosition + halfWidthOffset - halfHeightOffset
            };
            
            var normals = new [] { normal, normal, normal, normal };
            
            var mesh = new Mesh();
            mesh.indexFormat = IndexFormat.UInt16;
            mesh.vertices = vertices;
            mesh.uv = Uvs;
            mesh.normals = normals;
            mesh.SetTriangles(Triangles, 0);
            return mesh;
        } 
    }
}