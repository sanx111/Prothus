using Prothus.Application.DTOs;

namespace Prothus.Application.Interfaces
{
    public interface IUserQueryService
    {
        Task<List<UserDto>> GetUsersAsync();
    }
}