using System;

namespace AxMouseManipulator
{
    /// <remarks>
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/ms646260(v=vs.85).aspx
    /// </remarks>>
    [Flags]
    internal enum MouseEventFlags
    {
        LeftDown = 0x0002,
        LeftUp = 0x0004,
        MiddleDown = 0x0020,
        MiddleUp = 0x0040,
        RightDown = 0x0008,
        RightUp = 0x0010,
        Wheel = 0x0800,

        // Unused:
        Move = 0x0001,
        Absolute = 0x8000,
        XDown = 0x0080,
        XUp = 0x0010,
        HWheel = 0x1000
    }
}