using TodoList.Models;

namespace TodoList.Services
{
    public interface ITodolistService : ILifeCycle
    {
        IList<TodolistItem> TodolistItems { get; set; }

        IEnumerable<TodolistItem> Get();

        TodolistItem Get(Guid id);

        Guid Add(TodolistItem item);

        Guid Update(TodolistItem item);

        bool Delete(Guid id);
    }
}
