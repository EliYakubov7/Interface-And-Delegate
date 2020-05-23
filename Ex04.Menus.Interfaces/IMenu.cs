using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{

    public interface IMenu : IMenuItem
    {
        IMenu AddMenu(string i_Title);

        void AddItem(string i_Title, IExecuteMenuItem i_ExecuteItem);
    }
}
