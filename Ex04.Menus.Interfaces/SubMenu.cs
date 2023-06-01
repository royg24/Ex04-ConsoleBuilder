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
    }
}
