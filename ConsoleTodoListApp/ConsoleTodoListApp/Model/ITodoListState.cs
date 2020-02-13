using System;

namespace ConsoleTodoListApp.Model
{
    public interface ITodoListState
    {
        void Create(string lable, DateTime deadLine, bool isDone = false);

        TodoItemData Read(int id);

        void Modify(int id, string lable, DateTime deadLine, bool isDone);

        void Delete(int id);
    }
}