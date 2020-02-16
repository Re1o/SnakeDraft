using System;
using System.Threading;

namespace Point
{
    class Program
    {

        
        static void Main(string[] args)
        {
            

            HorisontalLine hrLine = new HorisontalLine(5, 10, 10, '*');
            hrLine.DrawFigure();

            VerticalLine vrLine = new VerticalLine(6, 10, 5, '*');
            vrLine.DrawFigure();

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            /*Point p1 = new Point(10, 10, '*');
            p1.Draw();
           
            Point p2 = new Point(10, 11, '*');
            p2.Draw();

            Point p3 = new Point(10, 12, '*');
            p3.Draw();

            Point p4 = new Point(10, 13, '*');
            p4.Draw();

            Point p5 = new Point(10, 14, '*');
            p5.Draw();

            Point p6 = new Point(10, 15, '*');
            p6.Draw();



            Point p7 = new Point(11, 10, '*');
            p7.Draw();

            Point p8 = new Point(12, 10, '*');
            p8.Draw();

            Point p9 = new Point(13, 10, '*');
            p9.Draw();

            Point p10 = new Point(14, 10, '*');
            p10.Draw();

            Point p11 = new Point(15, 10, '*');
            p11.Draw();

            Point p12 = new Point(16, 10, '*');
            p12.Draw();
            */
            
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.DrawWalls();

            /* HorisontalLine topLine = new HorisontalLine(0, 78, 0, '%');
              topLine.DrawFigure();
              HorisontalLine bottomLine = new HorisontalLine(0, 78, 24, '%');
              bottomLine.DrawFigure();
              VerticalLine leftLine = new VerticalLine(0, 24, 0, '[');
              leftLine.DrawFigure();
              VerticalLine rightLine = new VerticalLine(0, 24, 78, ']');
              rightLine.DrawFigure();*/

            Point tail = new Point(6, 5, '*');
            Snake snake = new Snake(tail, 4, Direction.RIGHT);
            snake.DrawFigure();

            FoodCatering foodCatering = new FoodCatering(80, 25, '#');
            Point food = foodCatering.CaterFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHitByFigure(snake))
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCatering.CaterFood();
                    food.Draw();

                }

                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.ReadUserKey(key.Key);
                }
            }
            
            WriteGameOver();

            Console.ReadLine();
        }



        public static void WriteGameOver()
        {
            Console.Clear();
            int xOffset = 35;
            int yOffset = 11;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            ShowMessage("=========", xOffset, yOffset++);
            ShowMessage("GAME OVER", xOffset, yOffset++);
            ShowMessage("=========", xOffset, yOffset++);

        }

        public static void ShowMessage(string text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
