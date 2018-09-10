using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotArena.Common.Models.Robot
{
    public class RobotFightViewModel
    {
         public int Id { get; set; }
        //public int CreepId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ImageUrl { get; set; }


        public int BaseHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int TotalDamage { get; set; }
        public int DamageReduction { get; set; }
    }
}
