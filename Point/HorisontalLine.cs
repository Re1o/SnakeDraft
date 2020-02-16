using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    class HorisontalLine : Figure
    {
       

        public HorisontalLine(int xLeft, int xRight, int y, char symbol)
        {
            pointList = new List<Point>();

            for (int i = xLeft; i <= xRight; i++)
            {
                Point newPoint = new Point(i, y, symbol);
                pointList.Add(newPoint);

            }
        }


    }
}
