using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    /// <summary>
    /// BaseV1Controller
    /// </summary>
    [Route("api/v1/[controller]/[action]")]
    public class BaseController : ControllerBase
    {

        protected readonly IMediator _mediator;

        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
