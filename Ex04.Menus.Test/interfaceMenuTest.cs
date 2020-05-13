using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;
using Ex04.Menu.Test;

namespace Ex04.Menus.Test
{
    internal class InterfaceMenuTest
    {
        private Interfaces.MainMenu m_Menu = new Interfaces.MainMenu("Interface menu test");

        public InterfaceMenuTest()
        {
            Interfaces.IMenu dateTimeMenu = m_Menu.AddMenu("Show Date/Time");
            dateTimeMenu.AddItem("Show date", new ShowDate());
            dateTimeMenu.AddItem("Show time", new ShowTime());
            Interfaces.IMenu versionAndDigitMenu = m_Menu.AddMenu("Version and digit");
            versionAndDigitMenu.AddItem("Show version", new ShowVersion());
            versionAndDigitMenu.AddItem("Count digits", new CountDigits());
        }

        public void Show()
        {
            m_Menu.Show();
        }
    }
}