using MediatR;
using PMCore.WebAPI.ViewModels;

namespace CQRS.Queries
{
    public class GetUserByIdQuery : IRequest<UserVm>
    {
        public GetUserByIdQuery(int id)
        {
            UserId = id;
        }
        public int UserId { get; set; }
    }
}
