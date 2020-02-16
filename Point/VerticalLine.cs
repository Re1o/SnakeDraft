using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    class VerticalLine : Figure
    {

        public VerticalLine(int yTop, int yBottom, int x, char symbol)
        {
            for (int i = yTop; i <= yBottom; i++)
            {
                Point newpoint = new Point(x, i, symbol);
                pointList.Add(newpoint);
            }
        }

        /*public void DrawVerticalLine()
        {
            foreach(Point point in pointList)
            {
                point.Draw();
            }*/
            
        
    }
}
