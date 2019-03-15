using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerGame
{
    class Point
    {
        public readonly int X, Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            int xDiff = X - x;
            int yDiff = Y - y;

            return (int)Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
        }

        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
