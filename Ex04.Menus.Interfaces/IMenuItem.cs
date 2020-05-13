using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{

    // $G$ DSN-999 (-2) The interface methods declarations should be more generic, (without the limitations of the input parameters).
    public interface IMenuItem
    {
        string MenuTitle { get; set; }

        void Show();
    }
}
