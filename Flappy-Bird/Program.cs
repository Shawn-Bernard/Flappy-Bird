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
            
            
        }
        
    }

}
