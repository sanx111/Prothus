using Prothus.Domain.Entities;

namespace Prothus.Application.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(User user);
    }
}
