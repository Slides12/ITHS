using Inlämningsuppgift_1.Data.Interfaces;
using Inlämningsuppgift_1.Services;

namespace Inlämningsuppgift_1.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> Users = new List<User>
        {
            new User { Id = 1, Username = "alice", Password = "password", Email = "alice@example.com" },
            new User { Id = 2, Username = "bob", Password = "password", Email = "bob@example.com" }
        };


        private readonly Dictionary<string, int> Tokens = new Dictionary<string, int>();

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public List<User> GetAllUsers()
        {
            return Users;
        }

        public User? GetById(int id)
        {
            return Users.Where(u => u.Id == id).FirstOrDefault();
        }

        public User? GetUserByToken(string token)
        {
            if (!Tokens.TryGetValue(token, out int userId))
                return null;

            return GetById(userId);
        }

        public string? Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool Register(string username, string password, string email)
        {
            throw new NotImplementedException();
        }

        public void SaveToken(string token, int userId)
        {
            Tokens[token] = userId;
        }
    }
}
