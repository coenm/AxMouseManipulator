using System;

namespace AxMouseManipulator
{
    public static class MouseManipulator
    {
        /// <summary> Returns the cursor's current position. </summary>
        public static IntegerPoint GetCursorPosition()
        {
            if (!InternalHelpers.GetCursorPos(out IntegerPoint point))
                throw new InvalidOperationException("Could not retrieve the mouse cursor's current position.");

            return new IntegerPoint(point.X, point.Y);
        }

        /// <summary> Teleports the cursor to the given coordinates. </summary>
        public static void SetCursorPosition(int x, int y)
        {
            InternalHelpers.SetCursorPosition(x, y);
        }


        /// <summary> Performs a left mouse down in the cursor's current position. </summary>
        public static void PerformLeftMouseDown()
        {
            InternalHelpers.DoLeftMouseDown();
        }

        /// <summary> Performs a left mouse up in the cursor's current position. </summary>
        public static void PerformLeftMouseUp()
        {
            InternalHelpers.DoLeftMouseUp();
        }

        /// <summary> Performs a left mouse down  at the given coordinates. </summary>
        public static void PerformLeftMouseDown(int x, int y)
        {
            InternalHelpers.SetCursorPosition(x, y);
            InternalHelpers.DoLeftMouseDown();
        }

        /// <summary> Performs a left mouse up  at the given coordinates. </summary>
        public static void PerformLeftMouseUp(int x, int y)
        {
            InternalHelpers.SetCursorPosition(x, y);
            InternalHelpers.DoLeftMouseUp();
        }

        /// <summary> Performs a left click in the cursor's current position. </summary>
        public static void PerformLeftClick()
        {
            InternalHelpers.DoLeftClick();
        }

        /// <summary> Performs a left click at the given coordinates. </summary>
        public static void PerformLeftClick(int x, int y)
        {
            InternalHelpers.SetCursorPosition(x, y);
            InternalHelpers.DoLeftClick();
        }

        /// <summary> Performs a right mouse down in the cursor's current position. </summary>
        public static void PerformRightMouseDown()
        {
            InternalHelpers.DoRightMouseDown();
        }

        /// <summary> Performs a right mouse up in the cursor's current position. </summary>
        public static void PerformRightMouseUp()
        {
            InternalHelpers.DoRightMouseUp();
        }

        /// <summary> Performs a right mouse down  at the given coordinates. </summary>
        public static void PerformRightMouseDown(int x, int y)
        {
            InternalHelpers.SetCursorPosition(x, y);
            InternalHelpers.DoRightMouseDown();
        }

        /// <summary> Performs a right mouse up  at the given coordinates. </summary>
        public static void PerformRightMouseUp(int x, int y)
        {
            InternalHelpers.SetCursorPosition(x, y);
            InternalHelpers.DoRightMouseUp();
        }

        /// <summary> Performs a right click in the cursor's current position. </summary>
        public static void PerformRightClick()
        {
            InternalHelpers.DoRightClick();
        }

        /// <summary> Performs a right click at the given coordinates. </summary>
        public static void PerformRightClick(int x, int y)
        {
            InternalHelpers.SetCursorPosition(x, y);
            InternalHelpers.DoRightClick();
        }

        /// <summary> Performs a middle mouse down in the cursor's current position. </summary>
        public static void PerformMiddleMouseDown()
        {
            InternalHelpers.DoMiddleMouseDown();
        }

        /// <summary> Performs a middle mouse up in the cursor's current position. </summary>
        public static void PerformMiddleMouseUp()
        {
            InternalHelpers.DoMiddleMouseUp();
        }

        /// <summary> Performs a middle mouse down  at the given coordinates. </summary>
        public static void PerformMiddleMouseDown(int x, int y)
        {
            InternalHelpers.SetCursorPosition(x, y);
            InternalHelpers.DoMiddleMouseDown();
        }

        /// <summary> Performs a middle mouse up  at the given coordinates. </summary>
        public static void PerformMiddleMouseUp(int x, int y)
        {
            InternalHelpers.SetCursorPosition(x, y);
            InternalHelpers.DoMiddleMouseUp();
        }

        /// <summary> Performs a middle click in the cursor's current position. </summary>
        public static void PerformMiddleClick()
        {
            InternalHelpers.DoMiddleClick();
        }

        /// <summary> Performs a middle click at the given coordinates. </summary>
        public static void PerformMiddleClick(int x, int y)
        {
            InternalHelpers.SetCursorPosition(x, y);
            InternalHelpers.DoMiddleClick();
        }

        /// <summary> Scrolls the mouse wheel up by the given ticks. </summary>
        public static void ScrollMouseWheelUp(int ticks)
        {
            InternalHelpers.Scroll(ticks);
        }

        /// <summary> Scrolls the mouse wheel down by the given ticks. </summary>
        public static void ScrollMouseWheelDown(int ticks)
        {
            InternalHelpers.Scroll(-ticks);
        }
    }
}