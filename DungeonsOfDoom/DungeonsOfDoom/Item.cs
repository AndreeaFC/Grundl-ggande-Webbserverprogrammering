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
    }

    class Potion : Item
    {
        public Potion(string name) : base(name)
        {

        }
    }

    class Weapon : Item
    {
        public Weapon(string name) : base(name)
        {

        }
    }
}
