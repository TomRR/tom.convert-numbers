using System;
using System.Collections.Generic;
using System.Text;

namespace Tom.ConvertNumbers
{
    class Menu
    {
        private IMenu currentMenu;
        public void SetMenu(IMenu currentMenu) { this.currentMenu = currentMenu; }
        public void EnterMenu() { currentMenu.EnterMenu(); }
    }
}
