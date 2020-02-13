using ConsoleTodoListApp.Gui;

namespace ConsoleTodoListApp
{
    internal class TodoListWindow : Window, ITodoListWindow
    {
        public TodoListWindow() : base(0, 0, 120, 30, "TODO LIST!")
        {
        }
    }
}