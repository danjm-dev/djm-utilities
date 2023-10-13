using System;
using UnityEngine;

namespace DJM.Utilities.MeshGeneration
{
    internal class SquareMeshGenerator
    {
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
        
        public SquareMeshGenerator(float nodeSize, float heightOffset, float depthOffset)
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
        
        public int[] GetTriangles(byte squareCase, int vertexIndexOffset)
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
        
        #region 0Point

        public Vector3[] CaseZeroVertices(Vector3 positionOffset)
        {
            return Array.Empty<Vector3>();
        }

        public int[] CaseZeroTriangles(int vertexIndexOffset)
        {
            return Array.Empty<int>();
        }

        #endregion

        #region 1Point

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
        
        public static int[] CaseOneTriangles(int vertexIndexOffset) => OnePointCaseTriangles(vertexIndexOffset);
        public static int[] CaseTwoTriangles(int vertexIndexOffset) => OnePointCaseTriangles(vertexIndexOffset);
        public static int[] CaseFourTriangles(int vertexIndexOffset) => OnePointCaseTriangles(vertexIndexOffset);
        public static int[] CaseEightTriangles(int vertexIndexOffset) => OnePointCaseTriangles(vertexIndexOffset);
        
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

        #region 2Point

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
        
        public static int[] CaseThreeTriangles(int vertexIndexOffset) => TwoPointCaseTriangles(vertexIndexOffset);
        public static int[] CaseSixTriangles(int vertexIndexOffset) => TwoPointCaseTriangles(vertexIndexOffset);
        public static int[] CaseNineTriangles(int vertexIndexOffset) => TwoPointCaseTriangles(vertexIndexOffset);
        public static int[] CaseTwelveTriangles(int vertexIndexOffset) => TwoPointCaseTriangles(vertexIndexOffset);
        
        private static int[] TwoPointCaseTriangles(int vertexIndexOffset)
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

#endregion

        #region 2PointAmbiguous

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
                _baseRight + positionOffset,
                _topRight + positionOffset,
                _topLeft + positionOffset,
                // side2
                _baseRight + positionOffset,
                _baseLeft + positionOffset,
                _topLeft + positionOffset,
                _topRight + positionOffset
            };
        }
        
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
        
        public static int[] CaseFiveTriangles(int vertexIndexOffset) => TwoPointAmbiguousCaseTriangles(vertexIndexOffset);
        public static int[] CaseTenTriangles(int vertexIndexOffset) => TwoPointAmbiguousCaseTriangles(vertexIndexOffset);
        
        private static int[] TwoPointAmbiguousCaseTriangles(int vertexIndexOffset)
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

        #region 3Point

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

        public static int[] CaseSevenTriangles(int vertexIndexOffset) => ThreePointCaseTriangles(vertexIndexOffset);
        public static int[] CaseElevenTriangles(int vertexIndexOffset) => ThreePointCaseTriangles(vertexIndexOffset);
        public static int[] CaseThirteenTriangles(int vertexIndexOffset) => ThreePointCaseTriangles(vertexIndexOffset);
        public static int[] CaseFourteenTriangles(int vertexIndexOffset) => ThreePointCaseTriangles(vertexIndexOffset);
        
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

        #region 4Point

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

        #endregion
    }
}