using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RobotArena.Data;
 using RobotArena.Models;
using RobotArena.Common.Models.Armor;
using RobotArena.Common.Models.Item;
using RobotArena.Common.Models.Robot;
using RobotArena.Common.Models.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotArena.Controllers
{
    [Authorize]
    public class UsersController:Controller
    {
        private readonly UserManager<User> userManager;
        private RobotContext context;
        private readonly IMapper Mapper;
        public UsersController(UserManager<User> usermanager, RobotContext roboContext,IMapper mapper)
        {
            this.userManager = usermanager;
            this.context = roboContext;
            this.Mapper = mapper;
        }
      [HttpGet]
        public IActionResult AllRobots()
        {
           // var courses = await this.DbContext.Courses.ToListAsync();
           // var modelCourses = this.Mapper.Map<IEnumerable<CourseConciseViewModel>>(courses);

            var user = userManager.GetUserAsync(HttpContext.User).Result;

            var currentUser = context.Users.Include(u => u.Robots).FirstOrDefault(u => u.Id == user.Id);
            if (currentUser == null)
            {
                return NotFound();
            }
            var robots = currentUser.Robots.ToList();
            var detailRobots = this.Mapper.Map<IEnumerable<RobotPartialInfoViewModel>>(robots);
            return this.View(detailRobots);
        }
        [HttpGet]
       public IActionResult Items()
        {
            var user = userManager.GetUserAsync(HttpContext.User).Result;
           
            var userWithWeaponsAndArmors = context.Users.Include(u=>u.Weapons).Include(u=>u.Armors).FirstOrDefault(u => u.Id == user.Id);
            if (userWithWeaponsAndArmors == null)
            {
                return NotFound();
            }
            var model = Mapper.Map<UserAllItemsViewModel>(userWithWeaponsAndArmors);
            return this.View(model);
        }
        
       
    }
}
