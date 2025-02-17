namespace TodoList.DTO
{
    public class TodolistItemDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public bool IsCompleted { get; set;}
    }
}
