using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotArena.Common.Models.Creep
{
    public class CreepDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }      
        public string ImageUrl { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Bounty { get; set; }
    }
}
