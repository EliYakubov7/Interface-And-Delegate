using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountDigits : IExecuteMenuItem
    {
        private const string m_EnterKeyToGoBack = "Enter any key to go back";

        public void Run()
        {
            Console.WriteLine("Please enter your sentence:");
            string input = Console.ReadLine();
            int numberOfDigits = countDigitsFromInput(input);
            Console.WriteLine("The system count {0} digits in your sentence", numberOfDigits);
            Console.WriteLine(m_EnterKeyToGoBack);
            Console.ReadKey();
        }

        private int countDigitsFromInput(string i_Input)
        {
            int counter = 0;
            foreach (char letter in i_Input)
            {
                if (char.IsDigit(letter) == true)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
