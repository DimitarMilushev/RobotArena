using RobotArena.Models.Robots;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RobotArena.Models.Items
{
    public class Weapon
    {
        public Weapon()
        {
            this.CriticalAttackMode = false;
            this.Durability = 100;

        }
        private int durability;
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be at least 3 characters")]
        public string Name { get; set; }
        [Required]
        [Range(100, 400, ErrorMessage = "Value outside of range 100 - 400")]
        public int DamagePoints { get; set; }        //no need for setter
        public int CurrentDamage
        {
            get
            {
                var reducedDamage = (Durability * DamagePoints) / 100;
                var damageMultiplier = CriticalAttackMode ? 2 : 1;
                reducedDamage *= damageMultiplier;
                return reducedDamage;
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
        [Range(1, 99, ErrorMessage = "Value outside of range")]
        public int DurabilityLossAmount { get; set; }
        public string ImageUrl { get; set; }
        public bool CriticalAttackMode { get; set; }
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
        public void RemoveCriticalStrike()
        {
            this.CriticalAttackMode = false;
        }

    }
}
