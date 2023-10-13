using System;
using UnityEngine;

namespace DJM.Utilities.MeshGeneration
{
    internal class MarchingSquaresCaseHelper
    {
        private static readonly Vector3 ForwardRightNormal = (Vector3.forward + Vector3.right).normalized;
        private static readonly Vector3 ForwardLeftNormal = (Vector3.forward + Vector3.left).normalized;
        private static readonly Vector3 BackRightNormal = (Vector3.back + Vector3.right).normalized;
        private static readonly Vector3 BackLeftNormal = (Vector3.back + Vector3.left).normalized;
        
        
        private readonly Vector3 _baseBackLeft;
        private readonly Vector3 _baseForwardLeft;
        private readonly Vector3 _baseForwardRight;
        private readonly Vector3 _baseBackRight;
        
        private readonly Vector3 _baseLeft;
        private readonly Vector3 _baseForward;
        private readonly Vector3 _baseRight;
        private readonly Vector3 _baseBack;
        
        
        private readonly Vector3 _topBackLeft;
        private readonly Vector3 _topForwardLeft;
        private readonly Vector3 _topForwardRight;
        private readonly Vector3 _topBackRight;
        
        private readonly Vector3 _topLeft;
        private readonly Vector3 _topForward;
        private readonly Vector3 _topRight;
        private readonly Vector3 _topBack;
        
        public MarchingSquaresCaseHelper(float nodeSize, float heightOffset, float depthOffset)
        {
            if(nodeSize <= 0) throw new ArgumentException("nodeSize must be > 0");
            if(heightOffset < 0) throw new ArgumentException("height must be >= 0");
            if(depthOffset < 0) throw new ArgumentException("depth must be >= 0");
            
            var forwardOffset = Vector3.forward * nodeSize;
            var halfForwardOffset = forwardOffset * .5f;
            var rightOffset = Vector3.right * nodeSize;
            var halfRightOffset = rightOffset * .5f;
            
            var downOffset = Vector3.down * depthOffset;
            
            
            _baseBackLeft = downOffset;
            _baseForwardLeft = forwardOffset + downOffset;
            _baseForwardRight = forwardOffset + rightOffset + downOffset;
            _baseBackRight = rightOffset + downOffset;
            
            _baseLeft =  halfForwardOffset + downOffset;
            _baseForward = forwardOffset + halfRightOffset + downOffset;
            _baseRight = rightOffset + halfForwardOffset + downOffset;
            _baseBack = halfRightOffset + downOffset;
            
            
            var upOffset = Vector3.up * heightOffset;
            
            _topBackLeft = upOffset;
            _topForwardLeft = forwardOffset + upOffset;
            _topForwardRight = forwardOffset + rightOffset + upOffset;
            _topBackRight = rightOffset + upOffset;
            
            _topLeft =  halfForwardOffset + upOffset;
            _topForward = forwardOffset + halfRightOffset + upOffset;
            _topRight = rightOffset + halfForwardOffset + upOffset;
            _topBack = halfRightOffset + upOffset;
        }

        public Vector3[] GetVertices(byte squareCase, Vector3 positionOffset)
        {
            return squareCase switch
            {
                0 => CaseZeroVertices(positionOffset),
                1 => CaseOneVertices(positionOffset),
                2 => CaseTwoVertices(positionOffset),
                3 => CaseThreeVertices(positionOffset),
                4 => CaseFourVertices(positionOffset),
                5 => CaseFiveVertices(positionOffset),
                6 => CaseSixVertices(positionOffset),
                7 => CaseSevenVertices(positionOffset),
                8 => CaseEightVertices(positionOffset),
                9 => CaseNineVertices(positionOffset),
                10 => CaseTenVertices(positionOffset),
                11 => CaseElevenVertices(positionOffset),
                12 => CaseTwelveVertices(positionOffset),
                13 => CaseThirteenVertices(positionOffset),
                14 => CaseFourteenVertices(positionOffset),
                15 => CaseFifteenVertices(positionOffset),
                _ => throw new ArgumentException("squareCase must be between 0 and 16 inclusive")
            };
        }
        
