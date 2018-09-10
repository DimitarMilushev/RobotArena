using RobotArena.Models.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RobotArena.Models.Robots
{
    public class Robot 
    {    //3 koloni
        //Name,Type,ImageUrl,BaseHealth,BaseDamage,Armors,Weapons,DamageReduction,Wins,Losses
        public Robot()
        {

            this.Wins = 0;
            this.Losses = 0;
          
            this.Armors = new List<Armor>();
            this.Weapons = new List<Weapon>();
        }
        private int currentHealth;
        public int Id { get; set; }
            
        public string Name { get; set; }
        public string Type { get; set; }
        public string ImageUrl { get; set; }


        public int BaseHealth { get; set; }
      
       
      
        public int BaseDamage { get; set; }
        public int CurrentHealth
        {
            get
            {
                return this.currentHealth;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                this.currentHealth = value;
            }
        }
    public int Armor
        {
            get
            {
                var armor = this.Armors.Sum(a => a.ArmorPoints);
                return armor;
            }
        }
        public int TotalDamage
        {
            get
            {
                var weaponDamage = this.Weapons.Sum(w => w.DamagePoints);
                var totalDamage = this.BaseDamage + weaponDamage;
                return totalDamage;
            }

        }

        public ICollection<Armor> Armors { get; set; }
        public ICollection<Weapon> Weapons { get; set; }
        public int DamageReduction
        {
            get
            {

                var reduction = Math.Min(99, (int)((Armor * 0.06) % (1 + 0.06 * Armor)));
                return reduction;
            }
        }

        public int Wins { get; set; }
        public int Losses { get; set; }    
        public string OwnerId { get; set; }
        public User Owner { get; set; }
    }
}
