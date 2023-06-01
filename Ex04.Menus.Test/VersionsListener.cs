using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class VersionsListener :IListener
    {
        public void ActionAfterChosen()
        {
            showVersion();
        }
        private void showVersion()
        {
            Console.WriteLine("23.2.4.9805");
        }
    }
}