        public static Vector3[] GetNormals(byte squareCase)
        {
            return squareCase switch
            {
                0 => CaseZeroNormals(),
                1 => CaseOneNormals(),
                2 => CaseTwoNormals(),
                3 => CaseThreeNormals(),
                4 => CaseFourNormals(),
                5 => CaseFiveNormals(),
                6 => CaseSixNormals(),
                7 => CaseSevenNormals(),
                8 => CaseEightNormals(),
                9 => CaseNineNormals(),
                10 => CaseTenNormals(),
                11 => CaseElevenNormals(),
                12 => CaseTwelveNormals(),
                13 => CaseThirteenNormals(),
                14 => CaseFourteenNormals(),
                15 => CaseFifteenNormals(),
                _ => throw new ArgumentException("squareCase must be between 0 and 16 inclusive")
            };
        }
        
        public static int[] GetTriangles(byte squareCase, int vertexIndexOffset)
        {
            return squareCase switch
            {
                0 => CaseZeroTriangles(vertexIndexOffset),
                1 => CaseOneTriangles(vertexIndexOffset),
                2 => CaseTwoTriangles(vertexIndexOffset),
                3 => CaseThreeTriangles(vertexIndexOffset),
                4 => CaseFourTriangles(vertexIndexOffset),
                5 => CaseFiveTriangles(vertexIndexOffset),
                6 => CaseSixTriangles(vertexIndexOffset),
                7 => CaseSevenTriangles(vertexIndexOffset),
                8 => CaseEightTriangles(vertexIndexOffset),
                9 => CaseNineTriangles(vertexIndexOffset),
                10 => CaseTenTriangles(vertexIndexOffset),
                11 => CaseElevenTriangles(vertexIndexOffset),
                12 => CaseTwelveTriangles(vertexIndexOffset),
                13 => CaseThirteenTriangles(vertexIndexOffset),
                14 => CaseFourteenTriangles(vertexIndexOffset),
                15 => CaseFifteenTriangles(vertexIndexOffset),
                _ => throw new ArgumentException("squareCase must be between 0 and 16 inclusive")
            };
        }
        
        // 0 Point
        
        #region Case0

        public Vector3[] CaseZeroVertices(Vector3 positionOffset)
        {
            return Array.Empty<Vector3>();
        }

        public static int[] CaseZeroTriangles(int vertexIndexOffset)
        {
            return Array.Empty<int>();
        }
        
        public static Vector3[] CaseZeroNormals()
        {
            return Array.Empty<Vector3>();
        }

        #endregion
        
        // 1 Point
        
        #region Case1

        public Vector3[] CaseOneVertices(Vector3 positionOffset)
        {
            return new[]
            {
                // base
                _baseBackLeft + positionOffset, 
                _baseBack + positionOffset, 
                _baseLeft + positionOffset, 
                // top
                _topBackLeft + positionOffset, 
                _topLeft + positionOffset, 
                _topBack + positionOffset, 
                // side
                _baseLeft + positionOffset, 
                _baseBack + positionOffset, 
                _topBack + positionOffset,
                _topLeft + positionOffset 
            };
        }

        public static int[] CaseOneTriangles(int vertexIndexOffset) => OnePointCaseTriangles(vertexIndexOffset);
        
        public static Vector3[] CaseOneNormals()
        {
            return new[]
            {
                // base
                Vector3.down, 
                Vector3.down, 
                Vector3.down, 
                // top
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                // side
                ForwardRightNormal, 
                ForwardRightNormal, 
                ForwardRightNormal, 
                ForwardRightNormal 
            };
        }

        #endregion

        #region Case2

        public Vector3[] CaseTwoVertices(Vector3 positionOffset)
        {
            return new[]
            {
                // base
                _baseBackRight + positionOffset, 
                _baseRight + positionOffset, 
                _baseBack + positionOffset, 
                // top
                _topBackRight + positionOffset, 
                _topBack + positionOffset, 
                _topRight + positionOffset, 
                // side
                _baseBack + positionOffset, 
                _baseRight + positionOffset, 
                _topRight + positionOffset, 
                _topBack + positionOffset 
            };
        }
        
        public static int[] CaseTwoTriangles(int vertexIndexOffset) => OnePointCaseTriangles(vertexIndexOffset);
        
