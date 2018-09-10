using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RobotArena.Common.Models.BindingModels.Armor;
using RobotArena.Data;
using RobotArena.Models;
using RobotArena.Models.Items;
using RobotArena.Services.ArmorServices.Interfaces;
using RobotArena.Services.RobotServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RobotArena.Services.ArmorServices
{
    public class ArmorDataService : BaseEFService, IArmorDataService
    {
        private readonly UserManager<User> userManager;
        private readonly IRobotDataService robotDataService;
        public ArmorDataService(RobotContext dbContext,IRobotDataService robotDataService, IMapper mapper, UserManager<User> userManager)
            : base(dbContext, mapper)
        {
            this.userManager = userManager;
            this.robotDataService = robotDataService;
        }
    
        public async Task<Armor> CreateArmorAsync(ArmorCreationBindingModel model)
        {
            var armor = Mapper.Map<Armor>(model);
            await this.DbContext.Armors.AddAsync(armor);
            await this.DbContext.SaveChangesAsync();
            return armor;
        }

        public async Task<string> UnequipArmorAsync(int RobotId, int ArmorId)
        {
            var robot = await robotDataService.GetRobotByIdAsync(RobotId);
            if (robot == null)
            {
                return null;
            }

            var armor = await GetArmorByIdFromDatabaseAsync(ArmorId);

            if (armor == null)
            {
                return null;
            }
            robot.Armors.Remove(armor);
            await DbContext.SaveChangesAsync();
            string message = $"Successfully unequipped {armor.Name}";
            return message;
        }
        public async Task<string> EquipArmorAsync(int RobotId, int ArmorId)
        {
            var robot = await robotDataService.GetRobotByIdAsync(RobotId);
            if (robot == null)
            {
                return null;
            }

            var armor = await GetArmorByIdFromDatabaseAsync(ArmorId);

            if (armor == null)
            {
                return null;
            }
            robot.Armors.Add(armor);

            await this.DbContext.SaveChangesAsync();
            string message = $"Successfully equipped {armor.Name}";
            return message;
        }
        public async Task<Armor> GetArmorByIdFromDatabaseAsync(int Id)
        {
            //var robot = context.Robots.FirstOrDefault(r => r.Id == RobotId);
            var armorFromDB = await DbContext.Armors.FirstOrDefaultAsync(r => r.Id == Id);

            return armorFromDB;
        }

    }
}
