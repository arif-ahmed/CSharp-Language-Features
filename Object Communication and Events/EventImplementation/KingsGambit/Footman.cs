using System;
using System.Collections.Generic;
using System.Text;

namespace KingsGambit
{
    public class Footman
    {
        public Footman(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public void KingUnderAttack()
        {
            Console.WriteLine($"Footman {Name} is Pancking!");
        }
    }
}
