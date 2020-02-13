using ConsoleTodoListApp.Constants;
using ConsoleTodoListApp.Model;
using System;

namespace ConsoleTodoListApp.Controller
{
    internal class TodoListController : IAppController
    {
        private ITodoListState todoListState;
        private ITodoListWindow todoListWindow;

        public TodoListController(ITodoListState todoListState, ITodoListWindow todoListWindow)
        {
            this.todoListState = todoListState;
            this.todoListWindow = todoListWindow;
        }

        public AppMode Execute()
        {
            todoListWindow.Draw();

            Console.ReadKey(true);

            return AppMode.Menu;
        }
    }
}