        public static Vector3[] CaseTwoNormals()
        {
            return new[]
            {
                // base
                Vector3.down, 
                Vector3.down, 
                Vector3.down,
                // top
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                // side
                ForwardLeftNormal, 
                ForwardLeftNormal, 
                ForwardLeftNormal, 
                ForwardLeftNormal
            };
        }

        #endregion

        #region Case4

        public Vector3[] CaseFourVertices(Vector3 positionOffset)
        {
            return new[]
            {
                // base
                _baseForwardRight + positionOffset, 
                _baseForward + positionOffset, 
                _baseRight + positionOffset,
                // top
                _topForwardRight + positionOffset, 
                _topRight + positionOffset, 
                _topForward + positionOffset, 
                // side
                _baseRight + positionOffset, 
                _baseForward + positionOffset, 
                _topForward + positionOffset, 
                _topRight + positionOffset
            };
        }
        
        public static int[] CaseFourTriangles(int vertexIndexOffset) => OnePointCaseTriangles(vertexIndexOffset);
        
        public static Vector3[] CaseFourNormals()
        {
            return new[]
            {
                // base
                Vector3.down, 
                Vector3.down, 
                Vector3.down, 
                // top
                Vector3.up, 
                Vector3.up, 
                Vector3.up,
                // side
                BackLeftNormal, 
                BackLeftNormal, 
                BackLeftNormal, 
                BackLeftNormal 
            };
        }

        #endregion

        #region Case8

        public Vector3[] CaseEightVertices(Vector3 positionOffset)
        {
            return new[]
            {
                // base
                _baseForwardLeft + positionOffset, 
                _baseLeft + positionOffset, 
                _baseForward + positionOffset, 
                // top
                _topForwardLeft + positionOffset, 
                _topForward + positionOffset, 
                _topLeft + positionOffset, 
                // side
                _baseForward + positionOffset, 
                _baseLeft + positionOffset, 
                _topLeft + positionOffset, 
                _topForward + positionOffset 
            };
        }
        
        public static int[] CaseEightTriangles(int vertexIndexOffset) => OnePointCaseTriangles(vertexIndexOffset);
        
        public static Vector3[] CaseEightNormals()
        {
            return new[]
            {
                // base
                Vector3.down, 
                Vector3.down, 
                Vector3.down,
                // top
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                // side
                BackRightNormal, 
                BackRightNormal, 
                BackRightNormal, 
                BackRightNormal
            };
        }

        #endregion
        
        #region 1PointCommon
        private static int[] OnePointCaseTriangles(int vertexIndexOffset)
        {
            return new[]
            {
                // base
                0 + vertexIndexOffset, 
                1 + vertexIndexOffset,
                2 + vertexIndexOffset,
                // top
                3 + vertexIndexOffset, 
                4 + vertexIndexOffset, 
                5 + vertexIndexOffset,
                // side
                6 + vertexIndexOffset, 
                7 + vertexIndexOffset, 
                8 + vertexIndexOffset,
                6 + vertexIndexOffset, 
                8 + vertexIndexOffset, 
                9 + vertexIndexOffset,
            };
        }

        #endregion
        
        // 2 Point

        #region Case3

        public Vector3[] CaseThreeVertices(Vector3 positionOffset)
        {
            return new[]
            {
                // base
                _baseBackLeft + positionOffset, 
                _baseBackRight + positionOffset, 
                _baseRight + positionOffset, 
                _baseLeft + positionOffset,
                // top
                _topBackLeft + positionOffset, 
                _topLeft + positionOffset,
                _topRight + positionOffset,
                _topBackRight + positionOffset,
                // side
                _baseLeft + positionOffset,
                _baseRight + positionOffset,
                _topRight + positionOffset,
                _topLeft + positionOffset
            };
        }
        
        public static int[] CaseThreeTriangles(int vertexIndexOffset) => OrthogonalTwoPointCaseTriangles(vertexIndexOffset);
        
        public static Vector3[] CaseThreeNormals()
        {
            return new[]
            {
                // base
                Vector3.down, 
                Vector3.down, 
                Vector3.down, 
                Vector3.down,
                // top
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                // side
                Vector3.forward, 
                Vector3.forward, 
                Vector3.forward, 
                Vector3.forward
            };
        }

