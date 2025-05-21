using Prothus.Application.DTOs;
using Prothus.Application.Interfaces;
using Prothus.Domain.Entities;
using BCrypt;


namespace Prothus.Application.Services
{
    public class RegisterUserService : IRegisterUserService
    {
        private readonly IRegisterUserRepository _RegisterUserRepository;
        public RegisterUserService(IRegisterUserRepository userRepository)
        {
            _RegisterUserRepository = userRepository;
        }

        public async Task RegisterUserAsync(RegisterUserDto dto)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };

            await _RegisterUserRepository.AddAsync(user);
        }
    }
}