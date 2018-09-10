using RobotArena.Common.Models.Robot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotArena.Common.Models.User
{
    public class UserAllRobotsViewModel
    {
        public ICollection<RobotPartialInfoViewModel> RobotViewModels { get; set; }
    }
}
