using ConsoleTodoListApp.Constants;
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
    public class MenuController : IAppController
    {
        private readonly IMenuState menuState;
        private readonly IMenuWindow menuWindow;

        private int test;

        public MenuController(IMenuState menuState, IMenuWindow menuWindow)
        {
            this.menuState = menuState;
            this.menuWindow = menuWindow;
        }

        public AppMode Execute()
        {
            bool showMenu = true;
            AppMode retVal = AppMode.Exit;

            void QuitMenu()
            {
                showMenu = false;
                retVal = AppMode.Exit;
            }

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
                        // check what is active, for next step.
                        switch (menuState.ActiveButtonName)
                        {
                            case ButtonName.Start:
                                retVal = AppMode.ToDoList;
                                break;
                            case ButtonName.Credits:
                                retVal = AppMode.Credits;
                                break;
                            case ButtonName.Quit:
                                QuitMenu();
                                break;
                            default:
                                break;
                        } 
                        // no need to show menu.
                        showMenu = false;
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

            return retVal;
        }



        private void DrawMenuState()
        {
            menuWindow.SetButtonActive(menuState.ActiveButtonName);
            menuWindow.Draw();
        }
    }
}
