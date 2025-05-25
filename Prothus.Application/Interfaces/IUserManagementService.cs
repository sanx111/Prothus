using Prothus.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prothus.Application.Interfaces
{
    public interface IUserManagementService
    {
        Task RegisterUserAsync(UserManagementDto dto);
        Task DeleteUserAsync(Guid id);
    }
}
