using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerGame
{
    class Tower
    {
        private readonly MapLocation _location;
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = 0.75;


        private static readonly Random _random = new Random();


        public Tower(MapLocation location)
        {

            _location = location;
        }

        public bool IsSucessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            //int index = 0;

            //while (index < invaders.Length)
            //{
            //    Invader invader = invaders[index];
            //    //Do stuff to invader

            //    index++;
            //}
            /*
            for (int index = 0; index < invaders.Length; index++)
            {
                Invader invader = invaders[index];
            }
            */
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if (IsSucessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot at and hit an invader");
                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralised and invader");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed an invader");
                    }
                    break;
                }
            }



        }
    }
}
