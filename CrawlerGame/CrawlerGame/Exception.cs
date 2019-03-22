using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerGame
{
    class CrawlerGameException : Exception
    {
        public CrawlerGameException()
        {
        }

        public CrawlerGameException(string message) : base(message)
        {
        }
    }

    class OutofBoundsException : CrawlerGameException
    {
        public OutofBoundsException()
        {
        }

        public OutofBoundsException(string message) : base(message)
        {
        }
    }

}
