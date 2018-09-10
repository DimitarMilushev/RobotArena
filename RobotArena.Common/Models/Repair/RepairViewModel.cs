using RobotArena.Common.Models.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotArena.Common.Models.Repair
{
    public class RepairViewModel
    {
        public IEnumerable<ArmorRepairViewModel> ArmorsViewModel { get; set; }
        public IEnumerable<WeaponRepairViewModel> WeaponsViewModel { get; set; }
        public IEnumerable<RobotRepairViewModel> RobotsViewModel { get; set; }
    }
}
