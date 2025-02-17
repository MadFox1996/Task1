namespace TodoList.Services
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddTodolistServices(this IServiceCollection services)
        {
            services.AddSingleton<ITodolistService, TodoListService>();
            services.AddScoped<ITodolistLogger, TodolistLogger>();
            return services;
        }
    }
}
