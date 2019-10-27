using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_King_s_Gambit
{
    class Program
    {
        static void Main(string[] args)
        {
            var footMans = new List<Footman>();
            var royalGuards = new List<Royal_Guard>();
            var king = new King(Console.ReadLine());
            var royalGuardsNames = Console.ReadLine().Split();

            foreach (string guardName in royalGuardsNames)
            {
                var currentRoyalGuard = new Royal_Guard(guardName);
                royalGuards.Add(currentRoyalGuard);
                king.BeingAttacked += currentRoyalGuard.OnKingBeingAttacked;
            }

            var footmenNames = Console.ReadLine().Split();

            foreach (string footManName in footmenNames)
            {
                var footMan = new Footman(footManName);
                footMans.Add(footMan);
                king.BeingAttacked += footMan.OnKingBeingAttacked;
            }

            var command = Console.ReadLine().Split();

            while (command[0]!="End")
            {
                if (command[0] == "Kill") {
                    try
                    {
                        Footman deadFootman = footMans.FirstOrDefault(f => f.name.Equals(command[1]));
                        king.BeingAttacked -= deadFootman.OnKingBeingAttacked;
                        footMans.Remove(deadFootman);
                    }
                    catch
                    {
                        Royal_Guard deadRoyalGuard = royalGuards.FirstOrDefault(r => r.name.Equals(command[1]));
                        king.BeingAttacked -= deadRoyalGuard.OnKingBeingAttacked;
                        royalGuards.Remove(deadRoyalGuard);
                    }
                }
                else if(command[0] == "Attack")
                {
                        king.TakeAttack();
                }
                command = Console.ReadLine().Split();
            }

        }
    }
}
