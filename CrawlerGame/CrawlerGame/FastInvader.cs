﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerGame
{
    class FastInvader : Invader
    {

        protected override int stepSize { get; } = 2;

        public FastInvader(Path path) : base(path)
        {

        }

    }
}
