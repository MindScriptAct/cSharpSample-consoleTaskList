using ConsoleTodoListApp.Model;
using ConsoleTodoListApp.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Controller
{

    /// <summary>
    /// Will controll how menu works.
    /// </summary>
    class MenuController
    {
        private readonly IMenuState menuState;
        private readonly IMenuWindow menuWindow;
        private bool showMenu;

        public MenuController(IMenuState menuState, IMenuWindow menuWindow)
        {
            this.menuState = menuState;
            this.menuWindow = menuWindow;
            showMenu = true;
        }

        public void ShowMenu()
        {
            DrawMenuState();

            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();

                switch (keyinfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        // change state
                        if (menuState.ActiveButtonNr > 0)
                        {
                            menuState.ActiveButtonNr--;
                        }
                        else
                        {
                            menuState.ActiveButtonNr = menuState.TotalButtonCount - 1;
                        }
                        // draw state
                        DrawMenuState();
                        break;
                    case ConsoleKey.RightArrow:
                        // change state
                        if (menuState.ActiveButtonNr < menuState.TotalButtonCount - 1)
                        {
                            menuState.ActiveButtonNr++;
                        }
                        else
                        {
                            menuState.ActiveButtonNr = 0;
                        }
                        // draw new state
                        DrawMenuState();
                        break;
                    case ConsoleKey.Home:
                        menuState.ActiveButtonNr = 0;
                        DrawMenuState();
                        break;
                    case ConsoleKey.End:
                        menuState.ActiveButtonNr = menuState.TotalButtonCount;
                        DrawMenuState();
                        break;
                    case ConsoleKey.Enter:

                        switch (menuState.ActiveButtonName)
                        {
                            case ButtonName.Start:
                                throw new NotImplementedException("start todo app");
                                break;
                            case ButtonName.Credits:
                                throw new NotImplementedException("Show credits");
                                break;
                            case ButtonName.Quit:
                                QuitMenu();
                                break;
                            default:
                                break;
                        }

                        // check what is active...
                        // do stuff..
                        Console.WriteLine("Enter");
                        break;
                    case ConsoleKey.Escape:
                        // exit. app..
                        QuitMenu();
                        break;
                    default:
                        break;
                }
            }
            while (showMenu);
        }

        private void QuitMenu()
        {
            showMenu = false;
        }

        private void DrawMenuState()
        {
            menuWindow.SetButtonActive(menuState.ActiveButtonName);
            menuWindow.Draw();
        }
    }
}
