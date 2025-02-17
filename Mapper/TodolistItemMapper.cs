using TodoList.DTO;
using TodoList.Models;

namespace TodoList.Mapper
{
    public static class TodolistItemMapper
    {
        public static TodolistItem Map(AddTodolistItemDTO addTodolistItemDto)
        {
            return new TodolistItem { Name = addTodolistItemDto.Name, IsCompleted = addTodolistItemDto.IsCompleted };
        }

        public static TodolistItem Map(TodolistItemDTO todolistItemDto)
        {
            return new TodolistItem { Id = todolistItemDto.Id, Name = todolistItemDto.Name, IsCompleted = todolistItemDto.IsCompleted };
        }
    }
}
