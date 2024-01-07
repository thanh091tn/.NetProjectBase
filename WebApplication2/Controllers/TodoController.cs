using MediatR;
using Microsoft.AspNetCore.Mvc;
using Request;
using Response;

namespace Controllers
{
    public class TodoController : BaseController
    {
        public TodoController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<BaseResponse> GetTodoServices([FromBody] TodoRequest request)
        {
            var rs = await _mediator.Send(request);
            return rs;
        }
    }
}
