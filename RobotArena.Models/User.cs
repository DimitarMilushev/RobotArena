using Microsoft.AspNetCore.Identity;
using RobotArena.Models.Items;
using RobotArena.Models.Robots;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotArena.Models
{
    public class User :IdentityUser
    {
        public User()
        {
            this.Coins = 1000;
            this.Robots = new List<Robot>();
            this.Weapons = new List<Weapon>();
            this.Armors = new List<Armor>();
        }
        public string FullName { get; set; }
        public int Coins { get; set; }
        public ICollection<Robot> Robots { get; set; }
        public ICollection<Weapon> Weapons { get; set; }
        public ICollection<Armor> Armors { get; set; }
      
    }
}
