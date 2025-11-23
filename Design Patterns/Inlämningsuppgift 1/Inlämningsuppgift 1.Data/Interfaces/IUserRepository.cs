using Inlämningsuppgift_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_1.Data.Interfaces
{
    public interface IUserRepository
    {
        bool Register(string username, string password, string email);
        string? Login(string username, string password);
        User? GetUserByToken(string token);
        User? GetById(int id);
        List<User> GetAllUsers();
        void SaveToken(string token, int userId);
        void AddUser(User user);
    }
}
