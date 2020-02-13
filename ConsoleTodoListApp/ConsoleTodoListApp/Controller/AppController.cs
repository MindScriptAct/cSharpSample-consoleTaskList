using ConsoleTodoListApp.Constants;
using ConsoleTodoListApp.Model;
using ConsoleTodoListApp.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Controller
{
    class AppController
    {
        private AppMode appMode;

        private Dictionary<AppMode, IAppController> controllers = new Dictionary<AppMode, IAppController>();


        public AppController()
        {
            SetUp();
        }

        private void SetUp()
        {
            controllers.Add(AppMode.Menu, new MenuController(new MainMenuState(), new MainMenuWindow()));
            controllers.Add(AppMode.Credits, new CreditsController(new CreditsWindow()));
            controllers.Add(AppMode.ToDoList, new TodoListController(new TodoListState(), new TodoListWindow()));

            appMode = AppMode.Menu;
        }

        internal void Start()
        {
            while(appMode != AppMode.Exit )
            {
                appMode = controllers[appMode].Execute();
            }
        }
    }
}
