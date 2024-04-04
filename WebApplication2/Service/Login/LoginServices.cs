using ProjectBB.Request;
using ProjectBB.Response;
using Repository;
using System.Diagnostics.CodeAnalysis;
using ProjectBB.Entities;
namespace ProjectBB.Service.Login
{
    public class LoginServices : IloginServices
    {
        private readonly IMainRepository<ProjectBB.Entities.User> _userRepository;
        private readonly IConfiguration _configuration;

        public LoginServices([NotNull] IMainRepository<ProjectBB.Entities.User> userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        public async Task<LoginResponse> Login(LoginRequest request)
        {
            var jwtOptions = _configuration.GetSection("JwtOptions").Get<JwtOptions>();
            var r = _userRepository.Entity.Where(x => x.UserName == request.UserName && x.UserPassword ==  request.Password).FirstOrDefault();
            if (r != null)
            {
                var token = TokenEndpoint.CreateAccessToken(jwtOptions, request.UserName, TimeSpan.FromMinutes(60), []);

                return new LoginResponse()
                {
                    Token = token,
                };
            }
            return new LoginResponse();
            
        }

    }
}
