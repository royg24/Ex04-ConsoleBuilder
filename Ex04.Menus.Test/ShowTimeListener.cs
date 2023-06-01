using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class ShowTimeListener : IListener
    {
        public void ActionAfterChosen()
        {
            showTime();
        }
        private void showTime()
        {
            Console.WriteLine("The Current time is {0}:{1}:{2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }
    }
}
