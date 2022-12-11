using System.ComponentModel.DataAnnotations;

namespace HostelAPI.Model
{
    public class User
    {
        public int Id { get; set; }

        public string? Login { get; set; }

        public string? Password { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public UserRole Role { get; set; }
    }
}
