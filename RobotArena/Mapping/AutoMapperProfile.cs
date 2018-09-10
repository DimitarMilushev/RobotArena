using AutoMapper;
using RobotArena.Models;
using RobotArena.Common.Models.Robot;
using RobotArena.Models.Robots;
using RobotArena.Common.Models.Item;
using RobotArena.Models.NPC;
using RobotArena.Common.Models.Creep;
using RobotArena.Common.Models.Repair;
using RobotArena.Models.Items;
using RobotArena.Common.Models.BindingModels.Armor;

namespace RobotArena.Mapping
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<Robot,RobotPartialInfoViewModel>();
            this.CreateMap<RobotPartialInfoViewModel,Robot>();
            this.CreateMap<Robot, UpdateModel>();
            this.CreateMap<UpdateModel, Robot>();
            this.CreateMap<User, UserAllItemsViewModel>();
            this.CreateMap<User, UserAllItemsWithRobotIdViewModel>();
            this.CreateMap<Creep, CreepDetailsViewModel>();
            this.CreateMap<Robot, RobotFightViewModel>();
            this.CreateMap<Robot, RobotsFightViewModel>();
            this.CreateMap<Robot, RobotRepairViewModel>();
            this.CreateMap<Weapon, WeaponRepairViewModel>();
            this.CreateMap<Armor, ArmorRepairViewModel>();
            this.CreateMap<ArmorCreationBindingModel, Armor>();
            this.CreateMap<Robot, RobotDetailsViewModel>();
        }
    }
}
