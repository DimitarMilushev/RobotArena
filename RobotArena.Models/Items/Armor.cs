using RobotArena.Models.Robots;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RobotArena.Models.Items
{
    public class Armor 
    {
        public Armor()
        {
            this.durability = 100;
            
        }
        private int durability;
        
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be at least 3 characters")]
        public string Name { get; set; }
        [Required]
        [Range(100,3000, ErrorMessage = "Value outside of range 100 - 3000")]
        public int ArmorPoints { get; set; }
        public int CurrentArmor
        {
            get
            {
                var reducedArmor = (Durability * ArmorPoints) / 100;
                return reducedArmor;
            }
        }
        [Required]
        [Range(0, 100, ErrorMessage = "Value outside of range 0 - 100")]
        public int Durability
        {
            get
            {
                return durability;
            }

            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                durability = value;
            }
        }
        [Required]
        [Range(1, 99, ErrorMessage = "Value outside of range 1 - 99")]
        public int DurabilityLossAmount { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        [Range(1, 400, ErrorMessage = "Value outside of range 1 - 400")]
        public int Price { get; set; }       
        public int? RobotId { get; set; }
        public Robot Robot { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public void ReduceDurability()
        {
            this.durability -= DurabilityLossAmount;
            this.Durability = durability;
        }
        public void DisconnectFromRobot()
        {
            RobotId = null;

        }
    }
}
