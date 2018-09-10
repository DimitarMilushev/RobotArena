using RobotArena.Common.Models.Armor;
using RobotArena.Common.Models.Creep;
using RobotArena.Common.Models.Robot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotArena.Common.Models.Fight
{
    public class FightResultViewModel
    {
        public bool RobotIsAlive { get; set; }
        public bool CreepIsAlive { get; set; }
        public int RoundsCount { get; set; }
        public int RobotDamageDone { get; set; }
        public int RobotReducedDamage { get; set; }
        public int CreepDamageDone { get; set; }
        
        public CreepFightViewModel CreepModel { get; set; }
        public RobotFightViewModel RobotModel { get; set; }
    }
}
