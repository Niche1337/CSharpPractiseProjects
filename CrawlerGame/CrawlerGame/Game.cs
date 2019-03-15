using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerGame
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);
            Point point = new Point(4, 2);
            bool isOnMap = map.OnMap(point);

        }
    }
}
