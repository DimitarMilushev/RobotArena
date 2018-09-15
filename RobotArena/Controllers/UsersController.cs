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
using RobotArena.Services.UserSerices;

namespace RobotArena.Controllers
{
    [Authorize]
    public class UsersController:Controller
    {
        private readonly UserManager<User> userManager;
        
        private readonly IMapper Mapper;
        private readonly IUserDataService userDataService;
        public UsersController(UserManager<User> usermanager,IUserDataService userDataService,IMapper mapper)
        {
            this.userManager = usermanager;
           
            this.Mapper = mapper;
            this.userDataService = userDataService;
        }
      [HttpGet]
        public async Task<IActionResult> AllRobots()
        {
           // var courses = await this.DbContext.Courses.ToListAsync();
           // var modelCourses = this.Mapper.Map<IEnumerable<CourseConciseViewModel>>(courses);

            var user = await userManager.GetUserAsync(HttpContext.User);

            var currentUser = await userDataService.GetCurrentUserWithRobotsAsync(user);
            if (currentUser == null)
            {
                return NotFound();
            }
            var robots = currentUser.Robots.ToList();
            var detailRobots = this.Mapper.Map<IEnumerable<RobotPartialInfoViewModel>>(robots);
            return this.View(detailRobots);
        }
        [HttpGet]
       public async Task<IActionResult> Items()
        {
            var user = await userManager.GetUserAsync(HttpContext.User);

            var userWithWeaponsAndArmors = await userDataService.GetCurrentUserWithItemsAsync(user);
            if (userWithWeaponsAndArmors == null)
            {
                return NotFound();
            }
            var model = Mapper.Map<UserAllItemsViewModel>(userWithWeaponsAndArmors);
            return this.View(model);
        }
        
       
    }
}
