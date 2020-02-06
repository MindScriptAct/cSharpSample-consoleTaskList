using ConsoleTodoListApp.Controller;
using ConsoleTodoListApp.Model;
using ConsoleTodoListApp.View;
using System;

namespace ConsoleTodoListApp
{
    /// <summary>
    /// Kikstart our app.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            MenuController menuController = new MenuController(new MainMenuState(), new MainMenuWindow());
            menuController.ShowMenu();

            Console.SetCursorPosition(0, 25);
        }
    }
}
