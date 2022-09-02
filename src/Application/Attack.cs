using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Application
{
    public class Attack
    {
        /** Attack() Methode
         * Reduziert die Gegnerarmee um 30 Prozent.
         * Berechnet die bisherige Summe aus allen Stärken der beiden Könige.
         * Wenn die Summe der Stärken des Angreifers höher ist als die des Gegners werden die Krieger des Gegners
         * erneut um die Summe reduziert, andernfalls werden die Krieger der Gegner um die Summe ergänzt.
         * @param: King1 und King2, abgeleitet von Klasse King
        */

        public static void attack(King king1, King king2)
        {
            var armeeStrenghtKing1 = king1.strength + king1.armor_strength + king1.weapon_strength;
            var armeeStrenghtKing2 = king2.strength + king2.armor_strength + king2.weapon_strength;

            king2.warriors = Convert.ToInt32(king2.warriors * 0.7);

            if (armeeStrenghtKing1 > armeeStrenghtKing2)
            {
                king2.warriors = Convert.ToInt32(king2.warriors - armeeStrenghtKing1);
            }
            if (armeeStrenghtKing1 < armeeStrenghtKing2)
            {
                king2.warriors = Convert.ToInt32(king2.warriors + armeeStrenghtKing2);
            }

            Console.WriteLine($"{king1.name} has attacked {king2.name}´s armee. " +
                $"\n {king2.name} has now {king2.warriors} warriors left.");
        }

        /** runOver() Methode
        * lässt sich von RandomGenerator.generateRandom() eine Zufallszahl
        * zwischen 1 und der Anzahl der Krieger im Gegnerteam erstellen.
        * Gegner verliert und Angreifer bekommt die zufallsgenerierte Anzahl an Kriegern.
        * Angreifer bekommt des Weiteren 20% auf alle Stärken.
        * @param: King1 und King2, abgeleitet von Klasse King
        */

        public static void runOver(King king1, King king2)
        {
            int runOverIndicator = RandomGenerator.generateRandom(1, king2.warriors);
            king2.warriors = king2.warriors - runOverIndicator;
            king1.warriors = king1.warriors + runOverIndicator;
            king1.weapon_strength = king1.weapon_strength * 1.2;
            king1.armor_strength = king1.armor_strength * 1.2;
            king1.strength = king1.strength * 1.2;
            Console.WriteLine($"{runOverIndicator} warriors left {king2.name}´s armee and switched sites. \n" +
                $"{king1.name} has now {king1.warriors} warriors.\n" +
                $"Each strength of {king1.name}´s armee increased by 20%");
        }

        /** getSpecialAttack() Methode
         * ruft SpecialAttack.startSpecialAttack() auf.
        * @param: King1 und King2, abgeleitet von Klasse King
        */

        public static void getSpecialAttack(King king1, King king2)
        {
            SpecialAttack.startSpecialAttack(king1, king2);
        }
    }
}