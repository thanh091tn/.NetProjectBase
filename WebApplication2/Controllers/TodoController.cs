using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Request;
using WebApplication2.Response;

namespace WebApplication2.Controllers
{
    public class TodoController : BaseController
    {
        public TodoController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<BaseResponse> GetTodoServices([FromBody]TodoRequest request)
        {
            var rs = await _mediator.Send(request);
            return rs;
        }
    }
}
