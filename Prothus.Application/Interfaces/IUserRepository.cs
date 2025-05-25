using Prothus.Application.DTOs;
using Prothus.Domain.Entities;

namespace Prothus.Application.Interfaces
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task RemoveAsync(User user);
        Task<List<UserQueryDto>> GetUsersAsync();

        Task<User?> GetByEmailAsync(string email);
        Task<User?> GetByIdAsync(Guid id);

    }
}