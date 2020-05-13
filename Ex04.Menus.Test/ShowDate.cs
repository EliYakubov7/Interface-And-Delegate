using System;
using System.Text;
using System.Collections.Generic;
using Ex04.Menus.Interfaces;

namespace Ex04.Menu.Test
{
    public class ShowDate : IExecuteMenuItem
    {
        private const string m_EnterKeyToGoBack = "Enter any key to go back";
        private string m_TodayDate = DateTime.Now.ToShortDateString();

        public void Run()
        {
            Console.Clear();
            Console.WriteLine(m_TodayDate);
            Console.WriteLine(m_EnterKeyToGoBack);
            Console.ReadKey();
        }
    }
}
