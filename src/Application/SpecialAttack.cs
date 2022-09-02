using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class SpecialAttack
    {
        public static bool checker { get; set; }

        /** startSpecialAttack() Methode
        * Einzige public-Methode, fässt alle anderen Methoden dieser Klasse zusammen.
        * Generiert eine Zufallszahl zwischen 1 und 4.
        * Zufallszahl entscheidet, ob environment(), distance_move(), help() oder nichts aufgerufen wird.
        * @param: King1 und King2, abgeleitet von Klasse King
        */

        public static void startSpecialAttack(King king1, King king2)
        {
            int selector = RandomGenerator.generateRandom(1, 4);
            if (king1 != null & king2 != null)
            {
                checker = true;

                switch (selector)
                {
                    case 1:
                        environment(king1, king2);
                        break;

                    case 2:
                        distance_move(king1, king2);
                        break;

                    case 3:
                        help(king1, king2);
                        break;

                    case 4:
                        Console.WriteLine("nothing happens");
                        break;

                    default:
                        Console.WriteLine("something went wrong.");
                        break;
                }
            }
            else
            {
                checker = false;
            }
        }

        /** environment() Methode
         * stellt Umweltereignisse dar.
         * generiert eine Zufallszahl zwischen 1 und 3.
         * Zufallszahl entscheidet, ob snowfall(), earthquake() oder sunrise() aufgerufen wird.
        * @param: King1 und King2, abgeleitet von Klasse King
        */

        private static void environment(King king1, King king2)
        {
            int pickedSpecialAttackEnvironment = RandomGenerator.generateRandom(1, 3);

            switch (pickedSpecialAttackEnvironment)
            {
                case 1:
                    snowfall(king1, king2);
                    break;

                case 2:
                    earthquake(king1, king2);
                    break;

                case 3:
                    sunrise(king1, king2);
                    break;
            }
        }

        /** distance_move() Methode
         * stellt einen Angriff aus der Distanz dar.
         * generiert eine Zufallszahl zwischen 1 und 3.
         * Zufallszahl entscheidet, ob bow_and_arrow(), rain_of_fire() oder smoke_bomb() aufgerufen wird.
        * @param: King1 und King2, abgeleitet von Klasse King
        */

        private static void distance_move(King king1, King king2)
        {
            int pickedSpecialAttackDistance_move = RandomGenerator.generateRandom(1, 3);

            switch (pickedSpecialAttackDistance_move)
            {
                case 1:
                    bow_and_arrow(king1, king2);
                    break;

                case 2:
                    rain_of_fire(king1, king2);
                    break;

                case 3:
                    smoke_bomb(king1, king2);
                    break;
            }
        }

        /** help() Methode
         * stellt statt einem Angriff eine aktive Hilfe für den Spieler, der am Zug ist dar.
         * generiert eine Zufallszahl zwischen 1 und 3.
         * Zufallszahl entscheidet, ob additional_warriors(), anbush() oder health_and_care_package() aufgerufen wird.
        * @param: King1 und King2, abgeleitet von Klasse King
        */

        private static void help(King king1, King king2)
        {
            int pickedSpecialAttackHelp = RandomGenerator.generateRandom(1, 3);

            switch (pickedSpecialAttackHelp)
            {
                case 1:
                    additional_warriors(king1, king2);
                    break;

                case 2:
                    ambush(king1, king2);
                    break;

                case 3:
                    health_and_care_package(king2);
                    break;
            }
        }

        /** snowfall() Methode
         * stellt einen Schneesturm dar.
         * Beide Spieler verlieren 10% ihrer Stärke.
        * @param: King1 und King2, abgeleitet von Klasse King
        */

        private static void snowfall(King king1, King king2)
        {
            Console.WriteLine("It starts to snow. The strength of all warriors is reduced by 10 percent. ");
            king1.strength = king1.strength * 0.9;
            king2.strength = king2.strength * 0.9;
        }

        /** earthquake() Methode
         * Stellt einen Erdbeben dar.
         * Beide Spieler verlieren 15 Prozent ihrer Krieger.
        * @param: King1 und King2, abgeleitet von Klasse King
        */

        private static void earthquake(King king1, King king2)
        {
            Console.WriteLine("The earth is shaking. Each player loses 15 percent of the warriors");
            king1.warriors = Convert.ToInt32(king1.warriors * 0.85);
            king2.warriors = Convert.ToInt32(king2.warriors * 0.85);
        }

        /** sunrise() Methode
         * Stellt Sonnenschein dar.
         * Beide Spieler gewinnen 10% an Stärke.
        * @param: King1 und King2, abgeleitet von Klasse King
        */

        private static void sunrise(King king1, King king2)
        {
            Console.WriteLine("The sun is shining. The strength of warriors increases 10 percent");
            king1.strength = king1.strength * 1.1;
            king2.strength = king2.strength * 1.1;
        }

        /** bow_and_arrow() Methode
         * Stellt einen Angriff mit Pfeil und Bogen dar.
         * Gegner verliert 20 Prozent an Rüstungsstärke und 15 Prozent Krieger.
        * @param: King1 und King2, abgeleitet von Klasse King
        */

        private static void bow_and_arrow(King king1, King king2)
        {
            king2.armor_strength = king2.armor_strength * 0.8;
            var difference = king2.warriors * 0.15;
            king2.warriors = Convert.ToInt32(king2.warriors * 0.85);
            Console.WriteLine(king1.name + " shoots arrows on " + king2.name);
            Console.WriteLine(king2.name + " looses 20 % armor strength and " + difference + " warriors");
        }

        /** rain_of_fire() Methode
         * stellt einen brennenden Pfeilregen dar.
         * Gegner verliert 40 Prozent Rüstungsstärke und 25 Prozent Krieger.
        * @param: King1 und King2, abgeleitet von Klasse King
        */

        private static void rain_of_fire(King king1, King king2)
        {
            king2.armor_strength = king2.armor_strength * 0.6;
            var difference = king2.warriors * 0.25;
            king2.warriors = Convert.ToInt32(king2.warriors * 0.75);
            Console.WriteLine(king1.name + "shoots burning arrows on " + king2.name);
            Console.WriteLine(king2.name + " looses 40 % armor strength and " + difference + " warriors");
        }

        /** smoke_bomb() Methode
         * Stellt einen Angriff mit einer Rauchbombe dar.
         * Gegner verliert 15 Prozent Stärke und 10 Prozent Krieger.
        * @param: King1 und King2, abgeleitet von Klasse King
        */

        private static void smoke_bomb(King king1, King king2)
        {
            king2.strength = king2.strength * 0.85;
            var difference = king2.warriors * 0.1;
            king2.warriors = Convert.ToInt32(king2.warriors * 0.9);
            Console.WriteLine(king1.name + " throws smokebombs on " + king2.name);
            Console.WriteLine(king2.name + " looses 15 % strength and " + difference + " warriors.");
        }

        /** additional_warriors() Methode
         * Stellt Hilfe durch zusätzliche Krieger dar.
         * Angreifer bekommt zwischen 50 und 400 zusätzliche Krieger.
        * @param: King1 und King2, abgeleitet von Klasse King
        */

        private static void additional_warriors(King king1, King king2)
        {
            int added_warriors = RandomGenerator.generateRandom(50, 400);
            king1.warriors = king1.warriors + added_warriors;
            Console.WriteLine(king1.name + " gets support by " + added_warriors + " new warriors. ");
            Console.WriteLine("The Army of " + king1.name + " has now " + king1.warriors + " warriors.");
            Console.WriteLine("The Army of " + king2.name + " is afraid. ");
        }

        /** ambush() Methode
         * stellt einen Hinterhalt dar.
         * Gegner verliert zwischen 150 und 300 Kriegern.
        * @param: King1 und King2, abgeleitet von Klasse King
        */

        private static void ambush(King king1, King king2)
        {
            int warriorloss = RandomGenerator.generateRandom(150, 300);
            king2.warriors = king2.warriors - warriorloss;
            Console.WriteLine(king1.name + " has started an ambush.");
            Console.WriteLine(king2.name + "looses" + warriorloss + " warriors.");
            Console.WriteLine(king2.name + " has " + king2.warriors + " left.");
        }

        /** health_and_care_package() Methode
         * Stellt ein Gesundheitspaket dar.
         * Angreifer bekommt jeweils 2 Punkte auf alle Stärken.
        * @param: King1 und King2, abgeleitet von Klasse King
        */

        private static void health_and_care_package(King king1)
        {
            Console.WriteLine(king1.name + "´s armee gets +2 strength, +2 armor strength, +2 weapon strength. ");
            king1.strength = king1.strength + 2;
            king1.armor_strength = king1.armor_strength + 2;
            king1.weapon_strength = king1.weapon_strength + 2;
        }
    }
}