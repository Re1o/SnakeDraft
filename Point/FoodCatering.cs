using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    class FoodCatering
    {
        int Mapwith;
        int MapHeight;
        char symbol;

        Random rnd = new Random();

        public FoodCatering(int _mapWidth, int _mapheight, char _symbol)
        {
            Mapwith = _mapWidth;
            MapHeight = _mapheight;
            symbol = _symbol;

        }
        public Point CaterFood()
        {
            int x = rnd.Next(2, Mapwith - 2);
            int y = rnd.Next(2, MapHeight - 2);
            return new Point(x, y, symbol);
        }
    }
}
