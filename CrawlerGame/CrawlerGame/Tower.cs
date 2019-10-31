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

        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = 0.75;



        public Tower(MapLocation location)
        {

            _location = location;
        }

        public bool IsSucessfulShot()
        {
            return Random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(IInvader[] invaders)
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
            foreach (IInvader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSucessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        Console.WriteLine("Shot at and hit an invader");
                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralised and invader as " +invader.Location);
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
