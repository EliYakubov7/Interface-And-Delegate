﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{

    public interface IMenuItem
    {
        string MenuTitle { get; set; }

        void Show();
    }
}
