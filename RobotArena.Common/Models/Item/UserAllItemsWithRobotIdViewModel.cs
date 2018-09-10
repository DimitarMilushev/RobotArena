using RobotArena.Common.Models.Armor;
using RobotArena.Common.Models.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotArena.Common.Models.Item
{
    public class UserAllItemsWithRobotIdViewModel
    {
        public int RobotId { get; set; }
        public ICollection<ArmorDetailsWithRobotIdViewModel> Armors { get; set; }
        public ICollection<WeaponDetailsWithRobotIdViewModel> Weapons { get; set; }
    }
}
