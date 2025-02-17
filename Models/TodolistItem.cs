namespace TodoList.Models
{
    public class TodolistItem
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public bool IsCompleted { get; set; }
    }
}
