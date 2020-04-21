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
                RoyalGuard royalGuard = new RoyalGuard(name);
                king.OnKingAttacked += royalGuard.KingUnderAttack;
                royalGuards.Add(royalGuard);
            }

            input = Console.ReadLine();
            names = input.Split(new char[] { ' ' });

            foreach (var name in names)
            {
                Footman footman = new Footman(name);
                king.OnKingAttacked += footman.KingUnderAttack;
                footmans.Add(footman);
            }

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Attack King")
                {
                    king.NotifyAttack();
                }
                else if (input.Contains("Kill"))
                {
                    string[] inputChars = input.Split(new char[] { ' ' });
                    string[] toBeKilledNames = inputChars.Skip(1).Take(inputChars.Length - 1).ToArray();

                    List<RoyalGuard> royalGuardsToBeRemoved = royalGuards.Where(x => toBeKilledNames.Any(y => y == x.Name)).ToList();
                    List<Footman> foremansToBeRemoved = footmans.Where(x => toBeKilledNames.Any(y => y == x.Name)).ToList();

                    foreach (var royalGuard in royalGuardsToBeRemoved)
                    {
                        king.OnKingAttacked -= royalGuard.KingUnderAttack;
                        royalGuards.Remove(royalGuard);
                    }

                    foreach (var footman in foremansToBeRemoved)
                    {
                        king.OnKingAttacked -= footman.KingUnderAttack;
                        footmans.Remove(footman);
                    }
                }
            }
        }
    }
}
