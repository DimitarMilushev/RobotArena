using RobotArena.Common.Models.BindingModels.Armor;
using RobotArena.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RobotArena.Services.ArmorServices.Interfaces
{
    public interface IArmorDataService
    {
        Task<Armor> CreateArmorAsync(ArmorCreationBindingModel model);
        Task<Armor> GetArmorByIdFromDatabaseAsync(int Id);
        Task<string> EquipArmorAsync(int RobotId, int ArmorId);
        Task<string> UnequipArmorAsync(int RobotId, int ArmorId);
        Task<List<Armor>> GetArmorsForStoreAsync();
        Task<Armor> GetArmorWithOwnerByIdFromDatabaseAsync(int Id);
    }
}
