﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P03_FootballBetting.Data.Models
{
    public class Town
    {
        public Town()
        {
            this.Teams = new HashSet<Team>();
        }

        [Key]
        public int TownId { get; set; }

        [MaxLength(85), Required]
        public string Name { get; set; }

        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
