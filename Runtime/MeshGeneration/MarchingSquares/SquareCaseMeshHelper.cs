using System;
using UnityEngine;

namespace DJM.Utilities.MeshGeneration
{
    internal class SquareCaseMeshHelper
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
        
        public SquareCaseMeshHelper(float nodeSize, float height, float depth)
        {
            if(nodeSize <= 0) throw new ArgumentException("nodeSize must be > 0");
            if(height < 0) throw new ArgumentException("height must be >= 0");
            if(depth < 0) throw new ArgumentException("depth must be >= 0");
            
            var forwardOffset = Vector3.forward * nodeSize;
            var halfForwardOffset = forwardOffset * .5f;
            var rightOffset = Vector3.right * nodeSize;
            var halfRightOffset = rightOffset * .5f;
            
            var downOffset = Vector3.down * depth;
            
            
            _baseBackLeft = downOffset;
            _baseForwardLeft = forwardOffset + downOffset;
            _baseForwardRight = forwardOffset + rightOffset + downOffset;
            _baseBackRight = rightOffset + downOffset;
            
            _baseLeft =  halfForwardOffset + downOffset;
            _baseForward = forwardOffset + halfRightOffset + downOffset;
            _baseRight = rightOffset + halfForwardOffset + downOffset;
            _baseBack = halfRightOffset + downOffset;
            
            
            var upOffset = Vector3.up * height;
            
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
        
        public int[] CaseOneTriangles(int vertexIndexOffset)
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
        
        public Vector3[] CaseTwoVertices(Vector3 positionOffset)
        {
            return new[]
            {
                // base
                _baseBack + positionOffset,
                _baseBackRight + positionOffset,
                _baseRight + positionOffset,
                // top
                _topBack + positionOffset,
                _topRight + positionOffset,
                _topBackRight + positionOffset,
                // side
                _baseBack + positionOffset,
                _baseRight + positionOffset,
                _topRight + positionOffset,
                _topBack + positionOffset
            };
        }

        public int[] CaseTwoTriangles(int vertexIndexOffset)
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
        
        public Vector3[] CaseFourVertices(Vector3 positionOffset)
        {
            return Array.Empty<Vector3>();
        }

        public int[] CaseFourTriangles(int vertexIndexOffset)
        {
            return Array.Empty<int>();
        }
        
        public Vector3[] CaseEightVertices(Vector3 positionOffset)
        {
            return Array.Empty<Vector3>();
        }

        public int[] CaseEightTriangles(int vertexIndexOffset)
        {
            return Array.Empty<int>();
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

        public int[] CaseThreeTriangles(int vertexIndexOffset)
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
        
        public Vector3[] CaseSixVertices(Vector3 positionOffset)
        {
            return Array.Empty<Vector3>();
        }

        public int[] CaseSixTriangles(int vertexIndexOffset)
        {
            return Array.Empty<int>();
        }
        
        public Vector3[] CaseNineVertices(Vector3 positionOffset)
        {
            return Array.Empty<Vector3>();
        }

        public int[] CaseNineTriangles(int vertexIndexOffset)
        {
            return Array.Empty<int>();
        }
        
        public Vector3[] CaseTwelveVertices(Vector3 positionOffset)
        {
            return Array.Empty<Vector3>();
        }

        public int[] CaseTwelveTriangles(int vertexIndexOffset)
        {
            return Array.Empty<int>();
        }
        
        public Vector3[] CaseFiveVertices(Vector3 positionOffset) // ambiguous case
        {
            return Array.Empty<Vector3>();
        }

        public int[] CaseFiveTriangles(int vertexIndexOffset) // ambiguous case
        {
            return Array.Empty<int>();
        }
        
        public Vector3[] CaseTenVertices(Vector3 positionOffset) // ambiguous case
        {
            return Array.Empty<Vector3>();
        }

        public int[] CaseTenTriangles(int vertexIndexOffset) // ambiguous case
        {
            return Array.Empty<int>();
        }

#endregion

        #region 3Point

        public Vector3[] CaseSevenVertices(Vector3 positionOffset)
        {
            return Array.Empty<Vector3>();
        }

        public int[] CaseSevenTriangles(int vertexIndexOffset)
        {
            return Array.Empty<int>();
        }
        
        public Vector3[] CaseElevenVertices(Vector3 positionOffset)
        {
            return Array.Empty<Vector3>();
        }

        public int[] CaseElevenTriangles(int vertexIndexOffset)
        {
            return Array.Empty<int>();
        }

        public Vector3[] CaseThirteenVertices(Vector3 positionOffset)
        {
            return Array.Empty<Vector3>();
        }

        public int[] CaseThirteenTriangles(int vertexIndexOffset)
        {
            return Array.Empty<int>();
        }
        
        public Vector3[] CaseFourteenVertices(Vector3 positionOffset)
        {
            return Array.Empty<Vector3>();
        }

        public int[] CaseFourteenTriangles(int vertexIndexOffset)
        {
            return Array.Empty<int>();
        }
        
#endregion

        #region 4Point

        public Vector3[] CaseFifteenVertices(Vector3 positionOffset)
        {
            return Array.Empty<Vector3>();
        }

        public int[] CaseFifteenTriangles(int vertexIndexOffset)
        {
            return Array.Empty<int>();
        }

        #endregion
    }
}