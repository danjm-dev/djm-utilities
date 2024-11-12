using Unity.Mathematics;

namespace DJM.Utilities.MeshGeneration
{
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly struct VertexData 
    {
        public readonly float3 Position;
        public readonly float3 Normal;
        
        public VertexData(float3 position, float3 normal)
        {
            Position = position;
            Normal = normal;
        }
    }
}