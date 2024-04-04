using ProjectBB.Request;

namespace ProjectBB.Service.User
{
    public interface IUserServices
    {
        Task<bool> CreateUser(CreateUserRequest request, CancellationToken cancellationToken);
    }
}