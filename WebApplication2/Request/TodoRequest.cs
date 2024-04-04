using MediatR;
using ProjectBB.Model;

namespace Request
{
    public class TodoRequest : IRequest<Response<bool>>
    {
        public int id { get; set; }
    }
}
