using Prothus.Domain.Entities;

namespace Prothus.Application.Interfaces
{
    public interface IRegisterUserRepository
    {
        Task AddAsync(User User);
    }
}