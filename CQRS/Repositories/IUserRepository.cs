using CQRS.Models;

namespace PMSCore.Data.EntityFrameWork.Repositories
{
    public interface IUserRepository
    {
        Task<User> CreateUserAsync(User user);
        Task<User> GetuserByIdAsyc(int id);
    }
}