        #endregion

        #region Case6

        public Vector3[] CaseSixVertices(Vector3 positionOffset)
        {
            return new[]
            {
                // base
                _baseBackRight + positionOffset,
                _baseForwardRight + positionOffset,
                _baseForward + positionOffset,
                _baseBack + positionOffset,
                // top
                _topBackRight + positionOffset,
                _topBack + positionOffset,
                _topForward + positionOffset,
                _topForwardRight + positionOffset,
                // side
                _baseBack + positionOffset,
                _baseForward + positionOffset,
                _topForward + positionOffset,
                _topBack + positionOffset
            };
        }
        
        public static int[] CaseSixTriangles(int vertexIndexOffset) => OrthogonalTwoPointCaseTriangles(vertexIndexOffset);
        
        public static Vector3[] CaseSixNormals()
        {
            return new[]
            {
                // base
                Vector3.down, 
                Vector3.down, 
                Vector3.down, 
                Vector3.down,
                // top
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                // side
                Vector3.left, 
                Vector3.left, 
                Vector3.left, 
                Vector3.left
            };
        }

        #endregion

        #region Case9

        public Vector3[] CaseNineVertices(Vector3 positionOffset)
        {
            return new[]
            {
                // base
                _baseForwardLeft + positionOffset,
                _baseBackLeft + positionOffset,
                _baseBack + positionOffset,
                _baseForward + positionOffset,
                // top
                _topForwardLeft + positionOffset,
                _topForward + positionOffset,
                _topBack + positionOffset,
                _topBackLeft + positionOffset,
                // side
                _baseForward + positionOffset,
                _baseBack + positionOffset,
                _topBack + positionOffset,
                _topForward + positionOffset
            };
        }
        
        public static int[] CaseNineTriangles(int vertexIndexOffset) => OrthogonalTwoPointCaseTriangles(vertexIndexOffset);
        
        public static Vector3[] CaseNineNormals()
        {
            return new[]
            {
                // base
                Vector3.down, 
                Vector3.down, 
                Vector3.down, 
                Vector3.down,
                // top
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                // side
                Vector3.right, 
                Vector3.right, 
                Vector3.right, 
                Vector3.right
            };
        }

        #endregion

        #region Case12

        public Vector3[] CaseTwelveVertices(Vector3 positionOffset)
        {
            return new[]
            {
                // base
                _baseForwardRight + positionOffset,
                _baseForwardLeft + positionOffset,
                _baseLeft + positionOffset,
                _baseRight + positionOffset,
                // top
                _topForwardRight + positionOffset,
                _topRight + positionOffset,
                _topLeft + positionOffset,
                _topForwardLeft + positionOffset,
                // side
                _baseRight + positionOffset,
                _baseLeft + positionOffset,
                _topLeft + positionOffset,
                _topRight + positionOffset
            };
        }
        
        public static int[] CaseTwelveTriangles(int vertexIndexOffset) => OrthogonalTwoPointCaseTriangles(vertexIndexOffset);
        
        public static Vector3[] CaseTwelveNormals()
        {
            return new[]
            {
                // base
                Vector3.down, 
                Vector3.down, 
                Vector3.down, 
                Vector3.down,
                // top
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                // side
                Vector3.back, 
                Vector3.back, 
                Vector3.back, 
                Vector3.back
            };
        }

        #endregion
        
        #region Case5
        
        public Vector3[] CaseFiveVertices(Vector3 positionOffset)
        {
            return new[]
            {
                // base
                _baseBackLeft + positionOffset,
                _baseBack + positionOffset,
                _baseRight + positionOffset,
                _baseForwardRight + positionOffset,
                _baseForward + positionOffset,
                _baseLeft + positionOffset,
                // top
                _topBackLeft + positionOffset,
                _topLeft + positionOffset,
                _topForward + positionOffset,
                _topForwardRight + positionOffset,
                _topRight + positionOffset,
                _topBack + positionOffset,
                // side1
                _baseLeft + positionOffset,
                _baseForward + positionOffset,
                _topForward + positionOffset,
                _topLeft + positionOffset,
                // side2
                _baseRight + positionOffset,
                _baseBack + positionOffset,
                _topBack + positionOffset,
                _topRight + positionOffset
            };
        }
        
