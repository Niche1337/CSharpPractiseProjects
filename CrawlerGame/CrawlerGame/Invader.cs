using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerGame
{
    abstract class Invader :IInvader 
    {
        private readonly Path _path;
        private int _pathStep = 0;

        protected virtual int stepSize { get; } = 1; 

        public MapLocation Location { get => _path.GetlocationAt(_pathStep); }

        public virtual int Health { get; protected set; } = 2;

        public bool HasScored{ get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += stepSize;

        public virtual void DecreaseHealth(int factor) => Health -= factor;
       

        /*
        private int _hello;

        public int Hello { get => _hello; set => _hello = value; }
        */
        /*
        public  MapLocation GetLocation()
        {
            return _location;
        }

        public void SetLocation(MapLocation value)
        {
            _location = value;
        }
        */

    }
}
