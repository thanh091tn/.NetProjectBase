using ProjectBB.Entities;
using ProjectBB.Request;
using ProjectBB.Response;
using Repository;
using System.Diagnostics.CodeAnalysis;

namespace ProjectBB.Service.User
{
    public class UserServices : IUserServices
    {
        private readonly IMainRepository<ProjectBB.Entities.User> _userRepository;

        public UserServices( IMainRepository<ProjectBB.Entities.User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> CreateUser(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var user = new ProjectBB.Entities.User()
            {
                UserName = request.UserName,
                CreatedAt = DateTime.UtcNow,
                IsDeleted = false,
                UserEmail = request.Email,
                UserPassword = request.Password,
            };
            _userRepository.Command().Add(user);

            var rs = await _userRepository.UnitOfWork.SaveChangesAsync(cancellationToken);
            return rs > 0;
        }
    }
}
