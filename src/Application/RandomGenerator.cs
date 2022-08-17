using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class RandomGenerator
    {
        public static int generateRadom(int min, int max)
        {
            Random rnd = new Random();

            return min + rnd.Next(max);
        }
    }
}