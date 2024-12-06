using Unity.Mathematics;

namespace DJM.Utilities.Math.Geometry
{
    public readonly struct CoordinateRaycastHitResults2D
    {
        public readonly int2 HitCoordinates;
        public readonly float2 HitPosition;
        
        public CoordinateRaycastHitResults2D(in int2 hitCoordinates, in float2 hitPosition)
        {
            HitCoordinates = hitCoordinates;
            HitPosition = hitPosition;
        }
    }
}