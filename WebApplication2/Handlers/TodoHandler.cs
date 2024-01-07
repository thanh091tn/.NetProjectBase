using MediatR;
using WebApplication2.Request;
using WebApplication2.Response;
using WebApplication2.Service.Todo;

namespace WebApplication2.Handlers
{
    public class TodoHandler : IRequestHandler<TodoRequest, Response<bool>>
    {
        private readonly ITodoServices _services;


        public TodoHandler(ITodoServices services)
        {
            _services = services;
        }

        public async Task<Response<bool>> Handle(TodoRequest request, CancellationToken cancellationToken)
        {
            var rs = await _services.GetTodoServices(request);
            return Response<bool>.CreateResponse(rs);
        }
    }
}
