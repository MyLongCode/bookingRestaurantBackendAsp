using Dal.User.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.User.Interfaces
{
    public interface IUserRepository
    {

        public Task<IEnumerable<UserDal>> GetAllUsers();
        public Task<bool> CheckUserPassword(string username, string password);
        public Task<UserDal> GetUserById(int id);
        public Task<int> GetIdByName(string username);
        public Task<int> CreateUser(UserDal userDal);

    }
}
