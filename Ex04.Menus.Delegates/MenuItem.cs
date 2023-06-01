using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private const string k_ReturnString = "RETURN";
        protected string m_Title;
        protected int m_Index;
        protected Dictionary<int, SubMenu> m_SubMenu;
        protected MenuItem m_ItemInTheEnd;
        public event Action ItemChoosen;
        public string Title
        {
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
        public Dictionary<int, SubMenu> SubMenu
        {
            get
            {
                return m_SubMenu;
            }
        }
        public MenuItem(string i_Title, int i_Index = 0)
        {
            m_Title = i_Title;
            m_Index = i_Index;
            m_SubMenu = new Dictionary<int, SubMenu>();
        }
        protected void PrintItem()
        {
            string message = string.Format("{0} - > {1}", m_Index, m_Title);

            Console.WriteLine(message);
        }
        protected virtual void Show()
        {
            Console.Clear();
            Console.WriteLine("** {0} **", m_Title);
            Console.WriteLine("-----------------------");
            foreach (KeyValuePair<int, SubMenu> item in m_SubMenu)
            {
                item.Value.PrintItem();
            }

            getItemInTheEnd();
            m_ItemInTheEnd.PrintItem();
            Console.WriteLine("-----------------------");
        }
        public void AddItemToMenuItem(SubMenu i_MenuItem)
        {
            m_SubMenu.Add(i_MenuItem.Index, i_MenuItem);
        }
        public void RemoveItemFromMenuItem(MenuItem i_MenuItem)
        {
            m_SubMenu.Remove(i_MenuItem.Index);
        }
        protected virtual void OnItemChoosen()
        {
            if (m_SubMenu.Count != 0)
            {
                showSubMenu();
            }
            else if (ItemChoosen != null)
            {
                Console.Clear();
                ItemChoosen.Invoke();
                waitToReturn();
            }
        }
        private bool isUserChoiceValid(string i_UserChoice, out int o_ChoiceNum)
        {
            bool isValid = false;
            int choiceNumber;

            if (int.TryParse(i_UserChoice, out choiceNumber))
            {
                if (choiceNumber >= 0 && choiceNumber <= m_SubMenu.Count)
                {
                    isValid = true;
                }
            }
            o_ChoiceNum = choiceNumber;
            return isValid;
        }
        private int getValidInput()
        {
            int userVhoiceNumber;
            string userChoiceStr;

            Console.WriteLine("Enter Your Request");
            userChoiceStr = Console.ReadLine();
            while (!isUserChoiceValid(userChoiceStr, out userVhoiceNumber))
            {
                Console.WriteLine("Invalid input. Try again");
                userChoiceStr = Console.ReadLine();
            }

            return userVhoiceNumber;
        }
        public void RunMenu()
        {
            bool isPressedExit = false;
            do
            {
                Show();
                int userChoice = getValidInput();
                if (userChoice == 0)
                {
                    isPressedExit = true;
                }
                else
                {
                    SubMenu[userChoice].OnItemChoosen();
                }
            } while (!isPressedExit);
        }
        private void getItemInTheEnd()
        {
            if (this as MainMenu != null)
            {

            }
            else if (this as SubMenu != null)
            {

            }
        }
        private void showSubMenu()
        {
            Show();
            int choice = getValidInput();
            if (choice != 0)
            {
                m_SubMenu[choice].OnItemChoosen();
                OnItemChoosen();
            }
            else
            {
                return;
            }
        }
        private void waitToReturn()
        {
            string input = null;

            Console.WriteLine("press RETURN to return");
            do
            {
                input = Console.ReadLine();
            } while (input != k_ReturnString);
        }
    }
}
