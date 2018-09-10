using RobotArena.Common.Models.Armor;
using RobotArena.Common.Models.Creep;
using RobotArena.Common.Models.Robot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotArena.Common.Models.Fight
{
    public class FightViewModel
    {
        public RobotDetailsViewModel Robot { get; set; }
        public CreepDetailsViewModel Creep { get; set; }
    }
}
