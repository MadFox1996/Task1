using TodoList.Models;

namespace TodoList.Services
{
    public class TodoListService : ITodolistService
    {
        public IList<TodolistItem> TodolistItems { get; set; }

        public Guid LifeCycleId { get; set; } = Guid.NewGuid();

        public TodoListService()
        {
            TodolistItems =
            [
                new TodolistItem() { Id = Guid.NewGuid(), Name = "Task1", IsCompleted = false},
                new TodolistItem() { Id = Guid.NewGuid(), Name = "Task2", IsCompleted = false},
                new TodolistItem() { Id = Guid.NewGuid(), Name = "Task3", IsCompleted = true} 
            ];
        }
        public Guid Add(TodolistItem item)
        {
            item.Id = Guid.NewGuid();
            TodolistItems.Add(item);
            return item.Id;
        }

        public bool Delete(Guid id)
        {
            if (TodolistItems.Any(x => x.Id == id))
            {
                TodolistItems.Remove(Get(id));
                return true;
            }

            return false;
        }

        public IEnumerable<TodolistItem> Get()
        {
            return TodolistItems;
        }

        public TodolistItem? Get(Guid id)
        {
            return TodolistItems.FirstOrDefault(x => x.Id == id);
        }

        public Guid Update(TodolistItem item)
        {
            var itemToUpdate = TodolistItems.FirstOrDefault(x=>x.Id == item.Id);
            if(itemToUpdate != null)
            {
                itemToUpdate.Name = item.Name;
                itemToUpdate.IsCompleted = item.IsCompleted;
                return itemToUpdate.Id;
            }
            else
            {
                throw new Exception("TodolistItem not found");
            }
        }
    }
}