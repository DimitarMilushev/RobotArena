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
using RobotArena.Models;
using RobotArena.Common.Models.Repair;

namespace RobotArena.Controllers
{
    [Authorize]
    public class RepairCenterController : Controller
    {
        private readonly UserManager<User> userManager;
        private RobotContext context;
        private readonly IMapper Mapper;

        public RepairCenterController(UserManager<User> userManager, RobotContext context, IMapper mapper)
        {
            this.userManager = userManager;
            this.context = context;
            this.Mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var currentUser = userManager.GetUserAsync(HttpContext.User).Result;
            var user = context.Users.Include(r=>r.Robots).Include(a => a.Armors).Include(w => w.Weapons).FirstOrDefault(u => u.Id == currentUser.Id);
            if (user == null)
            {
                return NotFound();
            }
            var robots = user.Robots.Where(r=>r.CurrentHealth!=r.BaseHealth).ToList();
            var weapons = user.Weapons.Where(w=>w.Durability!=100).ToList();
            var armors = user.Armors.Where(a => a.Durability != 100).ToList();

            var robotsViewModel = Mapper.Map<IEnumerable<RobotRepairViewModel>>(robots);
            var weaponsViewModel = Mapper.Map<IEnumerable<WeaponRepairViewModel>>(weapons);
            var armorsViewModel = Mapper.Map<IEnumerable<ArmorRepairViewModel>>(armors);

            var repairModel = new RepairViewModel()
            {
                RobotsViewModel = robotsViewModel,
                WeaponsViewModel = weaponsViewModel,
                ArmorsViewModel = armorsViewModel
            };
            return this.View(repairModel);
        }
        [HttpPost]
        public IActionResult Repair(int itemId,string itemType)
        {
          
            if(itemType=="ArmorRepairViewModel")
            {
               var model = context.Armors.Include(a=>a.User).FirstOrDefault(a => a.Id == itemId);
                if (model == null)
                {
                    return NotFound();
                }
                var repairPrice = (100 - model.Durability) * 5;
                var user = model.User;
                if(user.Coins>=repairPrice)
                {
                    user.Coins -= repairPrice;
                    model.Durability = 100;
                    context.SaveChanges();                    
                        TempData["RepairSuccess"] = $"Succesfully repaired {model.Name}";                    
                    return RedirectToAction("Index");
                }
                var missingMoney = repairPrice - user.Coins;
                TempData["RepairError"] = $"You need {missingMoney} more coins";
               
            }
            else if (itemType == "WeaponRepairViewModel")
            {
                var model = context.Weapons.Include(a => a.User).FirstOrDefault(w => w.Id == itemId);
                if (model == null)
                {
                    return NotFound();
                }
                var repairPrice = (100 - model.Durability) * 5;
                var user = model.User;
                if (user.Coins >= repairPrice)
                {
                    user.Coins -= repairPrice;
                    model.Durability = 100;
                    model.CriticalAttackMode = true;
                    context.SaveChanges();
                    TempData["RepairSuccess"] = $"Succesfully repaired {model.Name}";
                    return RedirectToAction("Index");
                }
                var missingMoney = repairPrice - user.Coins;
                TempData["RepairError"] = $"You need {missingMoney} more coins";
                
            }
            else if(itemType=="RobotRepairViewModel")
            {
                var model = context.Robots.Include(r=>r.Owner).FirstOrDefault(w => w.Id == itemId);
                if (model == null)
                {
                    return NotFound();
                }
                var repairPrice = (model.BaseHealth - model.CurrentHealth)/3;
                var user = model.Owner;
                if (user.Coins >= repairPrice)
                {
                    user.Coins -= repairPrice;
                    model.CurrentHealth = model.BaseHealth;
                    context.SaveChanges();
                    TempData["RepairSuccess"] = $"Succesfully repaired {model.Name}";
                    return RedirectToAction("Index");
                }
                var missingMoney = repairPrice - user.Coins;
                TempData["RepairError"] = $"You need {missingMoney} more coins";
            }

            return RedirectToAction("Index");
        }
    }
}