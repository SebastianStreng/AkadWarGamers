//@author: Sebastian Streng
//
using System.Threading;
using Core;
using Application;

//! Presentation-Layer
//
namespace Presentation
{
    /** Klasse "Program" wird benötigt, um das Spiel zu starten
    */

    public class Program
    {
        public static void Main(string[] args)
        {
            /**Instanzen von King-Klasse erzeugen
            */
            King Arthur = new King("King Arthur", 1000, 10, 15, 3);
            King Ludwig = new King("King Ludwig", 1000, 10, 15, 3);

            /** Do-While-Schleife für den Spielverlauf.
            * Ist die Kriegeranzahl von Arthur oder Ludwig kleine oder gleich null, wird das Spiel beendet.
            */
            do
            {
                Console.WriteLine("KING ARTHUR´S VALUES (you): \n" + "Warriors: " + Arthur.warriors);
                Console.WriteLine("strength: " + Arthur.strength);
                Console.WriteLine("weapon strength: " + Arthur.weapon_strength);
                Console.WriteLine("armor strength: " + Arthur.armor_strength + "\n\n");

                Console.WriteLine("KING LUDWIG ´S VALUES (enemy): \n" + "Warriors: " + Ludwig.warriors);
                Console.WriteLine("strength: " + Ludwig.strength);
                Console.WriteLine("weapon strength: " + Ludwig.weapon_strength);
                Console.WriteLine("armor strength: " + Ludwig.armor_strength + "\n\n");

                Console.WriteLine("It´s your turn: \n\n\n\n");
                Selector.SelectInteraction(Arthur, Ludwig);

                Thread.Sleep(3000);
                Console.WriteLine("\n\n\n Enemie´s turn...: ");
                Thread.Sleep(3000);
                getRandomAttack(Ludwig, Arthur);
                Console.WriteLine("\n\n");
            } while (Arthur.warriors > 0 || Ludwig.warriors > 0);
        }

        /** GetRandomAttack() Methode imitiert die KI, indem sie eine Zufällige Auswahl trifft
        */

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