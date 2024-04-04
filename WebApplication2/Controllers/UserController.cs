using Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProjectBB.Request;
using Response;

namespace ProjectBB.Controllers
{
    public class UserController : BaseController
    {
        public UserController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPut]
        public async Task<bool> CreateUser([FromBody] CreateUserRequest request)
        {
            var rs = await _mediator.Send(request);
            return rs;
        }
    }
}
