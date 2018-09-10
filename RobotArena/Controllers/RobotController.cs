using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RobotArena.Data;
using RobotArena.Models;
using RobotArena.Common.Models.Armor;
using RobotArena.Common.Models.Item;
using RobotArena.Common.Models.Robot;
using RobotArena.Models.Robots;
using RobotArena.Common.Models.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RobotArena.Services.RobotServices.Interfaces;
using System.Security.Claims;
using RobotArena.Services.ArmorServices.Interfaces;
using RobotArena.Services.WeaponServices.Interfaces;

namespace RobotArena.Controllers
{
    [Authorize]
    public class RobotController : Controller
    {
       
        private readonly IRobotDataService robotDataService;
        private readonly UserManager<User> userManager;
        private readonly IWeaponDataService weaponDataService;
        private readonly IArmorDataService armorDataService;
        private readonly IMapper Mapper;
        public RobotController(UserManager<User> usermanager,IMapper mapper,IRobotDataService robotDataService,IWeaponDataService weaponDataService,IArmorDataService armorDataService)
        {
            this.userManager = usermanager;            
            this.Mapper = mapper;
            this.robotDataService = robotDataService;
            this.weaponDataService = weaponDataService;
            this.armorDataService = armorDataService;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }
       
           public IActionResult CreateFireRobot()
            {
         
           
            var robot = new Robot()
            {
                BaseHealth = 1000,
                CurrentHealth = 1000,
                BaseDamage = 100,               
                Type = "Fire",
                ImageUrl="https://i.ytimg.com/vi/Rrb4jW_uJxE/hqdefault.jpg"

            };

            
          robotDataService.CreateRobotAsync(HttpContext.User, robot);
            //user.Robots.Add(robot);
            //this.context.Add(robot);
            //this.context.SaveChanges();

            return RedirectToAction("Edit",new { Id = robot.Id });
        }
        public IActionResult CreateNatureRobot()
        {
           

            var robot = new Robot()
            {
                BaseHealth = 1000,
                CurrentHealth = 1000,
                BaseDamage = 100,             
                Type = "Nature",
                ImageUrl= "http://www.hasbrotoyshop.com/wcsstore/HTSCatalogAssetStore//common/productimages/en_US/c76b3fe750569047f556a4ec7a4cfd3f/2bfb954ad5e9224a761602a1bfba775b789f1772.jpg"

            };
           robotDataService.CreateRobotAsync(HttpContext.User, robot);
            return RedirectToAction("Edit", new { Id = robot.Id });
        }
        public IActionResult CreateWaterRobot()
        {
            

            var robot = new Robot()
            {
                BaseHealth = 1000,
               CurrentHealth=1000,
                BaseDamage = 100,            
                Type = "Water",
                ImageUrl= "https://image.shutterstock.com/z/stock-vector-flying-metallically-blue-robot-warrior-cyborg-148640156.jpg"

            };
           robotDataService.CreateRobotAsync(HttpContext.User, robot);
            return RedirectToAction("Edit", new { Id = robot.Id });
        }
       
