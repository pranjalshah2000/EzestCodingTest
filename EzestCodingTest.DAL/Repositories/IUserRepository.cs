using EzestCodingTest.DAL.Models;
using System.Collections.Generic;

namespace EzestCodingTest.DAL.Repositories
{
    public interface IUserRepository
    {
        bool CreateUser(User user);

        IEnumerable<User> GetUserList();

        User GetUserById(int userId);
    }
}
