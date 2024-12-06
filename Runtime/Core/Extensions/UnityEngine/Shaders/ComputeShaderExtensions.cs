using Unity.Mathematics;
using UnityEngine;

namespace DJM.Utilities
{
    public static class ComputeShaderExtensions
    {
        public static void Dispatch(this ComputeShader computeShader, int kernelIndex, int3 threadGroups)
        {
            computeShader.Dispatch(kernelIndex, threadGroups.x, threadGroups.y, threadGroups.z);
        }
        
        public static void Dispatch(this ComputeShader computeShader, int kernelIndex, int2 threadGroups, int threadGroupsZ = 1)
        {
            computeShader.Dispatch(kernelIndex, threadGroups.x, threadGroups.y, threadGroupsZ);
        }

        public static bool TryGetKernel(this ComputeShader computeShader, string name, out int kernelIndex)
        {
            if (!computeShader.HasKernel(name))
            {
                kernelIndex = -1;
                return false;
            }
            
            kernelIndex = computeShader.FindKernel(name);
            return true;
        }
    }
}