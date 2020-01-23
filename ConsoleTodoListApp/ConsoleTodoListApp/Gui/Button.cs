using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Gui
{
    class Button : Rectangle
    {
        private TextLine lable;



        public Button(int x, int y, int width, int height, string lableText) : base(x, y, width, height, '#')
        {
            lable = new TextLine(x + 1, y + 1 + ((height - 2) / 2) , width - 2, lableText, true);
        }

        public override void Draw()
        {
            base.Draw();
            lable.Draw();
        }
    }
}
