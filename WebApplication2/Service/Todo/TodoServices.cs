using Entities;
using Repository;
using Request;
using System.Diagnostics.CodeAnalysis;

namespace Service.Todo
{
    public class TodoServices : ITodoServices
    {
        private readonly IMainRepository<TodoItem> _TododbRepository;

        public TodoServices([NotNull] IMainRepository<TodoItem> todoRepository)
        {
            _TododbRepository = todoRepository;
        }

        public async Task<bool> GetTodoServices(TodoRequest request)
        {

            var r = _TododbRepository.Entity.FirstOrDefault();
            return true;
        }
    }
}
