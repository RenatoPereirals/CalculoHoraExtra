using System.ComponentModel.DataAnnotations;
using WorkHourCalculator.Domain.Enums;

namespace WorkHourCalculator.Domain
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Sector Sector { get; set; }

        public User(string username, string password, Sector sector)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Sector = sector;
        }
    }
}
