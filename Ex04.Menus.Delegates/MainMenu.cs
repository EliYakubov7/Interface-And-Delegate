using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{

    // $G$ DSN-008 (-10) You should have used polymorphism to implement the different behavior between a sub menu and the main menu.
    public class MainMenu : MenuItem
    {
        private readonly List<MenuItem> r_MenuItemList = new List<MenuItem>();
        private bool m_IsSubMenu;

        public MainMenu(string i_MenuTitle) : base(i_MenuTitle)
        {
            m_IsSubMenu = false;
        }

        internal MainMenu(string i_MenuTitle, bool i_IsSubMenu) : base(i_MenuTitle)
        {
            m_IsSubMenu = i_IsSubMenu;
        }

        public MainMenu AddMenu(string i_MenuTitle)
        {
            const bool isSubMenu = true;
            MainMenu newMenu = new MainMenu(i_MenuTitle, isSubMenu);
            r_MenuItemList.Add(newMenu);
            return newMenu;
        }

        public MenuItem AddItem(string i_Title)
        {
            MenuItem newItem = new MenuItem(i_Title);
            r_MenuItemList.Add(newItem);
            return newItem;
        }

        public override void Show()
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

            foreach (MenuItem menuItem in r_MenuItemList)
            {
                Console.WriteLine("{0}.{1}", menuOption, menuItem.MenuTitle);
                menuOption += 1;
            }

            if (m_IsSubMenu == true)
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