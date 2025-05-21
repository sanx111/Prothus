using Prothus.Application.DTOs;

namespace Prothus.Application.Interfaces
{
    public interface IRegisterUserService
    {
        Task RegisterUserAsync(RegisterUserDto dto);
    }
}