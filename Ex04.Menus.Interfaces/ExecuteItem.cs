using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    internal class ExecuteItem : IMenuItem
    {
        private readonly IExecuteMenuItem r_ExecuteItem;

        public ExecuteItem(IExecuteMenuItem i_ExecuteItem, string i_MenuTitle)
        {
            MenuTitle = i_MenuTitle;
            r_ExecuteItem = i_ExecuteItem;
        }

        public string MenuTitle { get; set; }

        public void Show()
        {
            Console.Clear();
            r_ExecuteItem.Run();
        }
    }
}
