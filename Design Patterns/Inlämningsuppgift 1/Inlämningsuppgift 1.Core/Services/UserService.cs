using Inlämningsuppgift_1.Data.Interfaces;
using Inlämningsuppgift_1.Interfaces;

namespace Inlämningsuppgift_1.Services
{
    public class UserService : IUserService
    {
       //1
        //private static readonly List<User> Users = new List<User>
        //{
        //    new User { Id = 1, Username = "alice", Password = "password", Email = "alice@example.com" },
        //    new User { Id = 2, Username = "bob", Password = "password", Email = "bob@example.com" }
        //};

  
        //private static readonly Dictionary<string, int> Tokens = new Dictionary<string, int>();
        //2
        //public class User
        //{
        //    public int Id { get; set; }
        //    public string Username { get; set; } = "";
        //    public string Password { get; set; } = ""; 
        //    public string Email { get; set; } = "";
        //}

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool Register(string username, string password, string email)
        {
            var Users = _userRepository.GetAllUsers();
            if (Users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase))) return false;
            var id = Users.Any() ? Users.Max(u => u.Id) + 1 : 1;
            //Users.Add(new User { Id = id, Username = username, Password = password, Email = email });

            _userRepository.AddUser(new User
            {
                Id = id,
                Username = username,
                Password = password,
                Email = email
            });

            return true;
        }

        public string? Login(string username, string password)
        {
            var Users = _userRepository.GetAllUsers();
            var u = Users.FirstOrDefault(x => x.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && x.Password == password);
            if (u == null) return null;
            var token = "token-" + Guid.NewGuid().ToString(); 
            //Tokens[token] = u.Id;
            _userRepository.SaveToken(token, u.Id);
            return token;
        }

        public User? GetUserByToken(string token)
        {
            //if (Tokens.TryGetValue(token, out var userId))
            //{
            //    return 
            //}
            //return null;
            var user = _userRepository.GetUserByToken(token);
            return user;
        }

        public User? GetById(int id) => _userRepository.GetById(id);
    }
}
