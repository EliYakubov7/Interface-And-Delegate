using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
   public class MenuItem
    {
        public delegate void MenuDelegate();


       
        public event MenuDelegate Displaying;

        private string m_MenuTitle;

        public MenuItem(string i_MenuTitle)
        {
            m_MenuTitle = i_MenuTitle;
        }
        
        public string MenuTitle
        {
            get
            {
                return m_MenuTitle;
            }

            set
            {
                m_MenuTitle = value;
            }
        }

        public virtual void Show()
        {
            Console.Clear();
            OnDisplay();
        }

        protected virtual void OnDisplay()
        {
            Displaying?.Invoke();
        }
    }
}
