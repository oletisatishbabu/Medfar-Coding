using Medfar.Interview.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Medfar.Interview.BLL.BusinessLogicLayer.Interfaces
{
    public interface IUserService
    {
        Task<User> CreateUser(User user);
        Task<User> UpdateUser(User user);
        Task<int> DeleteUser(string guId);
        Task<IEnumerable<User>> GetUserDetails(string guId);
        Task<Users> GetAllUserDetails(int offSet, int pageSize, string firstName);
        Task<bool> ValidateUser(string email);
    }
}
