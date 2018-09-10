using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotArena.Common.Models.Armor
{
    public class ArmorDetailsWithRobotIdViewModel
    {
        public int Id { get; set; }
        public int RobotId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public int ArmorPoints { get; set; }
        public int Durability { get; set; }
      
    }
}
