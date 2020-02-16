using System;

namespace SnakeDraft
{



    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point(int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           

            //Console.SetWindowSize(25, 25);

            //declare point cordinates
            Point p1 = new Point(10, 10, '*');
            p1.Draw();
           /* int x1 = 10;
            int y1 = 10;
            char symbol1 = '*';*/
            //Draw(p1.x2, p1.y2, symbol1);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            /*  Console.SetCursorPosition(x1, y1);
              Console.ForegroundColor = ConsoleColor.Yellow;
              Console.WriteLine(symbol1);*/

            Point p2 = new Point(5, 5, '#');
            p2.Draw();
           /* int x2 = 5;
            int y2 = 5;
            char symbol2 = '#';*/

           // Console.SetCursorPosition(x2, y2);
           // Console.WriteLine(symbol2);



        }
        public static void Draw(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
