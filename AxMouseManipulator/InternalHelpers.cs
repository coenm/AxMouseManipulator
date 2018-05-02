using System;
using System.Runtime.InteropServices;

namespace AxMouseManipulator
{
    internal static class InternalHelpers
    {
        #region [ DLL imports ]

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetCursorPos(out IntegerPoint lpMousePoint);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        #endregion

        internal static void SetCursorPosition(int x, int y)
        {
            if (x < 0) throw new ArgumentOutOfRangeException(nameof(x), "The coordinate cannot be negative.");
            if (y < 0) throw new ArgumentOutOfRangeException(nameof(y), "The coordinate cannot be negative.");

            if (!SetCursorPos(x, y))
                throw new InvalidOperationException("Could not set the mouse cursor's position.");
        }

        internal static void DoLeftMouseDown()
        {
            ParameterlessMouseEvent(MouseEventFlags.LeftDown);
        }

        internal static void DoLeftMouseUp()
        {
            ParameterlessMouseEvent(MouseEventFlags.LeftUp);
        }

        internal static void DoLeftClick()
        {
            DoLeftMouseDown();
            DoLeftMouseUp();
        }

        internal static void DoRightMouseDown()
        {
            ParameterlessMouseEvent(MouseEventFlags.RightDown);
        }

        internal static void DoRightMouseUp()
        {
            ParameterlessMouseEvent(MouseEventFlags.RightUp);
        }

        internal static void DoRightClick()
        {
            DoRightMouseDown();
            DoRightMouseUp();
        }

        internal static void DoMiddleMouseDown()
        {
            ParameterlessMouseEvent(MouseEventFlags.MiddleDown);
        }

        internal static void DoMiddleMouseUp()
        {
            ParameterlessMouseEvent(MouseEventFlags.MiddleUp);
        }

        internal static void DoMiddleClick()
        {
            DoMiddleMouseDown();
            DoMiddleMouseUp();
        }

        internal static void Scroll(int ticks)
        {
            if (ticks < -100 || ticks > 100)
                throw new ArgumentOutOfRangeException(nameof(ticks), "The argument has to be between -100 and +100, inclusive.");

            mouse_event(
                dwFlags: (int)MouseEventFlags.Wheel,
                dx: 0,
                dy: 0,
                dwData: ticks * 120,
                dwExtraInfo: 0
            );
        }

        private static void ParameterlessMouseEvent(MouseEventFlags value)
        {
            bool isSuccessful = GetCursorPos(out IntegerPoint position);
            if (!isSuccessful)
                throw new InvalidOperationException("Could not retrieve the mouse cursor's current location from Windows API.");

            mouse_event(
                dwFlags: (int)value,
                dx: position.X,
                dy: position.Y,
                dwData: 0,
                dwExtraInfo: 0
            );
        }
    }
}