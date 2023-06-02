using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {
        public SubMenu(string i_Title, int i_Index) : base(i_Title, i_Index)
        {
            m_ItemInTheEnd = new MenuItem("Back", 0);
        }
        public void OnItemChosen(SubMenu i_ItemChosen)
        {
            if (i_ItemChosen.m_SubMenu.Count != 0)
            {
                Console.Clear();
                i_ItemChosen.ShowSubMenu();
            }
            else if (i_ItemChosen != null)
            {
                Console.Clear();
                i_ItemChosen.Invoke();
                waitToReturn();
                ShowSubMenu();
            }
        }
    }
}
