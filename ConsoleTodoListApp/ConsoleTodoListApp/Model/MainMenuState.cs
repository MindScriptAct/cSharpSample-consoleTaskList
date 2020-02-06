using ConsoleTodoListApp.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Model
{
    public class MainMenuState : MenuState
    {
        public MainMenuState() : base(new List<ButtonName>() { ButtonName.Start, ButtonName.Credits, ButtonName.Quit })
        {
        }

    }
}
