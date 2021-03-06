﻿using RobotArena.Common.Models.Armor;
using RobotArena.Common.Models.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotArena.Common.Models.Item
{
    public class UserAllItemsViewModel
    {
        public ICollection<ArmorDetailsViewModel> Armors { get; set; }
        public ICollection<WeaponDetailsViewModel> Weapons { get; set; }
    }
}
