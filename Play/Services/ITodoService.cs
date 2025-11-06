using Play.Models;
using System.Collections.Generic;

namespace Play.Services
{
    public interface ITodoService
    {
        List<TodoItem> GetAll();
        TodoItem Get(int id);
        void Add(TodoItem item);
        void Update(TodoItem item);
        void Delete(int id);
    }
}