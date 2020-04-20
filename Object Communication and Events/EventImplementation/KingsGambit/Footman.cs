using System;
using System.Collections.Generic;
using System.Text;

namespace KingsGambit
{
    public class Footman
    {
        public string Name { get; set; }

        public Footman(string name)
        {
            Name = name;
        }
        public void PanickOnKingAttacked()
        {
            Console.WriteLine($"Footman {Name} is Pancking!");
        }
    }
}
