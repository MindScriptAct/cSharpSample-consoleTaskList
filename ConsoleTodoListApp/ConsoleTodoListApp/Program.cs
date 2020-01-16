using ConsoleTodoListApp.Gui;
using System;

namespace ConsoleTodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 5, 15, 10);
            rectangle.Draw();

            Rectangle rectangle2 = new Rectangle(3, 7, 5, 7, '+');
            rectangle2.Draw();

            Console.ReadKey();

            Console.SetCursorPosition(0, 25);
        }
    }
}
