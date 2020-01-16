using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Gui
{
    class TextLine
    {
        private int x;
        private int y;
        private int width;
        private string data;

        public TextLine(int x, int y, int width, string data)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.data = data;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(data.Substring(0, width));

        }
    }
}
