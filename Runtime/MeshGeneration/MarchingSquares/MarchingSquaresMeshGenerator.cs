using System;
using System.Collections.Generic;
using UnityEngine;

namespace DJM.Utilities.MeshGeneration
{
    internal static class MarchingSquaresMeshGenerator
    {
        private static Vector3 _bottomLeftOffset;
        private static Vector3 _topLeftOffset;
        private static Vector3 _topRightOffset;
        private static Vector3 _bottomRightOffset;
        
        private static Vector3 _leftOffset;
        private static Vector3 _rightOffset;
        private static Vector3 _topOffset;
        private static Vector3 _bottomOffset;


        public static Mesh Generate(float nodeSize, MarchingSquareData[] gridConfig)
        {
            _bottomLeftOffset = Vector3.zero;
            _topLeftOffset = Vector3.forward * nodeSize;
            _bottomRightOffset = Vector3.right * nodeSize;
            _topRightOffset = _topLeftOffset + _bottomRightOffset;

            _leftOffset = _bottomLeftOffset + Vector3.forward * nodeSize * .5f;
            _rightOffset = _bottomRightOffset + Vector3.forward * nodeSize * .5f;
            _topOffset = _topLeftOffset + Vector3.right * nodeSize * .5f;
            _bottomOffset = _bottomLeftOffset + Vector3.right * nodeSize * .5f;
            
            
            
            // get vertices
            var vertices = new List<Vector3>();
            var triangulationBuffer = new List<int>();

            for (var i = 0; i < gridConfig.Length; i++)
            {
                var square = gridConfig[i];
                if(square.Config == 0) continue;
                
                triangulationBuffer.Add(vertices.Count);
                vertices.AddRange(GetVertices(square));
            }
            triangulationBuffer.Add(vertices.Count);
            
            // get triangles
            var triangles = new List<int>();
            
            for (var i = 0; i < triangulationBuffer.Count -1; i++)
            {
                Triangulate(triangles, triangulationBuffer[i], triangulationBuffer[i + 1]);
            }
            
            // create mesh
            var mesh = new Mesh();
            mesh.vertices = vertices.ToArray();
            mesh.triangles = triangles.ToArray();
            mesh.RecalculateNormals();
            return mesh;
        }
        
        private static void Triangulate(ICollection<int> triangles, int startIndex, int endIndex)
        {
            for (var i = startIndex; i < endIndex - 2; i++)
            {
                triangles.Add(startIndex);
                triangles.Add(i + 1);
                triangles.Add(i + 2);
            }
        }
        
        private static IEnumerable<Vector3> GetVertices(MarchingSquareData squareData)
        {
            var basePosition = squareData.BasePosition;
            
            return squareData.Config switch
            {
                0 => Array.Empty<Vector3>(),
                
                // 1 points:
                1 => new[]
                {
                    basePosition + _bottomLeftOffset, 
                    basePosition + _leftOffset, 
                    basePosition + _bottomOffset
                },
                2 => new[]
                {
                    basePosition + _bottomOffset, 
                    basePosition + _rightOffset, 
                    basePosition + _bottomRightOffset
                },
                4 => new[]
                {
                    basePosition + _topOffset, 
                    basePosition + _topRightOffset, 
                    basePosition + _rightOffset
                },
                8 => new[]
                {
                    basePosition + _leftOffset, 
                    basePosition + _topLeftOffset, 
                    basePosition + _topOffset
                },
                
                // 2 points:
                3 => new[]
                {
                    basePosition + _bottomLeftOffset, 
                    basePosition + _leftOffset, 
                    basePosition + _rightOffset,
                    basePosition + _bottomRightOffset
                },
                6 => new[]
                {
                    basePosition + _bottomOffset, 
                    basePosition + _topOffset, 
                    basePosition + _topRightOffset,
                    basePosition + _bottomRightOffset
                },
                9 => new[]
                {
                    basePosition + _bottomLeftOffset, 
                    basePosition + _topLeftOffset, 
                    basePosition + _topOffset,
                    basePosition + _bottomOffset
                },
                12 => new[]
                {
                    basePosition + _leftOffset, 
                    basePosition + _topLeftOffset, 
                    basePosition + _topRightOffset,
                    basePosition + _rightOffset
                },
                5 => new[] // note: ambiguous case
                {
                    basePosition + _bottomLeftOffset, 
                    basePosition + _leftOffset, 
                    basePosition + _topOffset,
                    basePosition + _topRightOffset, 
                    basePosition + _rightOffset, 
                    basePosition + _bottomOffset
                },
                10 => new[] // note: ambiguous case
                {
                    basePosition + _leftOffset, 
                    basePosition + _topLeftOffset, 
                    basePosition + _topOffset,
                    basePosition + _rightOffset, 
                    basePosition + _bottomRightOffset, 
                    basePosition + _bottomOffset
                },
                
                // 3 point:
                7 => new[]
                {
                    basePosition + _bottomLeftOffset, 
                    basePosition + _leftOffset, 
                    basePosition + _topOffset,
                    basePosition + _topRightOffset, 
                    basePosition + _bottomRightOffset
                },
                11 => new[]
                {
                    basePosition + _bottomLeftOffset, 
                    basePosition + _topLeftOffset, 
                    basePosition + _topOffset,
                    basePosition + _rightOffset, 
                    basePosition + _bottomRightOffset
                },
                13 => new[]
                {
                    basePosition + _bottomLeftOffset, 
                    basePosition + _topLeftOffset, 
                    basePosition + _topRightOffset,
                    basePosition + _rightOffset, 
                    basePosition + _bottomOffset
                },
                14 => new[]
                {
                    basePosition + _leftOffset, 
                    basePosition + _topLeftOffset, 
                    basePosition + _topRightOffset,
                    basePosition + _bottomRightOffset, 
                    basePosition + _bottomOffset
                },
                
                //4 point:
                15 => new[]
                {
                    basePosition + _bottomLeftOffset, 
                    basePosition + _topLeftOffset, 
                    basePosition + _topRightOffset,
                    basePosition + _bottomRightOffset
                },
                _ => throw new ArgumentException()
            };
        }
    }
}