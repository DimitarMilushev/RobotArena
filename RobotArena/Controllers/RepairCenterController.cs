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
using RobotArena.Services.UserSerices;
using RobotArena.Services.WeaponServices.Interfaces;
using RobotArena.Services.ArmorServices.Interfaces;
using RobotArena.Services.RobotServices.Interfaces;
using RobotArena.Services.ContextServices.Interfaces;

namespace RobotArena.Controllers
{
    [Authorize]
    public class RepairCenterController : Controller
    {
        private readonly UserManager<User> userManager;      
        private readonly IUserDataService userDataService;
        private readonly IWeaponDataService weaponDataService;
        private readonly IArmorDataService armorDataService;
        private readonly IRobotDataService robotDataService;
        private readonly IDbContextService dbContextService;
        private readonly IMapper Mapper;

        public RepairCenterController(UserManager<User> userManager, IMapper mapper, IDbContextService dbContextService,IRobotDataService robotDataService,IArmorDataService armorDataService,IWeaponDataService weaponDataService,IUserDataService userDataService)
        {
            this.userManager = userManager;           
            this.userDataService = userDataService;
            this.weaponDataService = weaponDataService;
            this.armorDataService = armorDataService;
            this.robotDataService = robotDataService;
            this.dbContextService = dbContextService;
            this.Mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var currentUser = await userManager.GetUserAsync(HttpContext.User);
            var user = await userDataService.GetCurrentUserWithItemsAndRobotsAsync(currentUser);
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
        public async Task<IActionResult> Repair(int itemId,string itemType)
        {
          
            if(itemType=="ArmorRepairViewModel")
            {
                var model = await armorDataService.GetArmorWithOwnerByIdFromDatabaseAsync(itemId);
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
                    dbContextService.SaveChanges();                   
                        TempData["RepairSuccess"] = $"Succesfully repaired {model.Name}";                    
                    return RedirectToAction("Index");
                }
                var missingMoney = repairPrice - user.Coins;
                TempData["RepairError"] = $"You need {missingMoney} more coins";
               
            }
            else if (itemType == "WeaponRepairViewModel")
            {
                var model = await weaponDataService.GetWeaponWithOwnerByIdFromDatabaseAsync(itemId);
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
                    dbContextService.SaveChanges();
                    TempData["RepairSuccess"] = $"Succesfully repaired {model.Name}";
                    return RedirectToAction("Index");
                }
                var missingMoney = repairPrice - user.Coins;
                TempData["RepairError"] = $"You need {missingMoney} more coins";
                
            }
            else if(itemType=="RobotRepairViewModel")
            {
                var model = await robotDataService.GetRobotWithOwnerByIdFromDatabaseAsync(itemId);
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
                    dbContextService.SaveChanges();
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