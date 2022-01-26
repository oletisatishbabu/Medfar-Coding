using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Medfar.Interview.BLL.BusinessLogicLayer.Interfaces;
using Medfar.Interview.DAL.Repositories.Interfaces;
using Medfar.Interview.Types;

namespace Medfar.Interview.BLL.BusinessLogicLayer
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository; 
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> CreateUser(User user)
        {
            var isUserExist = await _userRepository.ValidateUser(user.email);
            if (isUserExist)
            {
                return new User { IsSuccess = false, ErrorMessage = "Email is already exist", DetailedError = string.Empty };
            }
            else
            {
                var result = await _userRepository.CreateUser(user);
                return new User { IsSuccess = true, ErrorMessage = string.Empty, DetailedError = string.Empty };
                
            } 
        }

        public async Task<User> UpdateUser(User user)
        {
            var isUserExist = await _userRepository.ValidateUser(user.email);
            if (isUserExist)
            {
                return new User { IsSuccess = false, ErrorMessage = "Email is already exist", DetailedError = string.Empty };
            }
            else
            {
                var result = await _userRepository.UpdateUser(user);
                return new User { IsSuccess = true, ErrorMessage = string.Empty, DetailedError = string.Empty };

            }
        }

        public async Task<int> DeleteUser(string guId)
        {
            return await _userRepository.DeleteUser(guId);
        }

        public async Task<IEnumerable<User>> GetUserDetails(string guId)
        {
            return await _userRepository.GetUserDetails(guId);
        }

        public async Task<Users> GetAllUserDetails(int offSet, int pageSize, string firstName)
        {
            return await _userRepository.GetAllUserDetails(offSet,pageSize,firstName);
        }

        public async Task<bool> ValidateUser(string email)
        {
            return await _userRepository.ValidateUser(email);
        }
    }
}
