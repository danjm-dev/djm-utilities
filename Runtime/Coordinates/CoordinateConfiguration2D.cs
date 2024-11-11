using Unity.Mathematics;

namespace DJM.Utilities.Coordinates
{
    public readonly struct CoordinateConfiguration2D
    {
        public readonly float2 Origin;
        public readonly float2 UnitSize;
        
        public CoordinateConfiguration2D
        (
            in float2 origin, 
            in float2 unitSize
        )
        {
            Origin = origin;
            UnitSize = unitSize;
        }
    }
}