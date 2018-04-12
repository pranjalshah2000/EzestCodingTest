using EzestCodingTest.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace EzestCodingTest.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EzestCodingTestDBContext _ezestCodingTestDBContext;

        public UserRepository(EzestCodingTestDBContext ezestCodingTestDBContext)
        {
            _ezestCodingTestDBContext = ezestCodingTestDBContext;
        }

        public bool CreateUser(User user)
        {
            if (user == null)
                return false;

            _ezestCodingTestDBContext.Users.Add(user);
            _ezestCodingTestDBContext.SaveChanges();
            return true;
        }

        public IEnumerable<User> GetUserList()
        {
            var users = _ezestCodingTestDBContext.Users.OrderByDescending(u => u.Id).ToList();
            return users;
        }

        public User GetUserById(int userId)
        {
            var user = _ezestCodingTestDBContext.Users.FirstOrDefault(u => u.Id == userId);
            return user;
        }
    }
}
