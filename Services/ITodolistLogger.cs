namespace TodoList.Services
{
    public interface ITodolistLogger : ILifeCycle
    {
        void Log(string message);

        void LogLifeCycle(string sevice, ILifeCycle lifeCycle);
    }
}
