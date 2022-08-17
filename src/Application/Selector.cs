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
        public static void SelectInteraction(King king1, King king2)
        {
            Console.WriteLine("Please select one of the following interactions: \n" +
                "1. Attack \n" +
                "2. Special Attack \n" +
                "3. Run over");

            string decision = Console.ReadLine();

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
    }
}