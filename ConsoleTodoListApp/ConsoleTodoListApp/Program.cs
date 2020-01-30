using ConsoleTodoListApp.Gui;
using ConsoleTodoListApp.Gui.Pictures;
using System;
using System.Collections.Generic;

namespace ConsoleTodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int menuY = 10;
            int menuX = 15;
            int menuGaps = 25;
            int menuButtonWidth = 20;
            int menuButtonHeight = 5;

            List<string> menuLables = new List<string>() { "Start", "Credit", "Quit" };
            List<Button> menuButtuns = new List<Button>();

            for (int i = 0; i < menuLables.Count; i++)
            {
                Button button = new Button(menuX + menuGaps * i, menuY, menuButtonWidth, menuButtonHeight, menuLables[i]);
                button.Draw();
                menuButtuns.Add(button);
            }

            menuButtuns[1].Activate();

            /*
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

            */
            Console.SetCursorPosition(0, 25);
        }
    }
}
