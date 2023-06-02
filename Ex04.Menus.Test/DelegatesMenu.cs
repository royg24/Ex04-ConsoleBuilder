using Ex04.Menus.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Ex04.Menus.Test
{
    public class DelegatesMenu
    {
        private MainMenu m_MainMenu;

        public MainMenu MainMenu
        {
            get
            {
                return m_MainMenu;
            }
        }
        public void BuildMainMenu()
        {
            m_MainMenu = new MainMenu("Delegates Main Menu");
            SubMenu showDateOrTimeItem = new SubMenu("Show Date/Time", 1);
            SubMenu versionAndCapitals = new SubMenu("Version and Capitals", 2);
            m_MainMenu.AddItemToMenuItem(showDateOrTimeItem);
            m_MainMenu.AddItemToMenuItem(versionAndCapitals);
            SubMenu showDate = new SubMenu("Show Date", 1);
            showDateOrTimeItem.AddItemToMenuItem(showDate);
            showDate.MenuItemChosen += ShowDate_MenuItemChosen;
            SubMenu showTime = new SubMenu("Show Time", 2);
            showDateOrTimeItem.AddItemToMenuItem(showTime);
            showTime.MenuItemChosen += ShowTime_MenuItemChosen;
            SubMenu showVersion = new SubMenu("Show Version", 1);
            versionAndCapitals.AddItemToMenuItem(showVersion);
            showVersion.MenuItemChosen += ShowVersion_MenuItemChosen;
            SubMenu countCapitals = new SubMenu("Count Capitals", 2);
            versionAndCapitals.AddItemToMenuItem(countCapitals);
            countCapitals.MenuItemChosen += CountCapitals_MenuItemChosen;
        }
        public void ShowTime_MenuItemChosen()
        {
            Console.WriteLine("The Current time is {0}:{1}:{2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }
        public void ShowDate_MenuItemChosen()
        {
            Console.WriteLine("The current date is {0}/{1}/{2}", DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
        }
        public void ShowVersion_MenuItemChosen()
        {
            Console.WriteLine("23.2.4.9805");
        }
        public void CountCapitals_MenuItemChosen()
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
