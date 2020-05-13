using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menu.Test;

namespace Ex04.Menus.Test
{
    internal class DelegateMenuTest
    {
       private Delegates.MainMenu m_Menu = new Delegates.MainMenu("Delegate menu test");

        public DelegateMenuTest()
        {
            Delegates.MainMenu dateTimeMenu = m_Menu.AddMenu("Show Date/Time");
            dateTimeMenu.AddItem("Show date").Displaying += new ShowDate().Run;
            dateTimeMenu.AddItem("Show time").Displaying += new ShowTime().Run;
            Delegates.MainMenu infoAndVersionMenu = m_Menu.AddMenu("Version and digit");
            infoAndVersionMenu.AddItem("Show virsion").Displaying += new ShowVersion().Run;
            infoAndVersionMenu.AddItem("Count digits").Displaying += new CountDigits().Run;
        }

        internal void Show()
        {
            m_Menu.Show();
        }
    }
}