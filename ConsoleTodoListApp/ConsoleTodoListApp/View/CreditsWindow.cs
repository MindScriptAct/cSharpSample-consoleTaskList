using ConsoleTodoListApp.Gui;
using ConsoleTodoListApp.Gui.Pictures;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.View
{
    public class CreditsWindow : Window, ICreditsWindow
    {
        private Diamond diamond;
        private TextLine alnaText1;
        private TextLine alnaText2;
        private TextLine alnaText3;
        private Button backButton;

        public CreditsWindow() : base(0, 0, 120, 30, "! CREDITS !")
        {
            diamond = new Diamond(50, 5);
            alnaText1 = new TextLine(10, 13, 100, "                       ", true, ConsoleColor.Red, ConsoleColor.Yellow);
            alnaText2 = new TextLine(10, 14, 100, "     Done in ALNA!     ", true, ConsoleColor.Red, ConsoleColor.Yellow);
            alnaText3 = new TextLine(10, 15, 100, "                       ", true, ConsoleColor.Red, ConsoleColor.Yellow);
            backButton = new Button(45, 20, 30, 7, "<< Back");
        }

        public override void Draw()
        {
            base.Draw();
            diamond.Draw();
            alnaText1.Draw();
            alnaText2.Draw();
            alnaText3.Draw();
            backButton.Draw();

        }
    }
}
