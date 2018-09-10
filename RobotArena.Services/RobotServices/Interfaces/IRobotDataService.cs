using RobotArena.Common.Models.Item;
using RobotArena.Common.Models.Robot;
using RobotArena.Models;
using RobotArena.Models.Items;
using RobotArena.Models.Robots;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RobotArena.Services.RobotServices.Interfaces
{
    public interface IRobotDataService
    {
       Task<IEnumerable<RobotFightViewModel>> PrepareRobotForFightAsync(ClaimsPrincipal user);
        Task<RobotDetailsViewModel> PrepareRobotForDetailsAsync(int Id);
        Task<Robot> GetRobotByIdAsync(int Id);
        Task<Robot> GetRobotWithWeaponsByIdAsync(int Id);
        Task<Robot> GetRobotWithArmorsByIdAsync(int Id);
        Task<Robot> GetRobotWithAllItemsByIdAsync(int Id);
    
       Task<UserAllItemsWithRobotIdViewModel> PrepareItemsForEquippingAsync(int Id, ClaimsPrincipal userPrincipal);
        Task EditRobotAsync(int Id, UpdateNameBindingModel model);
        Task DeleteRobotAsync(int Id);
        void CreateRobotAsync(ClaimsPrincipal userPrincipal, Robot robot);
    }
}
