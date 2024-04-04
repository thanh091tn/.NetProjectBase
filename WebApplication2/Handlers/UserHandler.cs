using MediatR;
using ProjectBB.Model;
using ProjectBB.Request;
using ProjectBB.Response;
using ProjectBB.Service.User;

namespace ProjectBB.Handlers
{
    public class UserHandler : IRequestHandler<CreateUserRequest, bool>
    {
        private readonly IUserServices _userServices;
        public UserHandler(IUserServices userServices) {
            _userServices = userServices;
        }
        public Task<bool> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var rs = _userServices.CreateUser(request,cancellationToken);
            return rs;
        }
    }
}
