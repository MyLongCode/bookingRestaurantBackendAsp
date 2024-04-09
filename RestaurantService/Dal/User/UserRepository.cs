using Dal.EF;
using Dal.User.Interfaces;
using Dal.User.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Dal.User
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext db;

        public UserRepository(ApplicationDbContext context) => this.db = context;
        public Task<bool> CheckUserPassword(string username, string password)
        {
            UserDal? user = db.Users.FirstOrDefault(x => x.Email == username && x.Password == password);
            return Task.FromResult(!(user == null));
        }

        public async Task<IEnumerable<UserDal>> GetAllUsers()
        {
            return db.Users.ToList();
        }

        public Task<UserDal> GetUserById(int id)
        {
            UserDal? user = db.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
                throw new Exception("user is not found");
            return Task.FromResult(user);
        }
    }
}
