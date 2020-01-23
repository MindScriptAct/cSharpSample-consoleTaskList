using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Gui
{
    class TextLine : GuiObject
    {
        private string data;

        public bool IsCentered;

        public TextLine(int x, int y, int width, string data, bool isCentered = false) : base(x, y, width, 1)
        {
            this.data = data;
            IsCentered = isCentered;
        }

        public override void Draw()
        {
            if (IsCentered && data.Length < Width)
            {
                Console.SetCursorPosition(X + (Width - data.Length) / 2, Y);
                Console.Write(data);
            }
            else
            {
                Console.SetCursorPosition(X, Y);
                string printData = data;
                if (data.Length > Width)
                {
                    printData = data.Substring(0, Width);
                }
                Console.Write(printData);
            }
        }
    }
}
