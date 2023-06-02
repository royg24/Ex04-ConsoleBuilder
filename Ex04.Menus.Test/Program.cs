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
            DelegatesMenu delegatesMenu = new DelegatesMenu();
            delegatesMenu.BuildMainMenu();
            delegatesMenu.MainMenu.RunMenu();

            InterfaceMenu interfaceMenu = new InterfaceMenu();
            interfaceMenu.BuildMainMenu();
            interfaceMenu.MainMenu.RunMenu();
        }
    }
}
