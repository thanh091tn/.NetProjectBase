using WebApplication2.Request;

namespace WebApplication2.Service.Todo
{
    public interface ITodoServices
    {
        Task<bool> GetTodoServices(TodoRequest request);
    }
}
