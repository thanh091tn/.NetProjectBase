using Request;

namespace Service.Todo
{
    public interface ITodoServices
    {
        Task<bool> GetTodoServices(TodoRequest request);
    }
}
