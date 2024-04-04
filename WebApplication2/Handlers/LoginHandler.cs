using MediatR;
using ProjectBB.Model;
using ProjectBB.Request;
using ProjectBB.Response;
using ProjectBB.Service.Login;
using Request;
using Service.Todo;

namespace ProjectBB.Handlers
{
    public class LoginHandler : IRequestHandler<LoginRequest, Response<LoginResponse>>
    {
        private readonly IloginServices _services;
        public LoginHandler(IloginServices service)
        {
            _services = service;
        }


        public async Task<Response<LoginResponse>> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var rs = await _services.Login(request);
            return Response<LoginResponse>.CreateResponse(rs);
        }
    }
}
