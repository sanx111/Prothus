namespace Prothus.Domain.Entities
{
    public class AuditableEntity
    {
        public DateTime DateCreated { get; set; }
        public DateTime? LastModified { get; set; }
        public string? CreatedBy { get; set; }

    }
}