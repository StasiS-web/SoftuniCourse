using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P03_FootballBetting.Data.Models
{
    public class User
    {
        public User()
        {
            this.Bets = new HashSet<Bet>();
        }

        [Key]
        public int UserId { get; set; }

        [MaxLength(50), Required]
        public string Username { get; set; }

        //Password in the Database are store hashed
        [MaxLength(256), Required]
        public string Password { get; set; }

        [MaxLength(320), Required]
        public string Email { get; set; }

        [MaxLength(75), Required]
        public string Name { get; set; }

        public decimal Balance { get; set; }

        public virtual ICollection<Bet> Bets { get; set; }
    }
}
