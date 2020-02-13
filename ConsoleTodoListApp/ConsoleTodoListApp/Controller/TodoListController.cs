using ConsoleTodoListApp.Model;
using System;

namespace ConsoleTodoListApp.Controller
{
    internal class TodoListController
    {
        private ITodoListState todoListState;
        private ITodoListWindow todoListWindow;

        public TodoListController(ITodoListState todoListState, ITodoListWindow todoListWindow)
        {
            this.todoListState = todoListState;
            this.todoListWindow = todoListWindow;
        }

        internal void Show()
        {
            todoListWindow.Draw();
        }
    }
}