﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace start1.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "От къде")]
        public string From { get; set; }

        [Required]
        [Display(Name = "До къде")]
        public string To { get; set; }

        [Required]
        [Display(Name = "Час на тръгване")]
        public DateTime DepartureTime { get; set; }

        [Required]
        [Range(1, 100)]
        [Display(Name = "Брой пътници")]
        public int NumberOfPassengers { get; set; }

        // 🔑 Вече НЕ е required
        public string? UserId { get; set; }

        public virtual IdentityUser? User { get; set; }

    }


}
