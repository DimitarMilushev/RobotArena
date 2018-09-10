using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RobotArena.Data;
using RobotArena.Models;
using RobotArena.Models.Items;
using RobotArena.Services.RobotServices;
using RobotArena.Services.RobotServices.Interfaces;
using RobotArena.Services.WeaponServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RobotArena.Services.WeaponServices
{
    public class WeaponDataService :BaseEFService,IWeaponDataService
    {
        private readonly UserManager<User> userManager;
        private readonly IRobotDataService robotDataService;
        public WeaponDataService(RobotContext dbContext,IRobotDataService robotDataService, IMapper mapper, UserManager<User> userManager)
            : base(dbContext, mapper)
        {
            this.userManager = userManager;
            this.robotDataService = robotDataService;
        }


        public async Task<Weapon> GetWeaponByIdFromDatabaseAsync(int Id)
        {
            //var robot = context.Robots.FirstOrDefault(r => r.Id == RobotId);
            var weaponFromDB = await DbContext.Weapons.FirstOrDefaultAsync(r => r.Id == Id);

            return weaponFromDB;
        }
        public async Task<string> UnequipWeaponAsync(int RobotId, int WeaponId)
        {
            var robot = await robotDataService.GetRobotByIdAsync(RobotId);
            if (robot == null)
            {
                return null;
            }
            var weapon = await GetWeaponByIdFromDatabaseAsync(WeaponId);
            if (weapon == null)
            {
                return null;
            }
            robot.Weapons.Remove(weapon);
            await DbContext.SaveChangesAsync();
            string message = $"Successfully unequipped {weapon.Name}";
            return message;
        }
        public async Task<string> EquipWeaponAsync(int RobotId, int WeaponId)
        {
            var robot = await robotDataService.GetRobotByIdAsync(RobotId);
            if (robot == null)
            {
                return null;
            }
            var weapon = await GetWeaponByIdFromDatabaseAsync(WeaponId);
            if (weapon == null)
            {
                return null;
            }
            robot.Weapons.Add(weapon);
            await DbContext.SaveChangesAsync();
            string message = $"Successfully equipped {weapon.Name}";
            return message;
        }
    }
}
