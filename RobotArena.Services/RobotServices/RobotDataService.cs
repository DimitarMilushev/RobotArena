using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RobotArena.Common.Models.Armor;
using RobotArena.Common.Models.Item;
using RobotArena.Common.Models.Repair;
using RobotArena.Common.Models.Robot;
using RobotArena.Common.Models.Weapon;
using RobotArena.Data;
using RobotArena.Models;
using RobotArena.Models.Items;
using RobotArena.Models.Robots;
using RobotArena.Services.RobotServices.Interfaces;

namespace RobotArena.Services.RobotServices
{
    public class RobotDataService : BaseEFService, IRobotDataService
    {
        private readonly UserManager<User> userManager;
        public RobotDataService(RobotContext dbContext, IMapper mapper, UserManager<User> userManager)
            : base(dbContext, mapper)
        {
            this.userManager = userManager;
        }
        public async Task<IEnumerable<RobotFightViewModel>> PrepareRobotForFightAsync(ClaimsPrincipal user)
        {
            
            var userFromDB = await this.userManager.GetUserAsync(user);
         
            var currentUser =await DbContext.Users.Include(u => u.Robots).FirstOrDefaultAsync(u => u.Id == userFromDB.Id);
          
            var robots = currentUser.Robots.Where(r => r.CurrentHealth > 0).ToList();
            var robotsView = Mapper.Map<IEnumerable<RobotFightViewModel>>(robots);

           // var robots = await this.DbContext.Robots.ToListAsync();
            var modelRobots = this.Mapper.Map<IEnumerable<RobotFightViewModel>>(robots);
            return modelRobots;
        }
        public void CreateRobotAsync(ClaimsPrincipal userPrincipal,Robot robot)
        {
            var user = userManager.GetUserAsync(userPrincipal).Result;
         user.Robots.Add(robot);
           this.DbContext.Robots.Add(robot);            
            this.DbContext.SaveChanges();
        }
       public async Task DeleteRobotAsync(int Id)
        {
            var robot = await GetRobotWithAllItemsByIdAsync(Id);
            
            var weapons =  robot.Weapons.ToList();
            var armors =  robot.Armors.ToList();

            weapons.ForEach(w => w.DisconnectFromRobot());
            armors.ForEach(a => a.DisconnectFromRobot());

            this.DbContext.Robots.Remove(robot);
            await this.DbContext.SaveChangesAsync();
        }
        public async Task<RobotDetailsViewModel> PrepareRobotForDetailsAsync(int Id)
        {
            var robot = await GetRobotWithAllItemsByIdAsync(Id);
            if (robot==null)
            {
                return null;
            }         
            var robotViewModel = Mapper.Map<RobotDetailsViewModel>(robot);
            return robotViewModel;
        }            
        public async Task<UserAllItemsWithRobotIdViewModel> PrepareItemsForEquippingAsync(int Id,ClaimsPrincipal userPrincipal)
        {
            var robot = await GetRobotByIdAsync(Id);
            if(robot==null)
            {
                return null;
            }
            var currentUser = await userManager.GetUserAsync(userPrincipal);
            var user = await DbContext.Users.Include(a => a.Armors).Include(w => w.Weapons).FirstOrDefaultAsync(u => u.Id == currentUser.Id);
            if(user == null)
            {
                return null;
            }
            var weapons = user.Weapons.Where(w => w.RobotId == Id || w.RobotId == null);
            var armors = user.Armors.Where(a => a.RobotId == Id || a.RobotId == null);
            var weaponsModel = Mapper.Map<ICollection<WeaponDetailsWithRobotIdViewModel>>(weapons);
            var armorsModel = Mapper.Map<ICollection<ArmorDetailsWithRobotIdViewModel>>(armors);
            var model = new UserAllItemsWithRobotIdViewModel()
            {
                RobotId = Id,
                Weapons = weaponsModel,
                Armors = armorsModel
            };
            return model;

        }       
        public async Task EditRobotAsync(int Id, UpdateNameBindingModel model)
        {
            var robot = await GetRobotByIdAsync(Id);        
            robot.Name = model.Name;

            await this.DbContext.SaveChangesAsync();
        }
        public async Task<Robot> GetRobotByIdAsync(int Id)
        {
            var robot = await DbContext.Robots.FirstOrDefaultAsync(r => r.Id == Id);
            return robot;
        }
        public async Task<Robot> GetRobotWithWeaponsByIdAsync(int Id)
        {
            var robot = await DbContext.Robots.Include(r=>r.Weapons).FirstOrDefaultAsync(r => r.Id == Id);
            return robot;
        }
        public async Task<Robot> GetRobotWithArmorsByIdAsync(int Id)
        {
            var robot = await DbContext.Robots.Include(r => r.Armors).FirstOrDefaultAsync(r => r.Id == Id);
            return robot;
        }
        public async Task<Robot> GetRobotWithAllItemsByIdAsync(int Id)
        {
            var robot = await DbContext.Robots.Include(r=>r.Armors).Include(r=>r.Weapons).FirstOrDefaultAsync(r => r.Id == Id);
            return robot;
        }

    }
}
