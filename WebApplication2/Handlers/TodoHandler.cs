using MediatR;
using Request;
using Response;
using Service.Todo;

namespace Handlers
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
