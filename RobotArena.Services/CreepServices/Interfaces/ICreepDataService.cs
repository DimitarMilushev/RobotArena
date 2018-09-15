using RobotArena.Models.NPC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RobotArena.Services.CreepServices.Interfaces
{
    public interface ICreepDataService
    {
        Task<Creep> GetCreepByIdAsync(int Id);
        Task<List<Creep>> GetAllCreepsAsync();
    }
}
