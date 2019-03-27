using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerGame
{
    class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }
        //Returns true if the player wins, false otherwise
        public bool Play()
        {
            //run until all invaders are dead or invader reaches the end
            int reamainingInvaders = _invaders.Length;

            while (reamainingInvaders > 0)
            {
                //Each tower has opp to fire on invaders
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }



                // count and move the invaders that still active
                reamainingInvaders = 0;
                foreach (Invader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();

                        if (invader.HasScored)
                        {
                            return false;
                        }
                        reamainingInvaders++;
                    }
                }

            }

            return true;
        }
    }
}
