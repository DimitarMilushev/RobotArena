using AutoMapper;
using Microsoft.AspNetCore.Identity;
using RobotArena.Data;
using RobotArena.Models;
using RobotArena.Models.NPC;
using RobotArena.Services.CreepServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RobotArena.Services.RobotServices.Interfaces;

namespace RobotArena.Services.CreepServices
{
    public class CreepDataService :BaseEFService,ICreepDataService
    {
        private readonly UserManager<User> userManager;
        public CreepDataService(RobotContext dbContext,IMapper mapper)
            : base(dbContext, mapper)
        {
            
        }
        public async Task<Creep> GetCreepByIdAsync(int Id)
        {
            var creep = await DbContext.Creeps.FirstOrDefaultAsync(c => c.Id == Id);
            return creep;
        }
        public async Task<List<Creep>> GetAllCreepsAsync()
        {
            var creeps = await DbContext.Creeps.ToListAsync();
            return creeps;
        }
    }
}
