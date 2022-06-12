namespace CQRS.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public Guid UserGuid { get; set; }
        public string Email { get; set; } = null!;
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Address { get; set; }
        public string Password { get; set; } = null!;
    }
}
