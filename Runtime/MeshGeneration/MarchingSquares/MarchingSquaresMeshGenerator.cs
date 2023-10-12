using System;
using System.Collections.Generic;
using UnityEngine;

namespace DJM.Utilities.MeshGeneration
{
    internal static class MarchingSquaresMeshGenerator
    {
        private static Vector3 _topLeftOffset;
        private static Vector3 _topRightOffset;
        private static Vector3 _bottomRightOffset;
        
        private static Vector3 _leftOffset;
        private static Vector3 _rightOffset;
        private static Vector3 _topOffset;
        private static Vector3 _bottomOffset;


        public static Mesh Generate(float nodeSize, float depth, MarchingSquareData[] gridConfig)
        {
            _topLeftOffset = Vector3.forward * nodeSize;
            _bottomRightOffset = Vector3.right * nodeSize;
            _topRightOffset = _topLeftOffset + _bottomRightOffset;

            _leftOffset =  Vector3.forward * nodeSize * .5f;
            _rightOffset = _bottomRightOffset + Vector3.forward * nodeSize * .5f;
            _topOffset = _topLeftOffset + Vector3.right * nodeSize * .5f;
            _bottomOffset = Vector3.right * nodeSize * .5f;
            
            
            
            // get vertices
            
            
            var yOffset = Vector3.up * Mathf.Abs(depth) * 0.5f;
            
            var vertices = new List<Vector3>();
            var triangulationBuffer = new List<TriangulationData>();

            for (var i = 0; i < gridConfig.Length; i++)
            {
                var square = gridConfig[i];
                if(square.Config == 0) continue;
                
                
                // top
                var firstIndex = vertices.Count;
                vertices.AddRange(GetVertices(square, yOffset));
                triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
                
                // bottom
                firstIndex = vertices.Count;
                vertices.AddRange(GetVertices(square, -yOffset));
                triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count, true));
                
            }
            
            
            
            
            
            
            // get triangles
            var triangles = new List<int>();
            
            for (var i = 0; i < triangulationBuffer.Count; i++)
            {
                var triangulationData = triangulationBuffer[i];
                
                if (triangulationData.Inverse) InverseTriangulate(triangles, triangulationBuffer[i]);
                else Triangulate(triangles, triangulationBuffer[i]);
            }
            
            // create mesh
            var mesh = new Mesh();
            mesh.vertices = vertices.ToArray();
            mesh.triangles = triangles.ToArray();
            mesh.RecalculateNormals();
            return mesh;
        }
        
        private static void Triangulate(ICollection<int> triangles, TriangulationData triangulationData)
        {
            for (var i = triangulationData.StartIndex; i < triangulationData.EndIndex - 2; i++)
            {
                triangles.Add(triangulationData.StartIndex);
                triangles.Add(i + 1);
                triangles.Add(i + 2);
            }
        }
        
        private static void InverseTriangulate(ICollection<int> triangles, TriangulationData triangulationData)
        {
            for (var i = triangulationData.StartIndex; i < triangulationData.EndIndex - 2; i++)
            {
                triangles.Add(triangulationData.StartIndex);
                triangles.Add(i + 2);
                triangles.Add(i + 1);
            }
        }
        
        private static IEnumerable<Vector3> GetVertices(MarchingSquareData squareData, Vector3 offset = default)
        {
            var basePosition = squareData.BasePosition;
            
            return squareData.Config switch
            {
                0 => Array.Empty<Vector3>(),
                
                // 1 points:
                1 => new[]
                {
                    basePosition + offset, 
                    basePosition + offset + _leftOffset, 
                    basePosition + offset + _bottomOffset
                },
                2 => new[]
                {
                    basePosition + offset + _bottomOffset, 
                    basePosition + offset + _rightOffset, 
                    basePosition + offset + _bottomRightOffset
                },
                4 => new[]
                {
                    basePosition + offset + _topOffset, 
                    basePosition + offset + _topRightOffset, 
                    basePosition + offset + _rightOffset
                },
                8 => new[]
                {
                    basePosition + offset + _leftOffset, 
                    basePosition + offset + _topLeftOffset, 
                    basePosition + offset + _topOffset
                },
                
                // 2 points:
                3 => new[]
                {
                    basePosition + offset, 
                    basePosition + offset + _leftOffset, 
                    basePosition + offset + _rightOffset,
                    basePosition + offset + _bottomRightOffset
                },
                6 => new[]
                {
                    basePosition + offset + _bottomOffset, 
                    basePosition + offset + _topOffset, 
                    basePosition + offset + _topRightOffset,
                    basePosition + offset + _bottomRightOffset
                },
                9 => new[]
                {
                    basePosition + offset, 
                    basePosition + offset + _topLeftOffset, 
                    basePosition + offset + _topOffset,
                    basePosition + offset + _bottomOffset
                },
                12 => new[]
                {
                    basePosition + offset + _leftOffset, 
                    basePosition + offset + _topLeftOffset, 
                    basePosition + offset + _topRightOffset,
                    basePosition + offset + _rightOffset
                },
                5 => new[] // note: ambiguous case
                {
                    basePosition + offset, 
                    basePosition + offset + _leftOffset, 
                    basePosition + offset + _topOffset,
                    basePosition + offset + _topRightOffset, 
                    basePosition + offset + _rightOffset, 
                    basePosition + offset + _bottomOffset
                },
                10 => new[] // note: ambiguous case
                {
                    basePosition + offset + _leftOffset, 
                    basePosition + offset + _topLeftOffset, 
                    basePosition + offset + _topOffset,
                    basePosition + offset + _rightOffset, 
                    basePosition + offset + _bottomRightOffset, 
                    basePosition + offset + _bottomOffset
                },
                
                // 3 point:
                7 => new[]
                {
                    basePosition + offset, 
                    basePosition + offset + _leftOffset, 
                    basePosition + offset + _topOffset,
                    basePosition + offset + _topRightOffset, 
                    basePosition + offset + _bottomRightOffset
                },
                11 => new[]
                {
                    basePosition + offset, 
                    basePosition + offset + _topLeftOffset, 
                    basePosition + offset + _topOffset,
                    basePosition + offset + _rightOffset, 
                    basePosition + offset + _bottomRightOffset
                },
                13 => new[]
                {
                    basePosition + offset, 
                    basePosition + offset + _topLeftOffset, 
                    basePosition + offset + _topRightOffset,
                    basePosition + offset + _rightOffset, 
                    basePosition + offset + _bottomOffset
                },
                14 => new[]
                {
                    basePosition + offset + _leftOffset, 
                    basePosition + offset + _topLeftOffset, 
                    basePosition + offset + _topRightOffset,
                    basePosition + offset + _bottomRightOffset, 
                    basePosition + offset + _bottomOffset
                },
                
                //4 point:
                15 => new[]
                {
                    basePosition + offset, 
                    basePosition + offset + _topLeftOffset, 
                    basePosition + offset + _topRightOffset,
                    basePosition + offset + _bottomRightOffset
                },
                _ => throw new ArgumentException()
            };
        }
        
        private readonly struct TriangulationData
        {
            public readonly int StartIndex;
            public readonly int EndIndex;
            public readonly bool Inverse;

            public TriangulationData(int startIndex, int endIndex, bool inverse = false)
            {
                StartIndex = startIndex;
                EndIndex = endIndex;
                Inverse = inverse;
            }
        }
    }
}