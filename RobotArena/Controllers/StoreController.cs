using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RobotArena.Data;
using RobotArena.Models;
using RobotArena.Common.Models.Armor;
using RobotArena.Common.Models.Weapon;
using RobotArena.Services.WeaponServices.Interfaces;
using RobotArena.Services.ArmorServices.Interfaces;
using Microsoft.EntityFrameworkCore;
using RobotArena.Services.ContextServices.Interfaces;

namespace RobotArena.Controllers
{
    [Authorize]
    public class StoreController : Controller
    {
        private readonly UserManager<User> userManager;       
        private readonly IMapper Mapper;
        private readonly IWeaponDataService weaponDataService;
        private readonly IArmorDataService armorDataService;
        private readonly IDbContextService dbContextService;

        public StoreController(UserManager<User> userManager,IWeaponDataService weaponDataService,IArmorDataService armorDataService,IDbContextService dbContextService, IMapper mapper)
        {
            this.userManager = userManager;            
         
            this.Mapper = mapper;
            this.weaponDataService = weaponDataService;
            this.armorDataService = armorDataService;
            this.dbContextService = dbContextService;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return this.View();
        }
        [HttpGet]
        public async Task<IActionResult> Weapons()
        {
            var weapons = await weaponDataService.GetWeaponsForStoreAsync();         
            var model = Mapper.Map<IEnumerable<WeaponDetailsViewModel>>(weapons);
            return this.View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Armors()
        {
            var armors = await armorDataService.GetArmorsForStoreAsync();
            var model = Mapper.Map<IEnumerable<ArmorDetailsViewModel>>(armors);
            return this.View(model);
        }
        [HttpGet]
        public async Task<IActionResult> BuyWeapon(int Id)
        {
            var weapon = await weaponDataService.GetWeaponByIdFromDatabaseAsync(Id);
            if (weapon == null)
            {
                return NotFound();
            }
            var model = Mapper.Map<WeaponDetailsViewModel>(weapon);
            return this.View(model);
        }
        [HttpPost]
        [ActionName("BuyWeapon")]
        public async Task<IActionResult> BuyWeaponPost(int Id)
        {
            var weapon = await weaponDataService.GetWeaponByIdFromDatabaseAsync(Id);
            if (weapon == null)
            {
                return NotFound();
            }
            //TODO await on all methods
            var user = await userManager.GetUserAsync(HttpContext.User);
            var userCoins = user.Coins;
            var weaponPrice = weapon.Price;
            if (userCoins>=weaponPrice)
            {
                user.Weapons.Add(weapon);
                user.Coins -= weaponPrice;
                weapon.UserId = user.Id;
                dbContextService.SaveChanges();
                TempData["Message"] = $"Successfully bought {weapon.Name}";
                return RedirectToAction("Weapons");
            }
            var missingMoney = weaponPrice - user.Coins;
                TempData["Message"] = $"You need {missingMoney} more coins";
            return RedirectToAction("Weapons");
        }
        [HttpGet]
        public async Task<IActionResult> BuyArmor(int Id)
        {
            var armor = await armorDataService.GetArmorByIdFromDatabaseAsync(Id);
            if (armor == null)
            {
                return NotFound();
            }
            var model = Mapper.Map<ArmorDetailsViewModel>(armor);
            return this.View(model);
        }
        [HttpPost]
        [ActionName("BuyArmor")]
        public async Task<IActionResult> BuyArmorPost(int Id)
        {
//TODO await instead of Result           
            var user = await userManager.GetUserAsync(HttpContext.User);
            var userCoins = user.Coins;
            var armor = await armorDataService.GetArmorByIdFromDatabaseAsync(Id);
            if (armor == null)
            {
                return NotFound();
            }
            var armorPrice = armor.Price;
            if(userCoins>=armorPrice)
            {
                user.Armors.Add(armor);
                user.Coins -= armorPrice;
                armor.UserId = user.Id;
                dbContextService.SaveChanges();
                TempData["Message"] = $"Successfully bought {armor.Name}";
                return RedirectToAction("Armors");
            }
            var missingMoney = armorPrice - user.Coins;
            TempData["Message"] = $"You need {missingMoney} more coins";
            return RedirectToAction("Armors");
        }
        [HttpGet]
        public async Task<IActionResult> SellWeapon(int Id)
        {
            var weapon = await weaponDataService.GetWeaponByIdFromDatabaseAsync(Id);
            if (weapon == null)
            {
                return NotFound();
            }
            var model = Mapper.Map<WeaponDetailsViewModel>(weapon);
            return this.View(model);
        }
        [HttpPost]
        [ActionName("SellWeapon")]
        public async Task<IActionResult> SellWeaponPost(int Id)
        {
            var weapon = await weaponDataService.GetWeaponByIdFromDatabaseAsync(Id);
            if (weapon == null)
            {
                return NotFound();
            }
                 var user = await userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return NotFound();
            }
            var weaponReturnPrice =weapon.Price /2;
            weapon.RobotId = null;
            user.Coins += weaponReturnPrice;
            user.Weapons.Remove(weapon);
            dbContextService.SaveChanges();
            TempData["Sell"] = $"Successfully sold {weapon.Name}";
            return RedirectToAction("Items", "Users");
        }
        [HttpGet]
        public async Task<IActionResult> SellArmor(int Id)
        {
            var armor = await armorDataService.GetArmorByIdFromDatabaseAsync(Id);
            if (armor == null)
            {
                return NotFound();
            }
            var model = Mapper.Map<ArmorDetailsViewModel>(armor);
            return this.View(model);
        }
        [HttpPost]
        [ActionName("SellArmor")]
        public async Task<IActionResult> SellArmorPost(int Id)
        {
            var armor = await armorDataService.GetArmorByIdFromDatabaseAsync(Id);
            if (armor == null)
            {
                return NotFound();
            }
            var user = await userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return NotFound();
            }
            var armorReturnPrice = armor.Price / 2;
            user.Coins += armorReturnPrice;
            armor.RobotId = null;
            user.Armors.Remove(armor);
            dbContextService.SaveChanges();
           
                TempData["Sell"] = $"Successfully sold {armor.Name}";
            
            return RedirectToAction("Items", "Users");
        }
    }
}