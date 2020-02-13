using ConsoleTodoListApp.Model;
using System;

namespace ConsoleTodoListApp.Controller
{
    public class TodoListState : ITodoListState
    {
        public TodoListState()
        {
        }

        public void Create(string lable, DateTime deadLine, bool isDone = false)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Modify(int id, string lable, DateTime deadLine, bool isDone)
        {
            throw new NotImplementedException();
        }

        public TodoItemData Read(int id)
        {
            throw new NotImplementedException();
        }
    }
}