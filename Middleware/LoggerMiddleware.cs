using TodoList.Services;

namespace TodoList.Middleware
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                Console.WriteLine($"Старт обработки запроса");
                await _next.Invoke(context);
                Console.WriteLine($"Конец обработки запроса");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка обработки запроса: {ex.Message}");
                throw;
            }
        }
    }
}
