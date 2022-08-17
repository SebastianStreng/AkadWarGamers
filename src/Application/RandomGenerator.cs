using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class RandomGenerator
    {
        public static int generateRandom(int min, int max)
        {
            Random rnd = new Random();

            return min + rnd.Next(max);
        }
    }
}