        [HttpGet]
        public async Task<IActionResult> Details(int Id)
        {

            var robotViewModel = await robotDataService.PrepareRobotForDetailsAsync(Id);
            if (robotViewModel == null)
            {
                return NotFound();
            }
            //var m = context.Robots.Include(r => r.Armors).Include(r => r.Weapons).FirstOrDefault(r => r.Id == Id);


            //var robotViewModel = new RobotDetailsViewModel
            //{
            //    Id = m.Id,
            //    Name = m.Name,
            //    Type = m.Type,
            //    Armor=m.Armor,
            //    ImageUrl = m.ImageUrl,
            //    BaseHealth = m.BaseHealth,
            ////    CurrentHealth = m.CurrentHealth,
            //    BaseDamage = m.BaseDamage,
            //    TotalDamage=m.TotalDamage,
            //    Wins = m.Wins,
            //    Losses = m.Losses,
            //    DamageReduction = m.DamageReduction,
            //    RankPlace = m.RankPlace,
            //    Armors = m.Armors.Select(a => new ArmorDetailsViewModel
            //    { Id = a.Id,
            //    Name=a.Name,
            //        ArmorPoints = a.ArmorPoints,
            //        CurrentArmor=a.CurrentArmor,
            //        ImageUrl=a.ImageUrl,
            //        Durability = a.Durability
            //    }),
            //    Weapons = m.Weapons.Select(w => new WeaponDetailsViewModel
            //    {
            //       Id = w.Id,
            //        Name = w.Name,
            //        ImageUrl=w.ImageUrl,
            //        DamagePoints = w.DamagePoints,
            //        CurrentDamage=w.CurrentDamage,
            //        Durability = w.Durability,
            //        CriticalAttackMode = w.CriticalAttackMode
            //    }).ToList()

            //};

            return this.View(robotViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int Id)
        {//TODO
            var robotViewModel = await robotDataService.PrepareRobotForDetailsAsync(Id);
            if(robotViewModel==null)
            {
                return NotFound();
            }
            /*  var m = context.Robots.Include(r=>r.Weapons).Include(r=>r.Armors).FirstOrDefault(r => r.Id == Id);         
             //TODO MAPPER
              var robotViewModel = new RobotDetailsViewModel
              {
                  Id = m.Id,              
                  Name = m.Name,
                  Type = m.Type,
                  ImageUrl = m.ImageUrl,
                  BaseHealth = m.BaseHealth,
                  BaseDamage = m.BaseDamage,
                  Wins = m.Wins,
                  Losses = m.Losses,
                  DamageReduction = m.DamageReduction,
                  RankPlace = m.RankPlace,
                  Armors = m.Armors.Select(a => new ArmorDetailsViewModel
                  {
                      Id = a.Id,
                      Name = a.Name,
                      ArmorPoints = a.ArmorPoints,
                    CurrentArmor=a.CurrentArmor,
                      ImageUrl = a.ImageUrl,
                      Durability = a.Durability
                  }),
                  Weapons = m.Weapons.Select(w => new WeaponDetailsViewModel
                  {
                      Id = w.Id,
                      Name = w.Name,
                      ImageUrl = w.ImageUrl,
                      DamagePoints = w.DamagePoints,
                      CurrentDamage=w.CurrentDamage,
                      Durability = w.Durability,
                      CriticalAttackMode = w.CriticalAttackMode
                  }).ToList()

              };*/
            return this.View(robotViewModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int Id)
        {
           await robotDataService.DeleteRobotAsync(Id);
            return RedirectToAction("AllRobots", "Users");


        }
        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            var robot = await robotDataService.GetRobotByIdAsync(Id);
            if(robot==null)
            {
                return NotFound();
            }
            var model = Mapper.Map<UpdateNameBindingModel>(robot);            
            return this.View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int Id, UpdateNameBindingModel model)
        {
            if(model.Name.Length<3)
            {
                TempData["InvalidName"] = "Name must be at least 3 characters long";
                return this.View();
                
            }
         await robotDataService.EditRobotAsync(Id, model);           
            return RedirectToAction("AllRobots", "Users");
        }
        [HttpGet]
        public async Task<IActionResult> Equip(int Id)
        {
            var model = await robotDataService.PrepareItemsForEquippingAsync(Id, HttpContext.User);
            if(model==null)
            {
                return NotFound();
            }
            return this.View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EquipArmor(int RobotId,int ArmorId)
        {
            var message = await armorDataService.EquipArmorAsync(RobotId, ArmorId);
            if (message == null)
            {
                return NotFound();
            }
            TempData["Equip"] = message;
            return this.RedirectToAction("Equip", new { Id = RobotId });
           
        }
        [HttpPost]
        public async Task<IActionResult> UnequipArmor(int RobotId, int ArmorId)
        {

            var message = await armorDataService.UnequipArmorAsync(RobotId, ArmorId);
            if (message == null)
            {
                return NotFound();
            }
            TempData["Equip"] = message;
            return this.RedirectToAction("Equip",new { Id = RobotId });
        }
      
        [HttpPost]
        public async Task<IActionResult> EquipWeapon(int RobotId, int WeaponId)
        {
            
           var message = await weaponDataService.EquipWeaponAsync(RobotId, WeaponId);
            if (message == null)
            {
                return NotFound();
            }
            TempData["Equip"] = message;
            return this.RedirectToAction("Equip", new { Id = RobotId });
        }
        [HttpPost]
        public async Task<IActionResult> UnequipWeapon(int RobotId, int WeaponId)
        {
            var message = await weaponDataService.UnequipWeaponAsync(RobotId, WeaponId);
            if(message==null)
            {
                return NotFound();
            }
            TempData["Equip"] = message;
            return this.RedirectToAction("Equip", new { Id = RobotId });
        }
    }

}
