using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerGame
{
    class Path
    {
        private readonly MapLocation[] _path;

        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetlocationAt(int pathStep)
        {
            return ( pathStep < _path.Length) ? _path[pathStep] : null; //Ternary If (Read up if you forgot what it means, note to self)
        }

        public bool IsOnPath(MapLocation location)
        {
            foreach (var pathLocation in _path)
            {
                if(location.Equals(pathLocation))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
/*
int value = -1;
string textColor = null;

textColor = (value< 0) ? "red" : "green";
*/