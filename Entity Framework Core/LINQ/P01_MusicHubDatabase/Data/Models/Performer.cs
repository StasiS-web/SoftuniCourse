using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MusicHub.Common;

namespace MusicHub.Data.Models
{
    public class Performer
    {
        public Performer()
        {
            this.PerformerSongs = new HashSet<SongPerformer>();
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(ValidationConstants.PERFORMER_NAME_MAX_LENGTH), Required]
        public string FirstName { get; set; }

        [MaxLength(ValidationConstants.PERFORMER_NAME_MAX_LENGTH), Required]
        public string LastName { get; set; }

        public int Age { get; set; }

        public decimal NetWorth { get; set; }

        public virtual ICollection<SongPerformer> PerformerSongs { get; set; }
    }
}
