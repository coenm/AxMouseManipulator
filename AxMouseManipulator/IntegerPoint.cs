using System.Runtime.InteropServices;

namespace AxMouseManipulator
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IntegerPoint
    {
        public int X { get; }
        public int Y { get; }

        public IntegerPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}