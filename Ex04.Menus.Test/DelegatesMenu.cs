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
            showDate.ItemChoosen += ShowDate;
            SubMenu showTime = new SubMenu("Show Time", 2);
            showDateOrTimeItem.AddItemToMenuItem(showTime);
            showTime.ItemChoosen += ShowTime;
            SubMenu showVersion = new SubMenu("Show Version", 1);
            versionAndCapitals.AddItemToMenuItem(showVersion);
            showVersion.ItemChoosen += ShowVersion;
            SubMenu countCapitals = new SubMenu("Count Capitals", 2);
            versionAndCapitals.AddItemToMenuItem(countCapitals);
            countCapitals.ItemChoosen += CountCapitals;
        }
        public void ShowTime()
        {
            Console.WriteLine("The Current time is {0}:{1}:{2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }
        public void ShowDate()
        {
            Console.WriteLine("The current date is {0}/{1}/{2}", DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
        }
        public void ShowVersion()
        {
            Console.WriteLine("23.2.4.9805");
        }
        public void CountCapitals()
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
