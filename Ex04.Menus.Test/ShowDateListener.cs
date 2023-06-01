using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDateListener : IListener
    {
        public void ActionAfterChosen()
        {
            showDate();
        }
        private void showDate()
        {
            Console.WriteLine("The current date is {0}/{1}/{2}", DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
        }
    }
}
