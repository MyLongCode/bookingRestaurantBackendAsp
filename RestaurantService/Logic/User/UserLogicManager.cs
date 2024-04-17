using Dal.Restaurant.Interfaces;
using Dal.User.Interfaces;
using Dal.User.Models;
using Logic.User.Interfaces;
using Logic.User.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.User
{
    public class UserLogicManager : IUserLogicManager
    {

        private readonly IUserRepository _userRepository;

        public UserLogicManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> CheckUserPassword(string username, string password)
        {
            return await _userRepository.CheckUserPassword(username, password);
        }

        public async Task<IEnumerable<UserLogic>> GetAllUsers()
        {
            return _userRepository.GetAllUsers().Result.Select(u => new UserLogic
            {
                Email = u.Email,
                Password = u.Password,
                FullName = u.FullName,
                BirthDate = u.BirthDate,
                PhoneNumber = u.PhoneNumber,
                Avatar = u.Avatar
            });
        }

        public async Task<UserLogic> GetUserById(int id)
        {
            UserDal? user = _userRepository.GetUserById(id).Result;
            return new UserLogic
            {
                Email = user.Email,
                Password = user.Password,
                FullName = user.FullName,
                BirthDate = user.BirthDate,
                PhoneNumber = user.PhoneNumber,
                Avatar = user.Avatar
            };
        }

        public Task<int> GetIdByUsername(string username)
        {
            return _userRepository.GetIdByName(username);
        }
    }
}
