using Ex04.Menus.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ex04.Menus.Delegates.MenuItem;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            //DelegatesMenu dm = new DelegatesMenu();
            //dm.BuildMainMenu();
            //dm.MainMenu.RunMenu();

            InterfaceMenu im = new InterfaceMenu();
            im.BuildMainMenu();
            im.MainMenu.RunMenu();
        }
    }
}
