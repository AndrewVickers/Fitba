using System;
using System.ComponentModel.DataAnnotations;

namespace Fitba.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        [StringLength(100)]
        public string Venue { get; set; }

    }
}