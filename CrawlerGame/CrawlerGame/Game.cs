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
            /*
            Point x = new MapLocation(4, 2, map);
            Point p = x;
            map.OnMap(new MapLocation(0, 0, map));
            Console.WriteLine(x.DistanceTo(5, 5));
            */


            try
            {
                Path path = new Path(
                    new[]   {
                                new MapLocation(0,2,map),
                                new MapLocation(1,2,map),
                                new MapLocation(2,2,map),
                                new MapLocation(3,2,map),
                                new MapLocation(4,2,map),
                                new MapLocation(5,2,map),
                                new MapLocation(6,2,map),
                                new MapLocation(7,2,map)
                                    }
                            );
                Invader[] invaders =
                {
                    new Invader(path),
                    new Invader(path),
                    new Invader(path),
                    new Invader(path)
                };

                Tower[] towers =
                {
                    new Tower (new MapLocation(1, 3, map)),
                    new Tower (new MapLocation(3, 3, map)),
                    new Tower (new MapLocation(5, 3, map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();
                Console.WriteLine("Player " + (playerWon ? "Won" : "Lost"));


                /*
                MapLocation location = path.GetlocationAt(0);
                
                if (location != null)
                {
                    Console.WriteLine(location.X + "," + location.Y); 
                }
                */
                /*
                Invader invader = new Invader();
                MapLocation location = new MapLocation(0, 0, map);

        

                invader.Location = location;
                //location = invader.Location;
                */
            }
            catch (OutofBoundsException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (CrawlerGameException)
            {
                Console.WriteLine("Unhandled CrawlerGameException");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Unhandled Exception " + ex);
                Console.ReadLine();
            }

        }
    }
}
