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

            AppController app = new AppController();
            app.Start();



            Console.SetCursorPosition(0, 25);
        }
    }
}
