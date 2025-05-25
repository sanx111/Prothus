using Prothus.Application.DTOs;
using Prothus.Application.Interfaces;
using Prothus.Domain.Entities;
using BCrypt;


namespace Prothus.Application.Services
{
    public class UserManagementService : IUserManagementService
    {
        private readonly IUserRepository _UserRepository;
        public UserManagementService(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }

        public async Task RegisterUserAsync(UserManagementDto dto)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };

            await _UserRepository.AddAsync(user);
        }

        public async Task DeleteUserAsync(Guid userId)
        {
            var user = await _UserRepository.GetByIdAsync(userId)
                ?? throw new KeyNotFoundException($"Usuário com ID {userId} não encontrado");

            await _UserRepository.RemoveAsync(user);
        }
    }
}