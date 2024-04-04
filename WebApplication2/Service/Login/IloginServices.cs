using ProjectBB.Request;
using ProjectBB.Response;
using Request;

namespace ProjectBB.Service.Login
{
    public interface IloginServices
    {
        Task<LoginResponse> Login(LoginRequest request);
    }
}