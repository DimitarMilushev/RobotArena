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

namespace RobotArena.Controllers
{
    [Authorize]
    public class StoreController : Controller
    {
        private readonly UserManager<User> userManager;
        private RobotContext context;
        private readonly IMapper Mapper;

        public StoreController(UserManager<User> userManager, RobotContext context, IMapper mapper)
        {
            this.userManager = userManager;
            this.context = context;
            this.Mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return this.View();
        }
        [HttpGet]
        public IActionResult Weapons()
        {
            var weapons = this.context.Weapons.Where(w=>w.UserId==null).ToList();
            var model = Mapper.Map<IEnumerable<WeaponDetailsViewModel>>(weapons);
            return this.View(model);
        }
        [HttpGet]
        public IActionResult Armors()
        {
            var armors = this.context.Armors.Where(a => a.UserId == null).ToList();
            var model = Mapper.Map<IEnumerable<ArmorDetailsViewModel>>(armors);
            return this.View(model);
        }
        [HttpGet]
        public IActionResult BuyWeapon(int Id)
        {
            var weapon = context.Weapons.FirstOrDefault(w => w.Id == Id);
            if (weapon == null)
            {
                return NotFound();
            }
            var model = Mapper.Map<WeaponDetailsViewModel>(weapon);
            return this.View(model);
        }
        [HttpPost]
        [ActionName("BuyWeapon")]
        public IActionResult BuyWeaponPost(int Id)
        {
            var weapon = context.Weapons.FirstOrDefault(w => w.Id == Id);
            if (weapon == null)
            {
                return NotFound();
            }
            var user = userManager.GetUserAsync(HttpContext.User).Result;
            var userCoins = user.Coins;
            var weaponPrice = weapon.Price;
            if (userCoins>=weaponPrice)
            {
                user.Weapons.Add(weapon);
                user.Coins -= weaponPrice;
                weapon.UserId = user.Id;
                context.SaveChanges();
                TempData["Message"] = $"Successfully bought {weapon.Name}";
                return RedirectToAction("Weapons");
            }
            var missingMoney = weaponPrice - user.Coins;
                TempData["Message"] = $"You need {missingMoney} more coins";
            return RedirectToAction("Weapons");
        }
        [HttpGet]
        public IActionResult BuyArmor(int Id)
        {
            var armor = context.Armors.FirstOrDefault(a => a.Id == Id);
            if (armor == null)
            {
                return NotFound();
            }
            var model = Mapper.Map<ArmorDetailsViewModel>(armor);
            return this.View(model);
        }
        [HttpPost]
        [ActionName("BuyArmor")]
        public IActionResult BuyArmorPost(int Id)
        {
           
            var user = userManager.GetUserAsync(HttpContext.User).Result;
            var userCoins = user.Coins;
            var armor = context.Armors.FirstOrDefault(a => a.Id == Id);
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
                context.SaveChanges();
                TempData["Message"] = $"Successfully bought {armor.Name}";
                return RedirectToAction("Armors");
            }
            var missingMoney = armorPrice - user.Coins;
            TempData["Message"] = $"You need {missingMoney} more coins";
            return RedirectToAction("Armors");
        }
        [HttpGet]
        public IActionResult SellWeapon(int Id)
        {
            var weapon = context.Weapons.FirstOrDefault(w => w.Id == Id);
            if (weapon == null)
            {
                return NotFound();
            }
            var model = Mapper.Map<WeaponDetailsViewModel>(weapon);
            return this.View(model);
        }
        [HttpPost]
        [ActionName("SellWeapon")]
        public IActionResult SellWeaponPost(int Id)
        {
            var weapon = context.Weapons.FirstOrDefault(w => w.Id == Id);
            if (weapon == null)
            {
                return NotFound();
            }
            var user = context.Users.FirstOrDefault(u => u.Id == weapon.UserId);
            if (user == null)
            {
                return NotFound();
            }
            var weaponReturnPrice =weapon.Price /2;
            weapon.RobotId = null;
            user.Coins += weaponReturnPrice;
            user.Weapons.Remove(weapon);
            context.SaveChanges();
            TempData["Sell"] = $"Successfully sold {weapon.Name}";
            return RedirectToAction("Items", "Users");
        }
        [HttpGet]
        public IActionResult SellArmor(int Id)
        {
            var armor = context.Armors.FirstOrDefault(a => a.Id == Id);
            if (armor == null)
            {
                return NotFound();
            }
            var model = Mapper.Map<ArmorDetailsViewModel>(armor);
            return this.View(model);
        }
        [HttpPost]
        [ActionName("SellArmor")]
        public IActionResult SellArmorPost(int Id)
        {
            var armor = context.Armors.FirstOrDefault(a => a.Id == Id);
            if (armor == null)
            {
                return NotFound();
            }
            var user = context.Users.FirstOrDefault(u => u.Id == armor.UserId);
            if (user == null)
            {
                return NotFound();
            }
            var armorReturnPrice = armor.Price / 2;
            user.Coins += armorReturnPrice;
            armor.RobotId = null;
            user.Armors.Remove(armor);
            context.SaveChanges();
           
                TempData["Sell"] = $"Successfully sold {armor.Name}";
            
            return RedirectToAction("Items", "Users");
        }
    }
}