        public static int[] CaseFiveTriangles(int vertexIndexOffset) => DiagonalTwoPointCaseTriangles(vertexIndexOffset);
        
        public static Vector3[] CaseFiveNormals()
        {
            return new[]
            {
                // base
                Vector3.down, 
                Vector3.down, 
                Vector3.down, 
                Vector3.down,
                Vector3.down,
                Vector3.down,
                // top
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                // side1
                ForwardLeftNormal, 
                ForwardLeftNormal, 
                ForwardLeftNormal, 
                ForwardLeftNormal,
                // side2
                BackRightNormal,
                BackRightNormal,
                BackRightNormal,
                BackRightNormal
            };
        }
        
        #endregion

        #region Case10

        public Vector3[] CaseTenVertices(Vector3 positionOffset)
        {
            return new[]
            {
                // base
                _baseForwardLeft + positionOffset,
                _baseLeft + positionOffset,
                _baseBack + positionOffset,
                _baseBackRight + positionOffset,
                _baseRight + positionOffset,
                _baseForward + positionOffset,
                // top
                _topForwardLeft + positionOffset,
                _topForward + positionOffset,
                _topRight + positionOffset,
                _topBackRight + positionOffset,
                _topBack + positionOffset,
                _topLeft + positionOffset,
                // side1
                _baseBack + positionOffset,
                _baseLeft + positionOffset,
                _topLeft + positionOffset,
                _topBack + positionOffset,
                // side2
                _baseForward + positionOffset,
                _baseRight + positionOffset,
                _topRight + positionOffset,
                _topForward + positionOffset
            };
        }
        
        
        public static int[] CaseTenTriangles(int vertexIndexOffset) => DiagonalTwoPointCaseTriangles(vertexIndexOffset);
        
        public static Vector3[] CaseTenNormals()
        {
            return new[]
            {
                // base
                Vector3.down, 
                Vector3.down, 
                Vector3.down, 
                Vector3.down,
                Vector3.down,
                Vector3.down,
                // top
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                // side1
                BackLeftNormal, 
                BackLeftNormal, 
                BackLeftNormal, 
                BackLeftNormal,
                // side2
                ForwardRightNormal,
                ForwardRightNormal,
                ForwardRightNormal,
                ForwardRightNormal
            };
        }

        #endregion
        
        #region 2PointCommon
        
        private static int[] OrthogonalTwoPointCaseTriangles(int vertexIndexOffset)
        {
            return new[]
            {
                // base
                0 + vertexIndexOffset, 
                1 + vertexIndexOffset,
                2 + vertexIndexOffset,
                0 + vertexIndexOffset,
                2 + vertexIndexOffset,
                3 + vertexIndexOffset,
                // top
                4 + vertexIndexOffset, 
                5 + vertexIndexOffset, 
                6 + vertexIndexOffset,
                4 + vertexIndexOffset, 
                6 + vertexIndexOffset, 
                7 + vertexIndexOffset, 
                // side
                8 + vertexIndexOffset, 
                9 + vertexIndexOffset, 
                10 + vertexIndexOffset,
                8 + vertexIndexOffset, 
                10 + vertexIndexOffset, 
                11 + vertexIndexOffset,
            };
        }
        
