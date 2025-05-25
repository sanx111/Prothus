using Prothus.Application.DTOs;
using Prothus.Domain.Entities;
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
        Task DeleteUserAsync(Guid userId);
    }
}
