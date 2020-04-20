using System;
using System.Linq;
using System.Collections.Generic;
namespace KingsGambit
{
    class Program
    {
        static void Main(string[] args)
        {
            King king;
            List<Footman> footmans = new List<Footman>();
            List<RoyalGuard> royalGuards = new List<RoyalGuard>();

            string input = string.Empty;

            input = Console.ReadLine();
            king = new King(input);

            input = Console.ReadLine();
            string[] names = input.Split(new char[] { ' ' });

            foreach (var name in names)
            {
                Footman footman = new Footman(name);
                king.OnKingAttacked += footman.PanickOnKingAttacked;
                footmans.Add(new Footman(name));
            }

            king.NotifyAttack();

            //input = Console.ReadLine();
            //names = input.Split(new char[] { ' ' });

            //foreach (var name in names)
            //{
            //    royalGuards.Add(new Footman(name));
            //}
        }
    }
}
