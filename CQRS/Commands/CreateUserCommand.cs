
using CQRS.Models;
using MediatR;
using PMCore.WebAPI.ViewModels;

namespace CQRS.Commands
{
    public class CreateUserCommand : IRequest<UserVm>
    {
        public CreateUserCommand(User user)
        {
            User = user;
        }

        public User User { get; }
    }
}
