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

        private static void snowfall(King king1, King king2)
        {
            Console.WriteLine("It starts to snow. The strength of all warriors is reduced by 10 percent. ");
            king1.strength = king1.strength * 0.9;
            king2.strength = king2.strength * 0.9;
        }

        private static void earthquake(King king1, King king2)
        {
            Console.WriteLine("The earth is shaking. Each player loses 15 percent of the warriors");
            king1.warriors = Convert.ToInt32(king1.warriors * 0.85);
            king2.warriors = Convert.ToInt32(king2.warriors * 0.85);
        }

        private static void sunrise(King king1, King king2)
        {
            Console.WriteLine("The sun is shining. The strength of warriors increases 10 percent");
            king1.strength = king1.strength * 1.1;
            king2.strength = king2.strength * 1.1;
        }

        private static void bow_and_arrow(King king1, King king2)
        {
            king2.armor_strength = king2.armor_strength * 0.9;
            king2.warriors = Convert.ToInt32(king2.warriors * 0.85);
            Console.WriteLine(king1.name + " shoots arrows on " + king2.name);
            Console.WriteLine(king2.name + " looses 10 % armor strength and " + king2.warriors + " warriors");
        }

        private static void rain_of_fire(King king1, King king2)
        {
            king2.armor_strength = king2.armor_strength * 0.7;
            king2.warriors = Convert.ToInt32(king2.warriors * 0.75);
            Console.WriteLine(king1.name + "shoots burning arrows on " + king2.name);
            Console.WriteLine(king2.name + " looses 30 % armor strength and " + king2.warriors + " warriors");
        }

        private static void smoke_bomb(King king1, King king2)
        {
            king2.strength = king2.strength * 0.85;
            var difference = king2.warriors * 0.1;
            king2.warriors = Convert.ToInt32(king2.warriors * 0.9);
            Console.WriteLine(king1.name + " throws smokebombs on " + king2.name);
            Console.WriteLine(king2.name + " looses 15 % strength and " + difference + " warriors.");
        }

        private static void additional_warriors(King king1, King king2)
        {
            int added_warriors = RandomGenerator.generateRandom(50, 400);
            king1.warriors = king1.warriors + added_warriors;
            Console.WriteLine(king1.name + " gets support by " + added_warriors + " new warriors. ");
            Console.WriteLine("The Army of " + king1.name + " has now " + king1.warriors + " warriors.");
            Console.WriteLine("The Army of " + king2.name + " is afraid. ");
        }

        private static void ambush(King king1, King king2)
        {
            int warriorloss = RandomGenerator.generateRandom(150, 300);
            king2.warriors = king2.warriors - warriorloss;
            Console.WriteLine(king1.name + " has started an ambush.");
            Console.WriteLine(king2.name + "looses" + warriorloss + " warriors.");
            Console.WriteLine(king2.name + " has " + king2.warriors + " left.");
        }

        private static void health_and_care_package(King king1)
        {
            Console.WriteLine(king1.name + "´s armee gets +2 strength, +2 armor strength, +2 weapon strength. ");
            king1.strength = king1.strength + 2;
            king1.armor_strength = king1.armor_strength + 2;
            king1.weapon_strength = king1.weapon_strength + 2;
        }
    }
}