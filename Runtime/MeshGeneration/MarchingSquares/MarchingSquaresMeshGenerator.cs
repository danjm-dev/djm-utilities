using System.Collections.Generic;
using UnityEngine;

namespace DJM.Utilities.MeshGeneration
{
    internal static class MarchingSquaresMeshGenerator
    {
        public static Mesh Generate(float nodeSize, float depth, MarchingSquareData[] gridConfig)
        {
            var squareCaseMeshHelper = new SquareMeshGenerator(nodeSize, depth, depth);
            
            var vertices = new List<Vector3>();
            var triangles = new List<int>();

            foreach (var square in gridConfig)
            {
                if(square.Config == 0) continue;
                triangles.AddRange(squareCaseMeshHelper.GetTriangles(square.Config, vertices.Count));
                vertices.AddRange(squareCaseMeshHelper.GetVertices(square.Config, square.BasePosition));
            }
            
            // create mesh
            var mesh = new Mesh();
            mesh.vertices = vertices.ToArray();
            mesh.triangles = triangles.ToArray();
            mesh.RecalculateNormals();
            return mesh;
        }

        // private static void GetSquareVertices
        // (
        //     MarchingSquareData squareData, 
        //     Vector3 widthOffset, 
        //     Vector3 heightOffset, 
        //     Vector3 depthOffset, 
        //     List<Vector3> vertices, 
        //     List<TriangulationData> triangulationBuffer
        // )
        // {
        //     var basePosition = squareData.BasePosition;
        //     var firstIndex = vertices.Count;
        //     
        //     switch (squareData.Config)
        //     {
        //         case 0:
        //             break;
        //
        //         // 1 points:
        //         case 1:
        //             // top face
        //             var caseOneTopFace = new[]
        //             {
        //                 basePosition,
        //                 basePosition + _leftOffset,
        //                 basePosition + _bottomOffset
        //             };
        //             vertices.AddRange(caseOneTopFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             // bottom face
        //             firstIndex = vertices.Count;
        //             var caseOneBottomFace = new[]
        //             {
        //                 basePosition + depthOffset,
        //                 basePosition + _leftOffset + depthOffset,
        //                 basePosition + _bottomOffset + depthOffset
        //             };
        //             vertices.AddRange(caseOneBottomFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count, true));
        //             
        //             // sides
        //             firstIndex = vertices.Count;
        //             var caseOneSideFace = new[] { caseOneTopFace[1], caseOneBottomFace[1], caseOneBottomFace[2], caseOneTopFace[2] };
        //             vertices.AddRange(caseOneSideFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             break;
        //
        //         
        //         case 2:
        //             // top face
        //             var caseTwoTopFace = new[]
        //             {
        //                 basePosition + _bottomOffset,
        //                 basePosition + _rightOffset,
        //                 basePosition + _bottomRightOffset
        //             };
        //             vertices.AddRange(caseTwoTopFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             // bottom face
        //             firstIndex = vertices.Count;
        //             var caseTwoBottomFace = new[]
        //             {
        //                 basePosition + _bottomOffset + depthOffset,
        //                 basePosition + _rightOffset + depthOffset,
        //                 basePosition + _bottomRightOffset + depthOffset
        //             };
        //             vertices.AddRange(caseTwoBottomFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count, true));
        //             
        //             // sides
        //             firstIndex = vertices.Count;
        //             var caseTwoSideFace = new[] { caseTwoTopFace[0], caseTwoBottomFace[0], caseTwoBottomFace[1], caseTwoTopFace[1] };
        //             vertices.AddRange(caseTwoSideFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             break;
        //
        //         case 4:
        //             // top face
        //             var caseFourTopFace = new[]
        //             {
        //                 basePosition + _topOffset,
        //                 basePosition + _topRightOffset,
        //                 basePosition + _rightOffset
        //             };
        //             vertices.AddRange(caseFourTopFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             // bottom face
        //             firstIndex = vertices.Count;
        //             var caseFourBottomFace = new[]
        //             {
        //                 basePosition + _topOffset + depthOffset,
        //                 basePosition + _topRightOffset + depthOffset,
        //                 basePosition + _rightOffset + depthOffset
        //             };
        //             vertices.AddRange(caseFourBottomFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count, true));
        //             
        //             // sides
        //             firstIndex = vertices.Count;
        //             var caseFourSideFace = new[] { caseFourTopFace[0], caseFourTopFace[2], caseFourBottomFace[2], caseFourBottomFace[0] };
        //             vertices.AddRange(caseFourSideFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             break;
        //
        //         case 8:
        //             // top face
        //             var caseEightTopFace = new[]
        //             {
        //                 basePosition + _leftOffset,
        //                 basePosition + _topLeftOffset,
        //                 basePosition + _topOffset
        //             };
        //             vertices.AddRange(caseEightTopFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             // bottom face
        //             firstIndex = vertices.Count;
        //             var caseEightBottomFace = new[]
        //             {
        //                 basePosition + _leftOffset + depthOffset,
        //                 basePosition + _topLeftOffset + depthOffset,
        //                 basePosition + _topOffset + depthOffset
        //             };
        //             vertices.AddRange(caseEightBottomFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count, true));
        //             
        //             // sides
        //             firstIndex = vertices.Count;
        //             var caseEightSideFace = new[] { caseEightTopFace[0], caseEightTopFace[2], caseEightBottomFace[2], caseEightBottomFace[0] };
        //             vertices.AddRange(caseEightSideFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             break;
        //         
        //
        //         // 2 points:
        //         case 3:
        //             // top face
        //             var caseThreeTopFace = new[]
        //             {
        //                 basePosition,
        //                 basePosition + _leftOffset,
        //                 basePosition + _rightOffset,
        //                 basePosition + _bottomRightOffset
        //             };
        //             vertices.AddRange(caseThreeTopFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             // bottom face
        //             firstIndex = vertices.Count;
        //             var caseThreeBottomFace = new[]
        //             {
        //                 basePosition + depthOffset,
        //                 basePosition + _leftOffset + depthOffset,
        //                 basePosition + _rightOffset + depthOffset,
        //                 basePosition + _bottomRightOffset + depthOffset
        //             };
        //             vertices.AddRange(caseThreeBottomFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count, true));
        //             
        //             // sides
        //             firstIndex = vertices.Count;
        //             var caseThreeSideFace = new[] { caseThreeTopFace[1], caseThreeBottomFace[1], caseThreeBottomFace[2], caseThreeTopFace[2] };
        //             vertices.AddRange(caseThreeSideFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //
        //             break;
        //
        //         case 6:
        //             // top face
        //             var caseSixTopFace = new[]
        //             {
        //                 basePosition + _bottomOffset,
        //                 basePosition + _topOffset,
        //                 basePosition + _topRightOffset,
        //                 basePosition + _bottomRightOffset
        //             };
        //             vertices.AddRange(caseSixTopFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             // bottom face
        //             firstIndex = vertices.Count;
        //             var caseSixBottomFace = new[]
        //             {
        //                 basePosition + _bottomOffset + depthOffset,
        //                 basePosition + _topOffset + depthOffset,
        //                 basePosition + _topRightOffset + depthOffset,
        //                 basePosition + _bottomRightOffset + depthOffset
        //             };
        //             vertices.AddRange(caseSixBottomFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count, true));
        //             
        //             // sides
        //             firstIndex = vertices.Count;
        //             var caseSixSideFace = new[] { caseSixTopFace[0], caseSixBottomFace[0], caseSixBottomFace[1], caseSixTopFace[1] };
        //             vertices.AddRange(caseSixSideFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //
        //             break;
        //
        //         case 9:
        //             // top face
        //             var caseNineTopFace = new[]
        //             {
        //                 basePosition,
        //                 basePosition + _topLeftOffset,
        //                 basePosition + _topOffset,
        //                 basePosition + _bottomOffset
        //             };
        //             vertices.AddRange(caseNineTopFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             // bottom face
        //             firstIndex = vertices.Count;
        //             var caseNineBottomFace = new[]
        //             {
        //                 basePosition + depthOffset,
        //                 basePosition + _topLeftOffset + depthOffset,
        //                 basePosition + _topOffset + depthOffset,
        //                 basePosition + _bottomOffset + depthOffset
        //             };
        //             vertices.AddRange(caseNineBottomFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count, true));
        //             
        //             // sides
        //             firstIndex = vertices.Count;
        //             var caseNineSideFace = new[] { caseNineTopFace[2], caseNineBottomFace[2], caseNineBottomFace[3], caseNineTopFace[3] };
        //             vertices.AddRange(caseNineSideFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //
        //             break;
        //
        //         case 12:
        //             // top face
        //             var caseTwelveTopFace = new[]
        //             {
        //                 basePosition + _leftOffset,
        //                 basePosition + _topLeftOffset,
        //                 basePosition + _topRightOffset,
        //                 basePosition + _rightOffset
        //             };
        //             vertices.AddRange(caseTwelveTopFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             // bottom face
        //             firstIndex = vertices.Count;
        //             var caseTwelveBottomFace = new[]
        //             {
        //                 basePosition + _leftOffset + depthOffset,
        //                 basePosition + _topLeftOffset + depthOffset,
        //                 basePosition + _topRightOffset + depthOffset,
        //                 basePosition + _rightOffset + depthOffset
        //             };
        //             vertices.AddRange(caseTwelveBottomFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count, true));
        //             
        //             // sides
        //             firstIndex = vertices.Count;
        //             var caseTwelveSideFace = new[] { caseTwelveTopFace[0], caseTwelveTopFace[3], caseTwelveBottomFace[3], caseTwelveBottomFace[0] };
        //             vertices.AddRange(caseTwelveSideFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             break;
        //
        //         case 5: // note: ambiguous case
        //             // top face
        //             var caseFiveTopFace = new[] // note: ambiguous case
        //             {
        //                 basePosition,
        //                 basePosition + _leftOffset,
        //                 basePosition + _topOffset,
        //                 basePosition + _topRightOffset,
        //                 basePosition + _rightOffset,
        //                 basePosition + _bottomOffset
        //             };
        //             vertices.AddRange(caseFiveTopFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             // bottom face
        //             firstIndex = vertices.Count;
        //             var caseFiveBottomFace = new[] // note: ambiguous case
        //             {
        //                 basePosition + depthOffset,
        //                 basePosition + _leftOffset + depthOffset,
        //                 basePosition + _topOffset + depthOffset,
        //                 basePosition + _topRightOffset + depthOffset,
        //                 basePosition + _rightOffset + depthOffset,
        //                 basePosition + _bottomOffset + depthOffset
        //             };
        //             vertices.AddRange(caseFiveBottomFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count, true));
        //             
        //             // sides
        //             firstIndex = vertices.Count;
        //             var caseFiveSideFace1 = new[] { caseFiveTopFace[1], caseFiveBottomFace[1], caseFiveBottomFace[2], caseFiveTopFace[2] };
        //             vertices.AddRange(caseFiveSideFace1);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             firstIndex = vertices.Count;
        //             var caseFiveSideFace2 = new[] { caseFiveTopFace[5], caseFiveTopFace[4], caseFiveBottomFace[4], caseFiveBottomFace[5] };
        //             vertices.AddRange(caseFiveSideFace2);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //
        //             break;
        //
        //         case 10: // note: ambiguous case
        //             // top face
        //             var caseTenTopFace = new[]
        //             {
        //                 basePosition + _leftOffset,
        //                 basePosition + _topLeftOffset,
        //                 basePosition + _topOffset,
        //                 basePosition + _rightOffset,
        //                 basePosition + _bottomRightOffset,
        //                 basePosition + _bottomOffset
        //             };
        //             vertices.AddRange(caseTenTopFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             // bottom face
        //             firstIndex = vertices.Count;
        //             var caseTenBottomFace = new[]
        //             {
        //                 basePosition + _leftOffset + depthOffset,
        //                 basePosition + _topLeftOffset + depthOffset,
        //                 basePosition + _topOffset + depthOffset,
        //                 basePosition + _rightOffset + depthOffset,
        //                 basePosition + _bottomRightOffset + depthOffset,
        //                 basePosition + _bottomOffset + depthOffset
        //             };
        //             vertices.AddRange(caseTenBottomFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count, true));
        //             
        //             // sides
        //             firstIndex = vertices.Count;
        //             var caseTenSideFace1 = new[] { caseTenTopFace[0], caseTenTopFace[5], caseTenBottomFace[5], caseTenBottomFace[0] };
        //             vertices.AddRange(caseTenSideFace1);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             firstIndex = vertices.Count;
        //             var caseTenSideFace2 = new[] { caseTenTopFace[2], caseTenBottomFace[2], caseTenBottomFace[3], caseTenTopFace[3] };
        //             vertices.AddRange(caseTenSideFace2);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //              break;
        //
        //         // 3 point:
        //         case 7:
        //             // top face
        //             var caseSevenTopFace = new[]
        //             {
        //                 basePosition,
        //                 basePosition + _leftOffset,
        //                 basePosition + _topOffset,
        //                 basePosition + _topRightOffset,
        //                 basePosition + _bottomRightOffset
        //             };
        //             vertices.AddRange(caseSevenTopFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             // bottom face
        //             firstIndex = vertices.Count;
        //             var caseSevenBottomFace = new[]
        //             {
        //                 basePosition + depthOffset,
        //                 basePosition + _leftOffset + depthOffset,
        //                 basePosition + _topOffset + depthOffset,
        //                 basePosition + _topRightOffset + depthOffset,
        //                 basePosition + _bottomRightOffset + depthOffset
        //             };
        //             vertices.AddRange(caseSevenBottomFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count, true));
        //             
        //             // sides
        //             firstIndex = vertices.Count;
        //             var caseSevenSideFace = new[] { caseSevenTopFace[1], caseSevenBottomFace[1], caseSevenBottomFace[2], caseSevenTopFace[2] };
        //             vertices.AddRange(caseSevenSideFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //
        //             break;
        //
        //         case 11:
        //             // top face
        //             var caseElevenTopFace = new[]
        //             {
        //                 basePosition,
        //                 basePosition + _topLeftOffset,
        //                 basePosition + _topOffset,
        //                 basePosition + _rightOffset,
        //                 basePosition + _bottomRightOffset
        //             };
        //             vertices.AddRange(caseElevenTopFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             // bottom face
        //             firstIndex = vertices.Count;
        //             var caseElevenBottomFace = new[]
        //             {
        //                 basePosition + depthOffset,
        //                 basePosition + _topLeftOffset + depthOffset,
        //                 basePosition + _topOffset + depthOffset,
        //                 basePosition + _rightOffset + depthOffset,
        //                 basePosition + _bottomRightOffset + depthOffset
        //             };
        //             vertices.AddRange(caseElevenBottomFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count, true));
        //             
        //             // sides
        //             firstIndex = vertices.Count;
        //             var caseElevenSideFace = new[] { caseElevenTopFace[2], caseElevenBottomFace[2], caseElevenBottomFace[3], caseElevenTopFace[3] };
        //             vertices.AddRange(caseElevenSideFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //
        //             break;
        //
        //         case 13:
        //             // top face
        //             var caseThirteenTopFace = new[]
        //             {
        //                 basePosition,
        //                 basePosition + _topLeftOffset,
        //                 basePosition + _topRightOffset,
        //                 basePosition + _rightOffset,
        //                 basePosition + _bottomOffset
        //             };
        //             vertices.AddRange(caseThirteenTopFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             // bottom face
        //             firstIndex = vertices.Count;
        //             var caseThirteenBottomFace = new[]
        //             {
        //                 basePosition + depthOffset,
        //                 basePosition + _topLeftOffset + depthOffset,
        //                 basePosition + _topRightOffset + depthOffset,
        //                 basePosition + _rightOffset + depthOffset,
        //                 basePosition + _bottomOffset + depthOffset
        //             };
        //             vertices.AddRange(caseThirteenBottomFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count, true));
        //             
        //             // sides
        //             firstIndex = vertices.Count;
        //             var caseThirteenSideFace = new[] { caseThirteenTopFace[4], caseThirteenTopFace[3], caseThirteenBottomFace[3], caseThirteenBottomFace[4] };
        //             vertices.AddRange(caseThirteenSideFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //
        //             break;
        //
        //         case 14:
        //             // top face
        //             var caseFourteenTopFace = new[]
        //             {
        //                 basePosition + _leftOffset,
        //                 basePosition + _topLeftOffset,
        //                 basePosition + _topRightOffset,
        //                 basePosition + _bottomRightOffset,
        //                 basePosition + _bottomOffset
        //             };
        //             vertices.AddRange(caseFourteenTopFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //         
        //             // bottom face
        //             firstIndex = vertices.Count;
        //             var caseFourteenBottomFace = new[]
        //             {
        //                 basePosition + _leftOffset + depthOffset,
        //                 basePosition + _topLeftOffset + depthOffset,
        //                 basePosition + _topRightOffset + depthOffset,
        //                 basePosition + _bottomRightOffset + depthOffset,
        //                 basePosition + _bottomOffset + depthOffset
        //             };
        //             vertices.AddRange(caseFourteenBottomFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count, true));
        //             
        //             // sides
        //             firstIndex = vertices.Count;
        //             var caseFourteenSideFace = new[] { caseFourteenTopFace[0], caseFourteenTopFace[4], caseFourteenBottomFace[4], caseFourteenBottomFace[0] };
        //             vertices.AddRange(caseFourteenSideFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //
        //             break;
        //
        //         //4 point:
        //         case 15:
        //             // top face
        //             var caseFifteenTopFace = new[]
        //             {
        //                 basePosition,
        //                 basePosition + _topLeftOffset,
        //                 basePosition + _topRightOffset,
        //                 basePosition + _bottomRightOffset
        //             };
        //             vertices.AddRange(caseFifteenTopFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count));
        //             
        //             // bottom face
        //             firstIndex = vertices.Count;
        //             var caseFifteenBottomFace = new[]
        //             {
        //                 basePosition + depthOffset,
        //                 basePosition + _topLeftOffset + depthOffset,
        //                 basePosition + _topRightOffset + depthOffset,
        //                 basePosition + _bottomRightOffset + depthOffset
        //             };
        //             vertices.AddRange(caseFifteenBottomFace);
        //             triangulationBuffer.Add(new TriangulationData(firstIndex, vertices.Count, true));
        //             
        //             break;
        //     }
        // }
        //
        // private static void Triangulate(ICollection<int> triangles, TriangulationData triangulationData)
        // {
        //     for (var i = triangulationData.StartIndex; i < triangulationData.EndIndex - 2; i++)
        //     {
        //         triangles.Add(triangulationData.StartIndex);
        //         triangles.Add(i + 1);
        //         triangles.Add(i + 2);
        //     }
        // }
        //
        // private static void InverseTriangulate(ICollection<int> triangles, TriangulationData triangulationData)
        // {
        //     for (var i = triangulationData.StartIndex; i < triangulationData.EndIndex - 2; i++)
        //     {
        //         triangles.Add(triangulationData.StartIndex);
        //         triangles.Add(i + 2);
        //         triangles.Add(i + 1);
        //     }
        // }
        
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