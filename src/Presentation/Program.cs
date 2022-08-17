using System.Threading;
using Core;
using Application;

namespace Presentation
{
    public class TestProgram
    {
        public static void Main(string[] args)
        {
            King Arthur = new King("King Arthur", 1000, 10, 15, 3);
            King Ludwig = new King("King Ludwig", 1000, 10, 15, 3);

            do
            {
                Console.WriteLine("KING ARTHUR´S VALUES: \n" + "Warriors: " + Arthur.warriors);
                Console.WriteLine("strength: " + Arthur.strength);
                Console.WriteLine("weapon strength: " + Arthur.weapon_strength);
                Console.WriteLine("armor strength: " + Arthur.armor_strength + "\n\n");

                Console.WriteLine("KING LUDWIG ´S VALUES: \n" + "Warriors: " + Ludwig.warriors);
                Console.WriteLine("strength: " + Ludwig.strength);
                Console.WriteLine("weapon strength: " + Ludwig.weapon_strength);
                Console.WriteLine("armor strength: " + Ludwig.armor_strength + "\n\n");

                Console.WriteLine("It´s your turn: \n\n\n\n");
                Selector.SelectInteraction(Arthur, Ludwig);

                Thread.Sleep(3000);
                Console.WriteLine("\n\n\n Enemie´s turn: ");
                Thread.Sleep(3000);
                getRandomAttack(Ludwig, Arthur);
                Console.WriteLine("\n\n");
            } while (Arthur.warriors > 0 || Ludwig.warriors > 0);
        }

        private static void getRandomAttack(King king1, King king2)
        {
            int randomPick = RandomGenerator.generateRandom(1, 3);

            switch (randomPick)
            {
                case 1:
                    Attack.attack(king1, king2);
                    break;

                case 2:
                    Attack.runOver(king1, king2);
                    break;

                case 3:
                    Attack.getSpecialAttack(king1, king2);
                    break;
            }
        }
    }
}