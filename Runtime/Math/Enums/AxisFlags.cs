using System;

namespace DJM.Utilities.Math
{
    [Flags]
    public enum AxisFlags : byte
    {
        X = 1 << 0,
        Y = 1 << 1,
        Z = 1 << 2,
        None = 0,
        XY = X | Y,
        XZ = X | Z,
        YZ = Y | Z,
        XYZ = X | Y | Z
    }
}