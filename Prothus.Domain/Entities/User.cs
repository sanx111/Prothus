using BCrypt.Net;

namespace Prothus.Domain.Entities
{
    public class User : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        public void SetPassword(string plainTextPassword)
        {
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(plainTextPassword);
        }

        public bool ValidatePassword(string plainTextPassword)
        {
            return BCrypt.Net.BCrypt.Verify(plainTextPassword, PasswordHash);
        }
    }
}