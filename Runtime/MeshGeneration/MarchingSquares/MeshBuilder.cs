using System.Collections.Generic;
using UnityEngine;

namespace DJM.Utilities.MeshGeneration
{
    internal sealed class MeshBuilder
    {
        private readonly List<Vector3> _vertices = new();
        private readonly List<int> _triangles = new();
        
        public Vector3[] Vertices => _vertices.ToArray();
        public int[] Triangles => _triangles.ToArray();
        
        public void TriangulateFace(params Vector3[] vertices)
        {
            var indices = AddVertices(vertices);
            Triangulate(_triangles, indices);
        }
        
        private int[] AddVertices(params Vector3[] newVertices)
        {
            var firstNewIndex = _vertices.Count;
            var vertexIndices = new int[newVertices.Length];

            for (var i = 0; i < newVertices.Length; i++)
            {
                vertexIndices[i] = firstNewIndex + i;

                var newVertex = newVertices[i];
                _vertices.Add(newVertex);
            }
            
            return vertexIndices;
        }

        private static void Triangulate(ICollection<int> triangles, params int[] indices)
        {
            for (var i = 0; i < indices.Length - 2; i++)
            {
                triangles.Add(indices[0]);
                triangles.Add(indices[i + 1]);
                triangles.Add(indices[i + 2]);
            }
        }
    }
}