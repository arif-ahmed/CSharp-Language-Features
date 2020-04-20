using System;
using System.Collections.Generic;
using System.Text;

namespace KingsGambit
{
    public class RoyalGuard
    {
        private readonly string _name;
        public RoyalGuard(string name)
        {
            _name = name;
        }

        public void DefendOnKingAttacked()
        {
            Console.WriteLine($"Royal Guard {_name} is Defending!");
        }
    }
}
