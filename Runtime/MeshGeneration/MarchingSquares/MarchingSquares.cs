using System;
using System.Collections.Generic;
using UnityEngine;

namespace DJM.Utilities.MeshGeneration
{
    public static class MarchingSquares
    {
        public static Mesh CreateMesh(bool[] grid, int width, int height, float nodeSize, float heightOffset, float depthOffset)
        {
            if (grid.Length != width * height) throw new ArgumentException("grid length does not match width * height");
            
            var squareCaseMeshHelper = new MarchingSquaresCaseHelper(nodeSize, heightOffset, depthOffset);
            var vertices = new List<Vector3>();
            var normals = new List<Vector3>();
            var triangles = new List<int>();
            

            for (int z = 0, i = 0; z < height - 1; z++, i++)
            {
                for (var x = 0; x < width - 1; x++, i++)
                {
                    var config = CalculateConfig
                    (
                        grid[i],
                        grid[i + width],
                        grid[i + width + 1],
                        grid[i + 1]
                    );
                    
                    var currentVertexIndex = vertices.Count;
                    vertices.AddRange(squareCaseMeshHelper.GetVertices(config, new Vector3(x * nodeSize, 0, z * nodeSize)));
                    normals.AddRange(MarchingSquaresCaseHelper.GetNormals(config));
                    triangles.AddRange(MarchingSquaresCaseHelper.GetTriangles(config, currentVertexIndex));
                }
            }
            
            // create mesh
            var mesh = new Mesh();
            mesh.vertices = vertices.ToArray();
            mesh.triangles = triangles.ToArray();
            mesh.normals = normals.ToArray();
            return mesh;
        }
        
        private static byte CalculateConfig(bool bottomLeftFilled, bool topLeftFilled, bool topRightFilled, bool bottomRightFilled)
        {
            return (byte)
            (
                (topLeftFilled ? 8 : 0) |
                (topRightFilled ? 4 : 0) |
                (bottomRightFilled ? 2 : 0) |
                (bottomLeftFilled ? 1 : 0)
            );
        }
    }
}