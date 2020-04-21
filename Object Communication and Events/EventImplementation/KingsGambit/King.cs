using System;
using System.Collections.Generic;
using System.Text;

namespace KingsGambit
{
    public delegate void KingAttacked();
    public class King
    {
        public event KingAttacked OnKingAttacked;
        public string Name { get; set; }

        public King(string name)
        {
            Name = name;
        }

        public void NotifyAttack()
        {
            Console.WriteLine($"King {Name} is under attack!");
            OnKingAttacked?.Invoke();
        }
    }
}
