using UnityEngine;

namespace DJM.Utilities.MeshGeneration
{
    internal readonly struct MarchingSquareData
    {
        public readonly Vector3 BasePosition;
        public readonly byte Config;
        
        public MarchingSquareData(Vector3 basePosition, byte config)
        {
            BasePosition = basePosition;
            Config = config;
        }
    }
}