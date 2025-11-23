using Inlämningsuppgift_1.Services;

namespace Inlämningsuppgift_1.Interfaces
{
    public interface IUserService
    {
        bool Register(string username, string password, string email);
        string? Login(string username, string password);
        User? GetUserByToken(string token);
        User? GetById(int id);
    }
}
