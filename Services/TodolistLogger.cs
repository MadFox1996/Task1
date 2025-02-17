
namespace TodoList.Services
{
    public class TodolistLogger : ITodolistLogger
    {
        public Guid LifeCycleId { get; set; } = Guid.NewGuid();

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void LogLifeCycle(string service, ILifeCycle lifeCycle)
        {
            Console.WriteLine($"{service}:{lifeCycle.LifeCycleId}");
        }
    }
}
