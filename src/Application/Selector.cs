using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Selector
    {
        public static bool checker { get; set; }

        public static string decision { get; set; }

        /** SelectInteraction() Methode
         * Lässt den Spieler auswählen, welche Attacke er ausführen möchte.
         * Aufgerufen wird heirbei die Klasse Attack mit dessen Methoden attack(), getSpecialAttack() und runOver().
        * @param: King1 und King2, abgeleitet von Klasse King
        */

        public static void SelectInteraction(King king1, King king2)
        {
            if (king1 != null & king2 != null)
            {
                checker = true;

                Console.WriteLine("Please select one of the following interactions: \n" +
                "1. Attack \n" +
                "2. Special Attack \n" +
                "3. Run over");

                //decision = "4" //for testing;
                decision = Console.ReadLine();

                switch (decision)
                {
                    case "1":
                        Attack.attack(king1, king2);
                        break;

                    case "2":
                        Attack.getSpecialAttack(king1, king2);
                        break;

                    case "3":
                        Attack.runOver(king1, king2);
                        break;

                    default:
                        Console.WriteLine("select interaction failed. Please try again.");
                        break;
                }
            }
            else
            {
                checker = false;
            }
        }
    }
}