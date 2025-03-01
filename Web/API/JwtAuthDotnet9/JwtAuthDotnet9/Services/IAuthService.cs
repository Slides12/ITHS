using JwtAuthDotnet9.DTO;
using JwtAuthDotnet9.Entities;

namespace JwtAuthDotnet9.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<TokenResponseDto?> LoginAsync(UserDto request);
        Task<TokenResponseDto> RefreshTokensAsync(RefreshTokenRequestDto request);
    }
}
