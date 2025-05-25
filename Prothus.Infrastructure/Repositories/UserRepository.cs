using Microsoft.EntityFrameworkCore;
using Prothus.Application.DTOs;
using Prothus.Application.Interfaces;
using Prothus.Domain.Entities;
using Prothus.Infrastructure.Context;


namespace Prothus.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<UserQueryDto>> GetUsersAsync()
        {
            return await _context.Users.Select(x => new UserQueryDto()
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                DateCreated = x.DateCreated,
            }).ToListAsync();
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Email == email);
        }

    }
}