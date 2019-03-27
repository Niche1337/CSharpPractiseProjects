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

        public Tower(MapLocation location)
        {

            _location = location;
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
                if (invader.IsActive && _location.InRangeOf(invader.Location, 1))
                {
                    invader.DecreaseHealth(1);
                    break;
                }
            }



        }
    }
}
