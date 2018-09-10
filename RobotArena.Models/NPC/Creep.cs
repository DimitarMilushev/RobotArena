using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RobotArena.Models.NPC
{
    public class Creep
    {
        private const int damageMultiplier = 2;
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be at least 3 characters")]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        public int DamageMultiplier => damageMultiplier;
        public string ImageUrl { get; set; }
        [Required]
        [Range(1,20000, ErrorMessage = "Value outside of range")]
        public int Health { get; set; }
        [Required]        
        public int Damage { get; set; }
        [Required]
        [Range(1,100000)]
        public int Bounty { get; set; }


    }
}
