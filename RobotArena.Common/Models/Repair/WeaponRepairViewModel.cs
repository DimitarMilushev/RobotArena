using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotArena.Common.Models.Repair
{
    public class WeaponRepairViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Type { get; set; }
        public int DamagePoints { get; set; }
        public int CurrentDamage { get; set; }
        //no need for setter
        public int Durability { get; set; }
        public bool CriticalAttackMode { get; set; }
    }
}
