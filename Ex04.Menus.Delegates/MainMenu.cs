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
        private const string k_ChooseSubMenu = "S";
        private const string k_ChooseMethod = "M";
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
                if (title == k_EndString)
                {
                    break;
                }
                else
                {
                    indexString = Console.ReadLine();
                    if (int.TryParse(indexString, out index) == false)
                    {
                        //exception
                    }
                    else
                    {
                        i_Menu.SubMenu.Add(new MenuItem(title, index, i_Menu));
                    }
                }
            } while (true);
        }
        public void FillOptionsOfMenu(MenuItem i_Item)
        {
            string userChoice = null;
            string message = null;
            BuildMenu (i_Item);
            foreach(MenuItem item in i_Item.SubMenu)
            {
                message = string.Format("For {0} choose if it has a sub menu or activate a method (S/M)", item.Title);
                userChoice = Console.ReadLine();
                if(userChoice == k_ChooseSubMenu)
                {
                    FillOptionsOfMenu(item);             
                }
                else if(userChoice == k_ChooseMethod)
                {
                    //add method
                }
                else
                {
                    //exception
                }
            }
        }
    }
}
