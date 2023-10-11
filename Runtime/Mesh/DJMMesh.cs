using UnityEngine;
using UnityEngine.Rendering;

namespace DJM.Utilities
{
    public static class DJMMesh
    {
        public static Mesh Quad(Vector3 centerPosition, float width, float height, Vector3 normal)
        {
            // Check if normal is not mostly pointing up/down
            var notParallel = Mathf.Abs(Vector3.Dot(normal, Vector3.up)) < 0.99f ? Vector3.up : Vector3.right; 

            // Use the notParallel vector to get the halfWidthOffset 
            var halfWidthOffset = Vector3.Normalize(Vector3.Cross(normal, notParallel)) * width * 0.5f;
            var halfHeightOffset = Vector3.Normalize(Vector3.Cross(halfWidthOffset, normal)) * height * 0.5f;
            
            var vertices = new[]
            {
                centerPosition - halfWidthOffset - halfHeightOffset,
                centerPosition - halfWidthOffset + halfHeightOffset,
                centerPosition + halfWidthOffset + halfHeightOffset,
                centerPosition + halfWidthOffset - halfHeightOffset
            };
            
            var tris = new ushort[] { 0, 1, 2, 0, 2, 3 };
            var normals = new [] { normal, normal, normal, normal };
            var uvs = new Vector2[] { new (0, 0), new (0, 1), new (1, 1), new (1, 0) };
            
            var mesh = new Mesh();
            mesh.indexFormat = IndexFormat.UInt16;
            mesh.vertices = vertices;
            mesh.uv = uvs;
            mesh.normals = normals;
            mesh.SetTriangles(tris, 0);
            return mesh;
        } 
    }
}