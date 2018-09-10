using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RobotArena.Common.Models.BindingModels.Armor
{
    public class ArmorCreationBindingModel
    {
  
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be at least 3 characters")]
        public string Name { get; set; }
        [Required]
        [Range(100, 3000, ErrorMessage = "Value outside of range")]
        public int ArmorPoints { get; set; }
         
        [Required]
        [Range(1, 99, ErrorMessage = "Value outside of range")]
        public int DurabilityLossAmount { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        [Range(1, 400, ErrorMessage = "Value outside of range")]
        public int Price { get; set; }
    }
}
