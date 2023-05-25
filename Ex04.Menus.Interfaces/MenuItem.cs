using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private string m_Title;
        private int m_Index;
        private MenuItem m_Parent;
        private List<MenuItem> m_SubMenu;
        public string Title {
            get 
            {
                return m_Title; 
            }
        }
        public int Index
        {
            get
            {
                return m_Index;
            }
        }
        public MenuItem Parent
        {
            get
            {
                return m_Parent;
            }
        }
        public List<MenuItem> SubMenu
        {
            get
            {
                return m_SubMenu;
            }
        }
        public MenuItem(string i_Title, int i_Index, MenuItem i_Parent = null)
        {
            m_Title = i_Title;
            m_Index = i_Index;
            m_Parent = i_Parent;
            m_SubMenu = new List<MenuItem>();
        }
        public void PrintItem()
        {
            string message = string.Format("{0}. {1}", m_Index, m_Title);
            Console.WriteLine(message);
        }
    }
}
