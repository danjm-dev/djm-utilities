using DJM.Utilities.EditorTools.Debugging;
using Unity.Collections;
using Unity.Mathematics;

namespace DJM.Utilities.Math.Geometry
{
    public readonly struct CoordinateNodeArray2D<T> where T : unmanaged
    {
        public readonly int2 Resolution;
        public readonly int2 Origin;
        public readonly NativeArray<T> Nodes;
        
        public CoordinateNodeArray2D
        (
            in int2 resolution,
            in int2 origin = default,
            in Allocator allocator = Allocator.Persistent
        )
        {
            Resolution = resolution;
            Origin = origin;
            Nodes = new NativeArray<T>(resolution.x * resolution.y, allocator);
        }
        
        public CoordinateNodeArray2D
        (
            in int2 resolution,
            in NativeArray<T> nodes,
            in int2 origin = default
        )
        {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
            if (nodes.Length != resolution.x * resolution.y)
            {
                DebugUtils.LogError("Node array length does not match resolution");
            }
#endif
            Resolution = resolution;
            Origin = origin;
            Nodes = nodes;
        }
    }
}