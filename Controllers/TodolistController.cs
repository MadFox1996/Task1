using Microsoft.AspNetCore.Mvc;
using TodoList.DTO;
using TodoList.Mapper;
using TodoList.Models;
using TodoList.Services;

namespace TodolistProject.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TodolistController : ControllerBase
    {
        private readonly ITodolistService _todolistService;
        private readonly ITodolistLogger _logger;

        public TodolistController(ITodolistLogger logger, ITodolistService todolistService)
        {
            _todolistService = todolistService;
            _logger = logger;
        }

        [HttpGet(Name = nameof(Get))]
        public TodolistItem Get(Guid id)
        {
            LogLifeCycle();
            return _todolistService.Get(id);
        }

        [HttpGet(Name = nameof(GetAll))]
        public IEnumerable<TodolistItem> GetAll()
        {
            LogLifeCycle();
            return _todolistService.Get();
        }

        [HttpPut(Name = nameof(Put))]
        public Guid Put(TodolistItemDTO todolistItem)
        {
            LogLifeCycle();
            return _todolistService.Update(TodolistItemMapper.Map(todolistItem));
        }

        [HttpPost(Name = nameof(Post))]
        public Guid Post(AddTodolistItemDTO addTodolistItem)
        {
            LogLifeCycle();
            return _todolistService.Add(TodolistItemMapper.Map(addTodolistItem));
        }

        [HttpDelete(Name = nameof(Delete))]
        public bool Delete(Guid id)
        {
            LogLifeCycle();
            return _todolistService.Delete(id);
        }

        private void LogLifeCycle()
        {
            _logger.LogLifeCycle(nameof(ITodolistService), _todolistService);
            _logger.LogLifeCycle(nameof(ITodolistLogger), _logger);
        }
    }
}
