using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.View
{
    interface IMenuWindow
    {
        public void SetButtonActive(ButtonName buttonName);
        public void Draw();
    }
}
