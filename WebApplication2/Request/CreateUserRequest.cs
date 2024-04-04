using MediatR;
using ProjectBB.Model;

namespace ProjectBB.Request
{
    public class CreateUserRequest : IRequest<bool>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
