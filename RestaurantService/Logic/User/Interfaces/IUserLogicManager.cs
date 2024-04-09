
using Logic.User.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.User.Interfaces
{
    public interface IUserLogicManager
    {
        public Task<IEnumerable<UserLogic>> GetAllUsers();
        public Task<bool> CheckUserPassword(string username, string password);
        public Task<UserLogic> GetUserById(int id);
    }
}
