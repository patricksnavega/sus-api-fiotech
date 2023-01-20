using ConsultVaccinesAPI.Data;
using ConsultVaccinesAPI.Models;
using ConsultVaccinesAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConsultVaccinesAPI.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly VaccinesSystemDbContext _dbContext;
        public UserRepository(VaccinesSystemDbContext taskSystemDbContext) 
        {
            _dbContext= taskSystemDbContext;
        }
        public async Task<List<UserModel>> GetAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }
        public async Task<UserModel> GetUserById(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.id == id);
        }
        public async Task<UserModel> AddUser(UserModel user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }
        public async Task<UserModel> UpdateUser(UserModel user, int id)
        {
            UserModel userById = await GetUserById(id);
            if (userById == null)
            {
                throw new Exception($"User to id ${id} not found at database");
            }

            userById.Name = user.Name;
            userById.Email = user.Email;

            _dbContext.Users.Update(userById);
            await _dbContext.SaveChangesAsync();

            return userById;
        }
        public async Task<bool> DeleteUser(int id)
        {
            UserModel userById = await GetUserById(id);
            if (userById == null)
            {
                throw new Exception($"User to id ${id} not found at database");
            }

            _dbContext.Users.Remove(userById);
            _dbContext.SaveChanges();
            return true;
        } 
    }
}
