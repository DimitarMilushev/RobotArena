using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotArena.Common.Models.Robot
{
    public class RobotsFightViewModel
    {
        public int CreepId { get; set; }
        public IEnumerable<RobotFightViewModel> FightModel { get; set; }
    }
}
