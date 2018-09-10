using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotArena.Common.Models.Weapon
{
    public class WeaponDetailsWithRobotIdViewModel
    {
        public int Id { get; set; }
        public int RobotId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public int DamagePoints { get; set; }
        //no need for setter
        public int Durability { get; set; }
        public bool CriticalAttackMode { get; set; }
    }
}
