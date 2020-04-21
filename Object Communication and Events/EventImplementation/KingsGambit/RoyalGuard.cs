using System;
using System.Collections.Generic;
using System.Text;

namespace KingsGambit
{
    public class RoyalGuard
    {
        public RoyalGuard(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public void KingUnderAttack()
        {
            Console.WriteLine($"Royal Guard {Name} is Defending!");
        }
    }
}
