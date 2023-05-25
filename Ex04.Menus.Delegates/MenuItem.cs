using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private string m_Title;
        private int m_Index;
        private MenuItem m_Parent;
        private List<MenuItem> m_SubMenu;
        private static MenuItem m_Back = new MenuItem("Back", 0);
        public event Action<MenuItem> ItemChoosen;
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
        public void ShowSubMenu()
        {
            Console.WriteLine(m_Parent.Title);
            foreach (MenuItem item in m_SubMenu)
            {
                item.PrintItem();
            }
            m_Back.PrintItem();
        }
        protected virtual void OnItemChoosen()
        {
            Console.Clear();
            if (m_SubMenu.Count != 0)
            {
                ShowSubMenu();
            }
            else
            {
                ItemChoosen.Invoke(this);
                if (Parent != null)
                {
                    m_Parent.ShowSubMenu();
                }
            }
        }
        public void CheckUserChoice(string i_UserChoice)
        {
            int choice = int.Parse(i_UserChoice);
            if (choice < 0 || choice > m_SubMenu.Count)
            {
                //exception
            }
        }
    }
}
