using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Player
    {
        public Player()
        {
            Health = 100;
            AttackStrength = 30;
        }

        public int Health { get; set; }
        public int AttackStrength { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}

