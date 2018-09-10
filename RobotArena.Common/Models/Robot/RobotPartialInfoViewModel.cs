using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotArena.Common.Models.Robot
{
    public class RobotPartialInfoViewModel
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int RankPlace { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
    }
}
