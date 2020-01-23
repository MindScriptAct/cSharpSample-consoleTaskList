﻿using ConsoleTodoListApp.Gui;
using ConsoleTodoListApp.Gui.Pictures;
using System;

namespace ConsoleTodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Button button = new Button(2, 2, 30, 5, "Press me");
            button.Draw();


            Diamond diamond = new Diamond(5, 10);
            diamond.Draw();

            Candle candle = new Candle(40, 3);
            candle.Draw();


            Rectangle rectangle = new Rectangle(60, 10, 15, 10);
            rectangle.Draw();

            Rectangle rectangle2 = new Rectangle(60, 7, 5, 7, '+');
            rectangle2.Draw();

            int x = 30; 
            int y = 15;
            int width = 20;
            TextLine textLine = new TextLine(x, y, width, "My super todo list app!");
            textLine.Draw();


            TextLine copirightText = new TextLine(28, 20, 100, "All right reserved, 2020");
            copirightText.Draw();

            Console.ReadKey();

            Console.SetCursorPosition(0, 25);
        }
    }
}
