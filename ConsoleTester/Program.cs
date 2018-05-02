using AxMouseManipulator;
using System.Threading;

namespace ConsoleTester
{
    internal static class Program
    {
        private static void Main()
        {
            Thread.Sleep(2000);
            int i = 0;
            while (i < 10)
            {
                i++;
                Thread.Sleep(2000);
                MouseManipulator.SetCursorPosition(100, 100);
                Thread.Sleep(50);
                MouseManipulator.SetCursorPosition(100, 150);
                Thread.Sleep(50);
                MouseManipulator.SetCursorPosition(100, 200);
                Thread.Sleep(50);
                MouseManipulator.SetCursorPosition(150, 200);
                Thread.Sleep(50);
                MouseManipulator.SetCursorPosition(200, 200);
                Thread.Sleep(50);
                MouseManipulator.SetCursorPosition(200, 150);
                Thread.Sleep(50);
                MouseManipulator.SetCursorPosition(200, 100);
                Thread.Sleep(50);
                MouseManipulator.SetCursorPosition(150, 100);
                Thread.Sleep(50);
                MouseManipulator.SetCursorPosition(100, 100);
                Thread.Sleep(50);
                MouseManipulator.PerformLeftMouseDown(200, 200);
                Thread.Sleep(200);
                MouseManipulator.PerformLeftMouseUp(500, 500);

            }

            //while (true)
            //{
            //    IntegerPoint pos = MouseManipulator.GetCursorPosition();
            //    Console.WriteLine($"X: {pos.X}, Y: {pos.Y}");
            //    Thread.Sleep(50);
            //}

            //MouseManipulator.PerformLeftClick();
            //MouseManipulator.PerformLeftClick(100, 500);

            //MouseManipulator.PerformRightClick();
            //MouseManipulator.PerformRightClick(300, 500);

            //MouseManipulator.PerformMiddleClick();
            //MouseManipulator.PerformMiddleClick(100, 85);


            //while (true)
            //{
            //    MouseManipulator.ScrollMouseWheelDown(1);
            //    Thread.Sleep(100);
            //    MouseManipulator.ScrollMouseWheelDown(1);
            //    Thread.Sleep(100);
            //    MouseManipulator.ScrollMouseWheelUp(1);
            //    Thread.Sleep(100);
            //    MouseManipulator.ScrollMouseWheelUp(1);
            //    Thread.Sleep(100);
            //}
        }
    }
}