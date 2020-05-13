using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            InterfaceMenuTest interfaceTest = new InterfaceMenuTest();
            interfaceTest.Show();
            DelegateMenuTest delegateTest = new DelegateMenuTest();
            delegateTest.Show(); 
        }
    }
}
