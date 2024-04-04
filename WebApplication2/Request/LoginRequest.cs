using MediatR;
using ProjectBB.Model;
using ProjectBB.Response;

namespace ProjectBB.Request
{
    public class LoginRequest : IRequest<Response<LoginResponse>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
