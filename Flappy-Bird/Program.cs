using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Flappy_Bird
{
    
    internal class Program
    {
        static int ScreenSizeX = 25;
        static int ScreenSizeY = 20;

        static int FlappyX = 25;
        static int FlappyY = 20;

        static int FrameCount = 12;
        static int LastFrameSpace = 0;

        static void Main(string[] args)
        {
            // Setting the window width and height
            Console.WindowWidth = 80;
            Console.WindowHeight = 25;
            // Setting the buffer width and height to the same value.
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            // Hiding the console cursor
            Console.CursorVisible = false;
            if (Console.KeyAvailable == Console.Spacebar) 
        }
        class Game
        {
            bool GameOver = false;

            public void RunGame()
            {
                Console.WriteLine("Game Running");
                
                while (GameOver) 
                {
                    HandleInput();
                    if (FrameCount - LastFrameSpace < 2)
                    {
                        FlappyY = FlappyY + 1;
                    }
                    else
                    {
                        FlappyX = FlappyX - 1;
                    }

                    while (GameOver == false)
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                }
                
                
            }
        }
        public void HandleInput()
        {
            if (Console.KeyAvailable)
            {
                LastFrameSpacePressed = FrameCount;
            }
        }
    } 
}
