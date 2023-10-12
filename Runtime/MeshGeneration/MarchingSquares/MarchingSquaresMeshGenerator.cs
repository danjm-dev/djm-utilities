using System.Collections.Generic;
using UnityEngine;

namespace DJM.Utilities.MeshGeneration.MarchingSquares
{
    public static class MarchingSquaresMeshGenerator
    {
        private static Vector3 _bottomLeftOffset;
        private static Vector3 _topLeftOffset;
        private static Vector3 _topRightOffset;
        private static Vector3 _bottomRightOffset;
        
        private static Vector3 _leftOffset;
        private static Vector3 _rightOffset;
        private static Vector3 _topOffset;
        private static Vector3 _bottomOffset;
        
        public static Mesh GenerateMesh(IReadOnlyList<bool> grid, int width, int height, float nodeSize)
        {
            var meshBuilder = new MarchingSquaresMeshBuilder();

            _bottomLeftOffset = Vector3.zero;
            _topLeftOffset = Vector3.forward * nodeSize;
            _bottomRightOffset = Vector3.right * nodeSize;
            _topRightOffset = _topLeftOffset + _bottomRightOffset;

            _leftOffset = _bottomLeftOffset + Vector3.forward * nodeSize * .5f;
            _rightOffset = _bottomRightOffset + Vector3.forward * nodeSize * .5f;
            _topOffset = _topLeftOffset + Vector3.right * nodeSize * .5f;
            _bottomOffset = _bottomLeftOffset + Vector3.right * nodeSize * .5f;
            
            
            // -1 on each axis to iterate through squares rather than voxels. i++ on y loop ensures i skips far right col.
            for (int z = 0, i = 0; z < height - 1; z++, i++)
            {
                for (var x = 0; x < width - 1; x++, i++)
                {
                    var config = CalculateConfig
                    (
                        grid[i],
                        grid[i + width],
                        grid[i + width + 1],
                        grid[i + 1]//.IsOpenSpace
                    );

                    var gridPositionOffset = new Vector3(x * nodeSize, 0, z * nodeSize);
                    Triangulate(config, gridPositionOffset, meshBuilder);
                }
            }

            var mesh = new Mesh();
            mesh.vertices = meshBuilder.Vertices;
            mesh.triangles = meshBuilder.Triangles;
            
            return mesh;
        }

        private static byte CalculateConfig(bool bottomLeftOpen, bool topLeftOpen, bool topRightOpen, bool bottomRightOpen)
        {
            byte configuration = 0;

            if (!topLeftOpen)
                configuration += 8;
            if (!topRightOpen)
                configuration += 4;
            if (!bottomRightOpen)
                configuration += 2;
            if (!bottomLeftOpen)
                configuration += 1;

            return configuration;
        }
        
        private static void Triangulate
        (
            byte configuration, 
            Vector3 basePosition, 
            MarchingSquaresMeshBuilder marchingSquaresMeshBuilder
        )
        {
            switch (configuration)
            {
                case 0:
                    break;

                // 1 points:
                case 1:
                    marchingSquaresMeshBuilder.TriangulateFace
                    (
                        basePosition + _bottomLeftOffset,
                        basePosition + _leftOffset,
                        basePosition + _bottomOffset
                    );
                    break;

                case 2:
                    marchingSquaresMeshBuilder.TriangulateFace
                    (
                        basePosition + _bottomOffset,
                        basePosition + _rightOffset,
                        basePosition + _bottomRightOffset
                    );
                    break;

                case 4:
                    marchingSquaresMeshBuilder.TriangulateFace
                    (
                        basePosition + _topOffset,
                        basePosition + _topRightOffset,
                        basePosition + _rightOffset
                    );
                    break;

                case 8:
                    marchingSquaresMeshBuilder.TriangulateFace
                    (
                        basePosition + _leftOffset,
                        basePosition + _topLeftOffset,
                        basePosition + _topOffset
                    );
                    break;

                // 2 points:
                case 3:
                    marchingSquaresMeshBuilder.TriangulateFace
                    (
                        basePosition + _bottomLeftOffset,
                        basePosition + _leftOffset,
                        basePosition + _rightOffset,
                        basePosition + _bottomRightOffset
                    );
                    break;
                
                 case 6:
                     marchingSquaresMeshBuilder.TriangulateFace
                     (
                         basePosition + _bottomOffset,
                         basePosition + _topOffset,
                         basePosition + _topRightOffset,
                         basePosition + _bottomRightOffset
                     );
                    break;
                
                case 9:
                    marchingSquaresMeshBuilder.TriangulateFace
                    (
                        basePosition + _bottomLeftOffset,
                        basePosition + _topLeftOffset,
                        basePosition + _topOffset,
                        basePosition + _bottomOffset
                    );
                    break;
                
                case 12:
                    marchingSquaresMeshBuilder.TriangulateFace
                    (
                        basePosition + _leftOffset,
                        basePosition + _topLeftOffset,
                        basePosition + _topRightOffset,
                        basePosition + _rightOffset
                    );
                    break;
                
                case 5: // note: ambiguous case
                    marchingSquaresMeshBuilder.TriangulateFace
                    (
                        basePosition + _bottomLeftOffset,
                        basePosition + _leftOffset,
                        basePosition + _topOffset,
                        basePosition + _topRightOffset,
                        basePosition + _rightOffset,
                        basePosition + _bottomOffset
                    );
                    break;

                case 10: // note: ambiguous case
                    marchingSquaresMeshBuilder.TriangulateFace
                    (
                        basePosition + _leftOffset,
                        basePosition + _topLeftOffset,
                        basePosition + _topOffset,
                        basePosition + _rightOffset,
                        basePosition + _bottomRightOffset,
                        basePosition + _bottomOffset
                    );
                    break;
                
                // // 3 point:
                case 7:
                    marchingSquaresMeshBuilder.TriangulateFace
                    (
                        basePosition + _bottomLeftOffset,
                        basePosition + _leftOffset,
                        basePosition + _topOffset,
                        basePosition + _topRightOffset,
                        basePosition + _bottomRightOffset
                    );
                    break;
                
                 case 11:
                     marchingSquaresMeshBuilder.TriangulateFace
                     (
                         basePosition + _bottomLeftOffset,
                         basePosition + _topLeftOffset,
                         basePosition + _topOffset,
                         basePosition + _rightOffset,
                         basePosition + _bottomRightOffset
                     );
                    break;
                
                case 13:
                    marchingSquaresMeshBuilder.TriangulateFace
                    (
                        basePosition + _bottomLeftOffset,
                        basePosition + _topLeftOffset,
                        basePosition + _topRightOffset,
                        basePosition + _rightOffset,
                        basePosition + _bottomOffset
                    );
                    break;
                
                case 14:
                    marchingSquaresMeshBuilder.TriangulateFace
                    (
                        basePosition + _leftOffset,
                        basePosition + _topLeftOffset,
                        basePosition + _topRightOffset,
                        basePosition + _bottomRightOffset,
                        basePosition + _bottomOffset
                    );
                    break;
                
                // //4 point:
                case 15:
                    marchingSquaresMeshBuilder.TriangulateFace
                    (
                        basePosition + _bottomLeftOffset,
                        basePosition + _topLeftOffset,
                        basePosition + _topRightOffset,
                        basePosition + _bottomRightOffset
                    );
                    break;
            }
        }
    }
}