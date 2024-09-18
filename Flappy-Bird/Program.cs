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
<<<<<<< HEAD

        int Score;
        int FlappyPositionY;
        const int FlappyPositionX;
        String[] Pipe[
        PipePosX
        

        PipeGap Start
        

        PipeGap End
            ]
        int FrameCount;


        void Main
        {
            while (true)
        {
        Console.SetWindowSize(ScreenSizeX, ScreenSizeY);
        Console.SetBufferSize(ScreenSizeX, ScreenSizeY);
        Console.CursorVisible = (false);
        Console.SetCursorPosition(5, FlappyY);
        HandleInput();
        MovePipes()
        CheckCollision();
        DrawGame();

        Thread.Sleep(100);
   
     }
  public void HandleInput()
    {
        
        if (Console.KeyAvailable)
        {
            ConsoleIeKeyInfo = keyPressed = Console.ReadKey(true);
            if (keyPressed = Console.ReadKey(true){
                Flappy_Bird -= 2;
            }
            else
            {
                FlappyY += 1;
            }
        }
    }
   public void DrawGame()
    {
        Console.Clear();
        Console.SetCursorPosition(ScreenSizeX / 2, ScreenSizeY / 2);
        Console.WriteLine("O");
    }
    public void MovePipes()
    {

    }
        
        static void Main(string[] args)
        {
            int FlappyX = 0;
            int FlappyY = 0;
            
            
            
            FlappyY = ScreenSizeY;
            while (true) 
            {
                Console.Clear();
                Console.SetCursorPosition(ScreenSizeX / 2, ScreenSizeY / 2);
                Console.WriteLine("O");
=======
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
>>>>>>> 7bc0c7b60d080ca42f40fa40d70d675978d6610f

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
<<<<<<< HEAD
            Console.SetCursorPosition(5, FlappyY);
            Console.Write("O");
            
            
        }
        
    }

=======
        }
        public void HandleInput()
        {
            if (Console.KeyAvailable)
            {
                LastFrameSpacePressed = FrameCount;
            }
        }
    } 
>>>>>>> 7bc0c7b60d080ca42f40fa40d70d675978d6610f
}
