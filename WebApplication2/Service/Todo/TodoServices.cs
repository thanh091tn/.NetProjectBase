using System.Diagnostics.CodeAnalysis;
using WebApplication2.Entities;
using WebApplication2.Repository;
using WebApplication2.Request;

namespace WebApplication2.Service.Todo
{
    public class TodoServices : ITodoServices
    {
        private readonly IMainRepository<TodoItem> _TododbRepository;

        public TodoServices([NotNull]IMainRepository<TodoItem> todoRepository) {
        _TododbRepository = todoRepository;
        }

        public async Task<bool> GetTodoServices(TodoRequest request) {

            var r = _TododbRepository.Entity.FirstOrDefault();
            return true;
        }
    }
}
