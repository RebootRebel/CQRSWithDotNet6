using AutoMapper;
using CQRS.Commands;
using MediatR;
using PMCore.WebAPI.ViewModels;
using PMSCore.Data.EntityFrameWork.Repositories;

namespace CQRS.CommandHandler
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserVm>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public CreateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<UserVm> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var result = await _userRepository.CreateUserAsync(request.User);

            return _mapper.Map<UserVm>(result);
        }
    }
}
