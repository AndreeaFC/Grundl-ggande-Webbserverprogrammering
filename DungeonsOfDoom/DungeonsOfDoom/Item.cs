using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Item
    {
        public Item(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

		public abstract void GetPickedUp(Player player);
    }

    class Potion : Item
    {
        public Potion(string name) : base(name)
        {

        }
		public override void GetPickedUp(Player player) {
			player.Health += 20;
			player.AttackStrength += 10;
		}

	}

    class Weapon : Item
    {
        public Weapon(string name) : base(name)
        {

        }
		public override void GetPickedUp(Player player) {
			player.Health += 10;
			player.AttackStrength += 30;
		}
	}
}