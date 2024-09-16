using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Flappy_Bird
{
    internal class Program
    {
        static int ScreenSizeX = 25;
        static int ScreenSizeY = 20;
        static void Main(string[] args)
        {
            int FlappyX = 0;
            int FlappyY = 0;
            
            Console.SetWindowSize(ScreenSizeX, ScreenSizeY);
            Console.SetBufferSize(ScreenSizeX, ScreenSizeY);
            Console.CursorVisible = (false);
            //Console.WriteLine("Hello World")
            FlappyY = ScreenSizeY;
            while (true) 
            {
                Console.Clear();
                Console.SetCursorPosition(ScreenSizeX / 2, ScreenSizeY / 2);
                Console.WriteLine("O");

                if (Console.KeyAvailable)
                {
                    ConsoleIeKeyInfo keyPressed = Console.ReadKey(true);
                    if (keyPressed == Console.Spacebar)
                    {
                        FlappyY -= 2;
                    }
                }
                else
                {
                    FlappyY += 1;
                }
            }
            Console.SetCursorPosition(5, FlappyY);
            Console.Write("O");
            Thread.Sleep(100);

        }
    }
}
