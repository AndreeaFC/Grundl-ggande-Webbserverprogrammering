using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Being
    {
        public Being(string name, int health, int attackStrength)
        {
            Name = name;
            Health = health;
            AttackStrength = attackStrength;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackStrength { get; set; }

		public virtual void Fight(Being opponent) {
			opponent.Health -= 10;
		}
	}
	

    abstract class Monster : Being
    {
        public Monster(string name, int health, int attackStrength, int fire, int ice) : base(name, health, attackStrength)
        {
            FireAttack = fire;
            IceAttack = ice;
        }
        public int FireAttack { get; set; }
        public int IceAttack { get; set; }
    }

    class Ogre : Monster
    {
        public Ogre() : base("Ogre", 40, 20, 100, 0)
        {

        }
    }

    class Giant : Monster
    {
        public Giant() : base("Giant", 50, 30, 0, 100)
        {

        }
		public override void Fight(Being opponent) {
			opponent.Health -= 20;
		}
	}

    class Cyclop : Monster
    {
        public Cyclop() : base("Cyclop", 60, 40, 50, 50)
        {

        }
    }

    class Player : Being
    {
        public Player(string name) : base(name, 100, 30)
        {
			Backpack = new List<Item>();
        }
        public int X { get; set; }
        public int Y { get; set; }
		public List<Item> Backpack { get; set; }
	}

}