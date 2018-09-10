using RobotArena.Common.Models.Armor;
using RobotArena.Common.Models.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotArena.Common.Models.Robot
{
    public class RobotDetailsViewModel
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ImageUrl { get; set; }
        public int CurrentHealth { get; set; }
        public int BaseHealth { get; set; }

        public int BaseDamage { get; set; }
        public int TotalDamage { get; set; }
        public int Armor { get; set; }
        public IEnumerable<ArmorDetailsViewModel> Armors { get; set; }
        public IEnumerable<WeaponDetailsViewModel> Weapons { get; set; }
        public double DamageReduction { get; set; }

        public int Wins { get; set; }
        public int Losses { get; set; }
        public int RankPlace { get; set; }
       
    }
}
