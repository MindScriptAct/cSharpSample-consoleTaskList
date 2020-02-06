using ConsoleTodoListApp.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Model
{

    /// <summary>
    /// Keeper of menu data.
    /// </summary>
    public class MenuState : IMenuState
    {
        private readonly List<ButtonName> buttonNames;
        private int activeButtonNr;

        public int ActiveButtonNr
        {
            get
            {
                return activeButtonNr;
            }
            set
            {
                if (value >= 0 && value < TotalButtonCount)
                {
                    activeButtonNr = value;
                }
                else
                {
                    throw new IndexOutOfRangeException($"Active button number {value} is out of possible range.");
                }
            }
        }

        public int TotalButtonCount { get; }
        public ButtonName ActiveButtonName
        {
            get
            {
                return buttonNames[ActiveButtonNr];
            }
        }

        public MenuState(List<ButtonName> buttonNames)
        {
            this.buttonNames = buttonNames;
            TotalButtonCount = buttonNames.Count;
        }
    }
}
