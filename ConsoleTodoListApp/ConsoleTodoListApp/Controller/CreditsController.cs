using ConsoleTodoListApp.Constants;
using ConsoleTodoListApp.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Controller
{
    class CreditsController : IAppController
    {
        private ICreditsWindow creditsWindow;

        public CreditsController(ICreditsWindow creditsWindow)
        {
            this.creditsWindow = creditsWindow;
        }

        public AppMode Execute()
        {
            creditsWindow.Draw();
            Console.ReadKey(true);
            return AppMode.Menu;
        }
    }
}
