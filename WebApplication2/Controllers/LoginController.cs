using Controllers;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectBB.Request;
using ProjectBB.Response;
using Request;
using Response;

namespace ProjectBB.Controllers
{
    public class LoginController : BaseController
    {
        public LoginController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<BaseResponse> Login([FromBody] LoginRequest request)
        {
            var rs = await _mediator.Send(request);
            return (BaseResponse)rs;
        }
    }
}
