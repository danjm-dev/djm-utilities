using System;

namespace DJM.Utilities.Math
{
    [Flags]
    public enum Axis2DFlags : byte
    {
        X = 1 << 0,
        Y = 1 << 1,
        None = 0,
        XY = X | Y
    }
}