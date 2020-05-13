using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{

    // $G$ DSN-008 (-10) You should have used polymorphism to implement the different behavior between a sub menu and the main menu.
    public class MainMenu : IMenu
    {
        private readonly List<IMenuItem> r_MenuItemList = new List<IMenuItem>();

        private bool m_IsSubMenu;

        public MainMenu(string i_MenuTitle)
        {
            MenuTitle = i_MenuTitle;
            m_IsSubMenu = false;
        }

        internal MainMenu(string i_MenuTitle, bool i_IsSubMenu)
        {
            MenuTitle = i_MenuTitle;
            m_IsSubMenu = i_IsSubMenu;
        }

        public string MenuTitle { get; set; }

        public void AddItem(string i_Title, IExecuteMenuItem i_ExecuteItem)
        {
            r_MenuItemList.Add(new ExecuteItem(i_ExecuteItem, i_Title));
        }

        public IMenu AddMenu(string i_MenuTitle)
        {
            const bool isSubMenu = true;
            IMenu newMenu = new MainMenu(i_MenuTitle, isSubMenu);
            r_MenuItemList.Add(newMenu);
            return newMenu;
        }

        public void Show()
        {
            bool runMenu = true;
            int userChoice;
            do
            {
                printMenu();
                userChoice = getUserChoice();
                if (userChoice == 0)
                {
                    runMenu = false;
                }
                else
                {
                    r_MenuItemList[userChoice - 1].Show();
                }
            }
            while (runMenu == true);
        }

        private void printMenu()
        {
            Console.Clear();
            Console.WriteLine(MenuTitle + Environment.NewLine + "==================");
            int menuOption = 1;
            foreach(IMenuItem menuItem in r_MenuItemList)
            {
                Console.WriteLine("{0}.{1}", menuOption, menuItem.MenuTitle);
                menuOption += 1;
            }

            if(m_IsSubMenu == true)
            {
                Console.WriteLine("0.Back");
            }
            else
            {
                Console.WriteLine("0.Exit");
            }
        }

        private int getUserChoice()
        {
            Console.WriteLine("Please enter your choice:");
            string input = Console.ReadLine();
            int userSelection;
            bool result = checkUserInput(input);
            while (!result)
            {
                Console.WriteLine("Invalid choice, please select a valid number between 0 - 2");
                input = Console.ReadLine();
                result = checkUserInput(input);
            }

            userSelection = int.Parse(input);
            return userSelection;
        }

        private bool checkUserInput(string i_Input)
        {
            bool returnValue = i_Input.Length == 0;
            int userSelection;
            bool result = int.TryParse(i_Input, out userSelection);
            returnValue = result == true;
            if (userSelection < 0 || userSelection > 2)
            {
                returnValue = false;
            }

            return returnValue;
        }
    }
}
