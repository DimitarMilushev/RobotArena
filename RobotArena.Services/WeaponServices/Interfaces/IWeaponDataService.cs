using RobotArena.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RobotArena.Services.WeaponServices.Interfaces
{
   public interface IWeaponDataService
    {
        Task<Weapon> GetWeaponByIdFromDatabaseAsync(int Id);
        Task<string> UnequipWeaponAsync(int RobotId, int WeaponId);
        Task<string> EquipWeaponAsync(int RobotId, int WeaponId);
        Task<List<Weapon>> GetWeaponsForStoreAsync();
        Task<Weapon> GetWeaponWithOwnerByIdFromDatabaseAsync(int Id);
    }
}
