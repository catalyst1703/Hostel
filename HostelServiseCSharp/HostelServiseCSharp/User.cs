using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HostelServiseCSharp
{
    /// <summary>
    /// Class <c>User</c> represents user model
    /// </summary>
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

        public User(string login, string password, string email, string name, string surname, UserRole role)
        {
            Id = 0;
            Login = login;
            Password = password;
            Email = email;
            Name = name;
            Surname = surname;
            Role = role;
        }
        [JsonConstructor]
        public User(int id, string login, string password, string email, string name, string surname, UserRole role)
        {
            Id = id;
            Login = login;
            Password = password;
            Email = email;
            Name = name;
            Surname = surname;
            Role = role;
        }
    }


}
