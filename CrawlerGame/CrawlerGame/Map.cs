using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerGame
{
    class Map
    {
        public readonly int Width, Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            return point.X >= 0 && point.X <= Width && 
                   point.Y >= 0 && point.Y <= Height;     
        }
    }
}
