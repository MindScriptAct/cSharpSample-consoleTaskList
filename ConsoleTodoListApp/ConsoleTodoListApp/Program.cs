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

            int x = 20; 
            int y = 2;
            int width = 2;
            TextLine textLine = new TextLine(x, y, width, "My super todo list app!");
            textLine.Draw();

            Console.ReadKey();

            Console.SetCursorPosition(0, 25);
        }
    }
}
