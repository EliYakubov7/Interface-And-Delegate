using System;
using System.Text;
using System.Collections.Generic;
using Ex04.Menus.Interfaces;

namespace Ex04.Menu.Test
{
    public class ShowTime : IExecuteMenuItem
    {
        private const string m_EnterKeyToGoBack = "Enter any key to go back";
        private string m_NowTime = DateTime.Now.ToShortTimeString();

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(m_NowTime);
            Console.WriteLine(m_EnterKeyToGoBack);
            Console.ReadKey();
        }
    }
}
