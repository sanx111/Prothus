using Prothus.Application.DTOs;
using Prothus.Application.Interfaces;
using Prothus.Domain.Entities;
using BCrypt;


namespace Prothus.Application.Services
{
    public class UserQueryService : IUserQueryService
    {
        private readonly IRegisterUserRepository _userQueryService;
        public UserQueryService(IRegisterUserRepository userQueryService)
        {
            _userQueryService = userQueryService;
        }

        public async Task<List<UserDto>> GetUsersAsync()
        {
            return await _userQueryService.GetUsersAsync();
        }
    }
}