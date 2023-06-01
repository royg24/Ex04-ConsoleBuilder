using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class InterfaceMenu
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
            m_MainMenu = new MainMenu("Interfaces Main Menu");
            SubMenu showDateOrTimeItem = new SubMenu("Show Date/Time", 1);
            SubMenu versionAndCapitals = new SubMenu("Version and Capitals", 2);
            m_MainMenu.AddItemToMenuItem(showDateOrTimeItem);
            m_MainMenu.AddItemToMenuItem(versionAndCapitals);
            SubMenu showDate = new SubMenu("Show Date", 1);
            showDateOrTimeItem.AddItemToMenuItem(showDate);
            showDate.AddToListeners(new ShowDateListener());
            SubMenu showTime = new SubMenu("Show Time", 2);
            showDateOrTimeItem.AddItemToMenuItem(showTime);
            showTime.AddToListeners(new ShowTimeListener());
            SubMenu showVersion = new SubMenu("Show Version", 1);
            versionAndCapitals.AddItemToMenuItem(showVersion);
            showVersion.AddToListeners(new VersionsListener());
            SubMenu countCapitals = new SubMenu("Count Capitals", 2);
            versionAndCapitals.AddItemToMenuItem(countCapitals);
            countCapitals.AddToListeners(new CapitalsListener());
        }
    }
}
