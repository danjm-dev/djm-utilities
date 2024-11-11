namespace DJM.Utilities.Coordinates
{
    public interface ICoordinateRaycastTarget
    {
        public bool DoesRayHit(in int layerMask);
    }
    
    public readonly struct TestNode : ICoordinateRaycastTarget
    {
        public bool DoesRayHit(in int layerMask)
        {
            return true;
        }
    }
    
}