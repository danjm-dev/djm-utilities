using System;
using System.Collections.Generic;
using UnityEngine;

namespace DJM.Utilities.MeshGeneration
{
    public static class MarchingSquaresMesh
    {
        public static Mesh Create(bool[] grid, int width, int height, float nodeSize, float depth = 0f)
        {
            if (grid.Length != width * height) throw new ArgumentException("grid length does not match width * height");
            var marchingSquareConfig = CalculateSquareData(grid, width, height, nodeSize);
            return MarchingSquaresMeshGenerator.Generate(nodeSize, depth, marchingSquareConfig);
        }

        private static MarchingSquareData[] CalculateSquareData(IReadOnlyList<bool> grid, int width, int height, float nodeSize)
        {
            var marchingSquareConfig = new List<MarchingSquareData>();
            
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
                        grid[i + 1]
                    );

                    var gridPositionOffset = new Vector3(x * nodeSize, 0, z * nodeSize);
                    marchingSquareConfig.Add(new MarchingSquareData(gridPositionOffset, config));
                }
            }

            return marchingSquareConfig.ToArray();
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