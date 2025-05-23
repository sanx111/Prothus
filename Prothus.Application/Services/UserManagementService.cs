using Prothus.Application.DTOs;
using Prothus.Application.Interfaces;
using Prothus.Domain.Entities;
using BCrypt;


namespace Prothus.Application.Services
{
    public class UserManagementService : IRegisterUserService
    {
        private readonly IUserRepository _RegisterUserRepository;
        public UserManagementService(IUserRepository userRepository)
        {
            _RegisterUserRepository = userRepository;
        }

        public async Task RegisterUserAsync(UserManagementDto dto)
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