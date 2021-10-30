using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P03_FootballBetting.Data.Models
{
    public class Team
    {
        public Team()
        {
            this.HomeGames = new HashSet<Game>();
            this.AwayGames = new HashSet<Game>();

            this.Players = new HashSet<Player>();
        }

        [Key]
        public int TeamId { get; set; }

        [MaxLength(50), Required]
        public string Name { get; set; }

        [MaxLength(2048)]
        public string LogoUrl { get; set; }

        [MaxLength(4), Required]
        public string Initials { get; set; }

        public decimal Budget { get; set; }

        [InverseProperty("PrimaryKitColor")]
        public int PrimaryKitColorId { get; set; }
        public virtual Color PrimaryKitColor { get; set; }

        [InverseProperty("SecondaryKitColor")]
        public int SecondaryKitColorId { get; set; }
        public virtual Color SecondaryKitColor { get; set; }

        [ForeignKey(nameof(Town))]
        public int TownId { get; set; }
        public virtual Town Town { get; set; }

        [InverseProperty("HomeTeam")]
        public virtual ICollection<Game> HomeGames { get; set; }

        [InverseProperty("AwayTeam")]
        public virtual ICollection<Game> AwayGames { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}