using CQRS.Models;
using Microsoft.EntityFrameworkCore;
using DbContext = CQRS.Models.DbContext;

namespace PMSCore.Data.EntityFrameWork.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContext _dbContext;
        public UserRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<User> CreateUserAsync(User user)
        {
            var result = _dbContext.AddAsync<User>(user);
            await _dbContext.SaveChangesAsync();
            return result.Result.Entity;
        }

        public async Task<User> GetuserByIdAsyc(int id)
        {
            var result =  await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
#pragma warning disable CS8603 // Possible null reference return.
            return result;
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
