using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RobotArena.Data;

using RobotArena.Common.Models.Creep;
using RobotArena.Common.Models.Fight;
using RobotArena.Common.Models.Robot;
using RobotArena.Models;
using RobotArena.Services.RobotServices.Interfaces;

namespace RobotArena.Controllers
{
    [Authorize]
    public class BattleController : Controller
    {
        private readonly IRobotDataService robotDataService;
        private readonly UserManager<User> userManager;
        private RobotContext context;
        private readonly IMapper Mapper;
        public BattleController(UserManager<User> usermanager, RobotContext roboContext, IMapper mapper,IRobotDataService robotDataService)
        {
            this.userManager = usermanager;
            this.context = roboContext;
            this.Mapper = mapper;
            this.robotDataService = robotDataService;
        }


        public IActionResult Index()
        {
            var creeps = this.context.Creeps.ToList();
            var model = Mapper.Map<IEnumerable<CreepDetailsViewModel>>(creeps);
            return this.View(model);
        }
       [HttpGet]
        public async Task<ActionResult> Fight(int Id)
        {
           

            var robotsView = await robotDataService.PrepareRobotForFightAsync(HttpContext.User);
           
            var model = new RobotsFightViewModel
            {
                CreepId = Id,
                FightModel=robotsView
            };
            return this.View(model);
        }
        [HttpPost]
        public IActionResult Fight(int RobotId,int CreepId)
        {
           
            var robot = context.Robots.Include(r=>r.Weapons).Include(r=>r.Armors).FirstOrDefault(r => r.Id == RobotId);
            if (robot == null)
            {
                return NotFound();
            }
            var creep = context.Creeps.FirstOrDefault(c => c.Id == CreepId);
            if (robot == null)
            {
                return NotFound();
            }
            int roundsCount = 0;
            int robotDamageDone = 0;
            int creepDamageDone = 0;           
            bool ignoreArmor = false;
            bool robotIsAlive = true;
            bool creepIsAlive = true;
            var preCreepDamage = creep.Damage;
            var creepDamage = (int)(creep.Damage * decimal.Divide((100 - robot.DamageReduction),100));
            var creepType = creep.Type;
            var robotType = robot.Type;
            var robotDamage = robot.TotalDamage;
            var creepHealth = creep.Health;
            var reducedCreepDamage = (int)(creep.Damage * decimal.Divide(robot.DamageReduction, 100));
            if ((creepType=="Water" && robotType=="Fire") || (creepType == "Nature" && robotType == "Water") || (creepType == "Fire" && robotType == "Nature"))
            {
                creepDamage = preCreepDamage;
                ignoreArmor = true;
            }
            else if ((robotType == "Water" && creepType == "Fire") || (robotType == "Nature" && creepType == "Water") || (robotType == "Fire" && creepType == "Nature"))
            {
                robotDamage *= 2;
            }

            
          
            while (true)
            {
                //TODO ALL CASES ABOUT TYPES FIRE VS WATER ETC
                roundsCount++;
                robot.CurrentHealth -= creepDamage;
                creepDamageDone += creepDamage;
               if(robot.CurrentHealth<=0)
                {
                   robotIsAlive = false;
                    robot.Losses += 1;                    
                   break;
                }
                creepHealth -= robotDamage;
                robotDamageDone += robotDamage;
                if(creepHealth<=0)
                {
                    creepIsAlive = false;
                    robot.Wins += 1;
                    break;
                }
              
            }
            
            int robotReducedDamage = reducedCreepDamage * roundsCount;
            if(ignoreArmor)
            {
                robotReducedDamage = 0;
            }
            var robotModel = Mapper.Map<RobotFightViewModel>(robot);
            var creepModel = Mapper.Map<CreepFightViewModel>(creep);
            var fightResultModel = new FightResultViewModel
            {
                RobotModel = robotModel,
                CreepModel = creepModel,
                CreepDamageDone=creepDamageDone,
                RobotDamageDone=robotDamageDone,
                RobotReducedDamage=robotReducedDamage,
                RoundsCount=roundsCount,
                RobotIsAlive=robotIsAlive,
                CreepIsAlive=creepIsAlive
            };
            var user = userManager.GetUserAsync(this.ControllerContext.HttpContext.User).Result;
            if (!creepIsAlive)
            {               
                user.Coins += creep.Bounty;
            }

            robot.Weapons.ToList().ForEach(w => w.ReduceDurability());
            robot.Weapons.ToList().ForEach(w => w.RemoveCriticalStrike());
            robot.Armors.ToList().ForEach(a => a.ReduceDurability());

            context.Robots.Update(robot);
         //   context.Users.Update(user);
            context.SaveChanges();

            return View("Result",fightResultModel);
        }
        public IActionResult Result()
        {
            return this.View();

        }
    }
}