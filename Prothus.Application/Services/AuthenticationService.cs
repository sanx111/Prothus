using Prothus.Application.DTOs;
using Prothus.Application.Interfaces;

namespace Prothus.Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtService _jwtService;

        public AuthenticationService(IUserRepository userRepository, IJwtService jwtService)
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
        }

        public async Task<LoginResponseDto> LoginAsync(LoginRequestDto request)
        {
            var user = await _userRepository.GetByEmailAsync(request.Email) 
                ?? throw new UnauthorizedAccessException("Invalid credentials");

            if (!user.ValidatePassword(request.Password))
                throw new UnauthorizedAccessException("Invalid credentials");

            var token = _jwtService.GenerateToken(user);

            return new LoginResponseDto
            {
                Id = user.Id,
                Email = user.Email,
                Token = token,
            };
        }
    }
}
