using MediatR;
using Response;

namespace Request
{
    public class TodoRequest : IRequest<Response<bool>>
    {
        public int id { get; set; }
    }
}
