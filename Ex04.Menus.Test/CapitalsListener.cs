using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class CapitalsListener : IListener
    {
        public void ActionAfterChosen()
        {
            countCapitals();
        }
        private void countCapitals()
        {
            Console.WriteLine("Enter a sentence");
            string str = Console.ReadLine();
            int countCapitals = 0;
            foreach (char item in str)
            {

                if (char.IsUpper(item))
                {
                    countCapitals++;
                }
            }
            Console.WriteLine("There are {0} capitals", countCapitals);
        }
    }
}
