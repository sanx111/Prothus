using Microsoft.EntityFrameworkCore;
using Prothus.Application.Interfaces;
using Prothus.Domain.Entities;
using Prothus.Infrastructure.Context;


namespace Prothus.Infrastructure.Repositories
{
    public class RegisterUserRepository : IRegisterUserRepository
    {
        private readonly AppDbContext _context;

        public RegisterUserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}