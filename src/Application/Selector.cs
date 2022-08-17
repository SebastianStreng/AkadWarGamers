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
        public void SelectInteraction(King king1, King king2)
        {
            Console.WriteLine("Please select one of the following interactions: \n" +
                "1. Attack \n" +
                "2. Special Attack \n" +
                "3. Run over");
        }
    }
}