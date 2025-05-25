using Prothus.Application.DTOs;
using Prothus.Domain.Entities;

namespace Prothus.Application.Interfaces
{
    public interface IUserRepository
    {
        Task AddAsync(User User);
        Task<List<UserQueryDto>> GetUsersAsync();
        Task<User?> GetByEmailAsync(string email);

    }
}