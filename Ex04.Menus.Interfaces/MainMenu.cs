using Ex04.Menus.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private const string k_EndString = "END";
        MenuItem m_MainMenu;
        public void BuildMenu(MenuItem i_Menu)
        {
            string title = null, indexString = null;
            int index;
            Console.WriteLine(
@"Enter the title and index of each option.
Press END to finish."
                            );
            do
            {
                title = Console.ReadLine();
                if(title == k_EndString)
                {
                    break;
                }
                else
                {
                    indexString = Console.ReadLine();
                    if(int.TryParse(indexString, out index) == false)
                    {
                        //exception
                    }
                    else
                    {
                        i_Menu.SubMenu.Add(new MenuItem(title, index, i_Menu));
                    }
                }
            }while (true);
        }
    }
}
