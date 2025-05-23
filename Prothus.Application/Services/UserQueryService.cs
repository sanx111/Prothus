using Prothus.Application.DTOs;
using Prothus.Application.Interfaces;
using Prothus.Domain.Entities;
using BCrypt;


namespace Prothus.Application.Services
{
    public class UserQueryService : IUserQueryService
    {
        private readonly IUserRepository _userQueryService;
        public UserQueryService(IUserRepository userQueryService)
        {
            _userQueryService = userQueryService;
        }

        public async Task<List<UserQueryDto>> GetUsersAsync()
        {
            return await _userQueryService.GetUsersAsync();
        }
    }
}