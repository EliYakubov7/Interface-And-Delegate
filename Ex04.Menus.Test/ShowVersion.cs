using System;
using System.Text;
using System.Collections.Generic;
using Ex04.Menus.Interfaces;

namespace Ex04.Menu.Test
{
    public class ShowVersion : IExecuteMenuItem
    {
        private const string m_EnterKeyToGoBack = "Enter any key to go back";
        private string m_Version = "19.2.4.32";

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(m_Version);
            Console.WriteLine(m_EnterKeyToGoBack);
            Console.ReadKey();
        }
    }
}
