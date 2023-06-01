using Ex04.Menus.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : MenuItem
    {
        public MainMenu(string i_Title, int i_Index = 0) : base(i_Title, i_Index)
        {
            m_ItemInTheEnd = new MenuItem("Exit", 0);
        }
        public void RunMenu()
        {
            bool isPressedExit = false;
            do
            {
                Show();
                int userChoice = GetValidInput();
                if (userChoice == 0)
                {
                    isPressedExit = true;
                }
                else
                {
                    SubMenu[userChoice].ShowSubMenu();
                }
            } while (!isPressedExit);
        }
    }
}