        private static int[] DiagonalTwoPointCaseTriangles(int vertexIndexOffset)
        {
            return new[]
            {
                // base
                0 + vertexIndexOffset, 
                1 + vertexIndexOffset,
                5 + vertexIndexOffset,
                1 + vertexIndexOffset,
                4 + vertexIndexOffset,
                5 + vertexIndexOffset,
                1 + vertexIndexOffset, 
                2 + vertexIndexOffset,
                4 + vertexIndexOffset,
                2 + vertexIndexOffset,
                3 + vertexIndexOffset,
                4 + vertexIndexOffset,
                // top
                6 + vertexIndexOffset, 
                7 + vertexIndexOffset,
                11 + vertexIndexOffset,
                7 + vertexIndexOffset,
                10 + vertexIndexOffset,
                11 + vertexIndexOffset,
                7 + vertexIndexOffset, 
                8 + vertexIndexOffset,
                10 + vertexIndexOffset,
                8 + vertexIndexOffset,
                9 + vertexIndexOffset,
                10 + vertexIndexOffset,
                // side
                12 + vertexIndexOffset, 
                13 + vertexIndexOffset, 
                14 + vertexIndexOffset,
                12 + vertexIndexOffset, 
                14 + vertexIndexOffset, 
                15 + vertexIndexOffset,
                16 + vertexIndexOffset, 
                17 + vertexIndexOffset, 
                18 + vertexIndexOffset,
                16 + vertexIndexOffset, 
                18 + vertexIndexOffset, 
                19 + vertexIndexOffset,
            };
        }

#endregion

        // 3 Point

        #region Case7

        public Vector3[] CaseSevenVertices(Vector3 positionOffset)
        {
            return new[]
            {
                // base
                _baseBackRight + positionOffset,
                _baseForwardRight + positionOffset,
                _baseForward + positionOffset,
                _baseLeft + positionOffset,
                _baseBackLeft + positionOffset,
                // top
                _topBackRight + positionOffset,
                _topBackLeft + positionOffset,
                _topLeft + positionOffset,
                _topForward + positionOffset,
                _topForwardRight + positionOffset,
                // side
                _baseLeft + positionOffset,
                _baseForward + positionOffset,
                _topForward + positionOffset,
                _topLeft + positionOffset
            };
        }
        
        public static int[] CaseSevenTriangles(int vertexIndexOffset) => ThreePointCaseTriangles(vertexIndexOffset);
        
        public static Vector3[] CaseSevenNormals()
        {
            return new[]
            {
                // base
                Vector3.down, 
                Vector3.down, 
                Vector3.down,
                Vector3.down, 
                Vector3.down,
                // top
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                // side
                ForwardLeftNormal, 
                ForwardLeftNormal, 
                ForwardLeftNormal, 
                ForwardLeftNormal
            };
        }

        #endregion

        #region Case11

        public Vector3[] CaseElevenVertices(Vector3 positionOffset)
        {
            return new[]
            {
                // base
                _baseBackLeft + positionOffset,
                _baseBackRight + positionOffset,
                _baseRight + positionOffset,
                _baseForward + positionOffset,
                _baseForwardLeft + positionOffset,
                // top
                _topBackLeft + positionOffset,
                _topForwardLeft + positionOffset,
                _topForward + positionOffset,
                _topRight + positionOffset,
                _topBackRight + positionOffset,
                // side
                _baseForward + positionOffset,
                _baseRight + positionOffset,
                _topRight + positionOffset,
                _topForward + positionOffset
            };
        }
        
        public static int[] CaseElevenTriangles(int vertexIndexOffset) => ThreePointCaseTriangles(vertexIndexOffset);

        public static Vector3[] CaseElevenNormals()
        {
            return new[]
            {
                // base
                Vector3.down, 
                Vector3.down, 
                Vector3.down,
                Vector3.down, 
                Vector3.down,
                // top
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                // side
                ForwardRightNormal, 
                ForwardRightNormal, 
                ForwardRightNormal, 
                ForwardRightNormal
            };
        }
        
        #endregion

        #region Case13

        public Vector3[] CaseThirteenVertices(Vector3 positionOffset)
        {
            return new[]
            {
                // base
                _baseForwardLeft + positionOffset,
                _baseBackLeft + positionOffset,
                _baseBack + positionOffset,
                _baseRight + positionOffset,
                _baseForwardRight + positionOffset,
                // top
                _topForwardLeft + positionOffset,
                _topForwardRight + positionOffset,
                _topRight + positionOffset,
                _topBack + positionOffset,
                _topBackLeft + positionOffset,
                // side
                _baseRight + positionOffset,
                _baseBack + positionOffset,
                _topBack + positionOffset,
                _topRight + positionOffset
            };
        }
        
        public static int[] CaseThirteenTriangles(int vertexIndexOffset) => ThreePointCaseTriangles(vertexIndexOffset);
        
