using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Monster
    {
        public Monster(string name, int health, int attackStrength)
        {
            Name = name;
            Health = health;
            AttackStrength = attackStrength;
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackStrength { get; set; }
    }
}
