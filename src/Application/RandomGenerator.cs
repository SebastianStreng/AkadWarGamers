using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class RandomGenerator
    {
        /** generateRandom() Methode
         * Generiert eine zufällige Zahl Zwischen den Begrenzungen, welche als Parameter definiert werden.
        * @param: int min und int max, stellen Begrenzungen dar.
        */

        public static int generateRandom(int min, int max)
        {
            Random rnd = new Random();

            return min + rnd.Next(max);
        }
    }
}