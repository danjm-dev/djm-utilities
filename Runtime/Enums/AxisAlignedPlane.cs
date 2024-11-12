using UnityEngine;

namespace DJM.Utilities
{
    public enum AxisAlignedPlane : byte
    {
        XY = 0,
        XZ = 1,
        ZY = 2
    }
    
    public static class AxisAlignedPlaneExtensions
    {
        public static Vector3 GetNormal(this AxisAlignedPlane plane)
        {
            return plane switch
            {
                AxisAlignedPlane.XY => Vector3.forward,
                AxisAlignedPlane.XZ => Vector3.up,
                AxisAlignedPlane.ZY => Vector3.right,
                _ => Vector3.zero
            };
        }

        public static (Vector3, Vector3) GetAxes(this AxisAlignedPlane plane)
        {
            return plane switch
            {
                AxisAlignedPlane.XY => (Vector3.right, Vector3.up),
                AxisAlignedPlane.XZ => (Vector3.right, Vector3.forward),
                AxisAlignedPlane.ZY => (Vector3.forward, Vector3.up),
                _ => (Vector3.zero, Vector3.zero)
            };
        }
        
    }
}