        public static Vector3[] CaseThirteenNormals()
        {
            return new[]
            {
                // base
                Vector3.down, 
                Vector3.down, 
                Vector3.down,
                Vector3.down, 
                Vector3.down,
                // top
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                // side
                BackRightNormal, 
                BackRightNormal, 
                BackRightNormal, 
                BackRightNormal
            };
        }

        #endregion

        #region Case14

        public Vector3[] CaseFourteenVertices(Vector3 positionOffset)
        {
            return new[]
            {
                // base
                _baseForwardRight + positionOffset,
                _baseForwardLeft + positionOffset,
                _baseLeft + positionOffset,
                _baseBack + positionOffset,
                _baseBackRight + positionOffset,
                // top
                _topForwardRight + positionOffset,
                _topBackRight + positionOffset,
                _topBack + positionOffset,
                _topLeft + positionOffset,
                _topForwardLeft + positionOffset,
                // side
                _baseBack + positionOffset,
                _baseLeft + positionOffset,
                _topLeft + positionOffset,
                _topBack + positionOffset
            };
        }
        
        public static int[] CaseFourteenTriangles(int vertexIndexOffset) => ThreePointCaseTriangles(vertexIndexOffset);
        
        public static Vector3[] CaseFourteenNormals()
        {
            return new[]
            {
                // base
                Vector3.down, 
                Vector3.down, 
                Vector3.down,
                Vector3.down, 
                Vector3.down,
                // top
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                // side
                BackLeftNormal, 
                BackLeftNormal, 
                BackLeftNormal, 
                BackLeftNormal
            };
        }

        #endregion
        
        #region 3PointCommon
        
        private static int[] ThreePointCaseTriangles(int vertexIndexOffset)
        {
            return new[]
            {
                // base
                0 + vertexIndexOffset, 
                1 + vertexIndexOffset,
                2 + vertexIndexOffset,
                0 + vertexIndexOffset,
                2 + vertexIndexOffset,
                3 + vertexIndexOffset,
                0 + vertexIndexOffset,
                3 + vertexIndexOffset,
                4 + vertexIndexOffset,
                // top
                5 + vertexIndexOffset, 
                6 + vertexIndexOffset, 
                7 + vertexIndexOffset,
                5 + vertexIndexOffset, 
                7 + vertexIndexOffset, 
                8 + vertexIndexOffset, 
                5 + vertexIndexOffset, 
                8 + vertexIndexOffset, 
                9 + vertexIndexOffset, 
                // side
                10 + vertexIndexOffset, 
                11 + vertexIndexOffset, 
                12 + vertexIndexOffset,
                10 + vertexIndexOffset, 
                12 + vertexIndexOffset, 
                13 + vertexIndexOffset,
            };
        }
        
#endregion

        // 4 Point

        #region Case15

        public Vector3[] CaseFifteenVertices(Vector3 positionOffset)
        {
            return new[]
            {
                // base
                _baseBackLeft + positionOffset,
                _baseBackRight + positionOffset,
                _baseForwardRight + positionOffset,
                _baseForwardLeft + positionOffset,
                // top
                _topBackLeft + positionOffset,
                _topForwardLeft + positionOffset,
                _topForwardRight + positionOffset,
                _topBackRight + positionOffset,
            };
        }

        public static int[] CaseFifteenTriangles(int vertexIndexOffset)
        {
            return new[]
            {
                // base
                0 + vertexIndexOffset, 
                1 + vertexIndexOffset,
                2 + vertexIndexOffset,
                0 + vertexIndexOffset, 
                2 + vertexIndexOffset, 
                3 + vertexIndexOffset, 
                // top
                4 + vertexIndexOffset, 
                5 + vertexIndexOffset,
                6 + vertexIndexOffset,
                4 + vertexIndexOffset, 
                6 + vertexIndexOffset, 
                7 + vertexIndexOffset
            };
        }
        
        public static Vector3[] CaseFifteenNormals()
        {
            return new[]
            {
                // base
                Vector3.down, 
                Vector3.down, 
                Vector3.down,
                Vector3.down, 
                // top
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
                Vector3.up, 
            };
        }

        #endregion
    }
}