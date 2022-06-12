using AutoMapper;
using CQRS.Queries;
using MediatR;
using PMCore.WebAPI.ViewModels;
using PMSCore.Data.EntityFrameWork.Repositories;

namespace CQRS.QueyHandler
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserVm>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public GetUserByIdQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<UserVm> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _userRepository.GetuserByIdAsyc(request.UserId);
            return _mapper.Map<UserVm>(result);
        }
    }
}
