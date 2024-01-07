using MediatR;
using WebApplication2.Response;

namespace WebApplication2.Request
{
    public class TodoRequest : IRequest<Response<bool>>
    {
        public int id { get; set; }
    }
}
