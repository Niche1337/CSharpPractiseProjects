using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerGame
{
    interface IMapppable
    {
        MapLocation Location { get; }
    }

    interface IMovable
    {
        void Move();
    }


    interface IInvader : IMapppable, IMovable
    {
        

        bool HasScored { get; }

        int Health { get;}

        bool IsNeutralized { get; }

        bool IsActive { get;  }

        void DecreaseHealth(int factor);
    }
}
