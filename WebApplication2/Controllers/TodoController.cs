using MediatR;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        public async Task<BaseResponse> GetTodoServices([FromBody] TodoRequest request)
        {
            var rs = await _mediator.Send(request);
            return rs;
        }
    }
}
