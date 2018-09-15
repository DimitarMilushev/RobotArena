using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RobotArena.Common.Models.Armor;
using RobotArena.Controllers;
using RobotArena.Data;
using RobotArena.Models;
using RobotArena.Models.Items;
using RobotArena.Services.ArmorServices;
using RobotArena.Services.ContextServices;
using RobotArena.Services.CreepServices;
using RobotArena.Services.RobotServices;
using RobotArena.Services.UserSerices;
using RobotArena.Services.WeaponServices;
using RobotArena.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace RobotArena.Tests.Repair
{
   [TestClass]
    public class RepairCenterTests
    {
        private RobotContext dbContext;
        private RobotDataService service;
        private ArmorDataService armorService;
        private WeaponDataService weaponService;
        private CreepDataService creepService;
        private DbContextService dbContextService;
        private UserDataService userService;
        [TestMethod]
        public async void RepairCenter_ShouldRepairArmor()
        {
            var users = new[]
                {

                new User() { Id = "222" },
                new User() { Id = "333" },
                new User() { Id = "444" }
            };      



            //setup your expectations here 

            var mockUserStore = new Mock<IUserStore<User>>();
            var mockUserManager = new Mock<UserManager<User>>(
                mockUserStore.Object, null, null, null, null, null, null, null, null);
            mockUserManager.Setup(um => um.GetUserAsync(null))
                    .ReturnsAsync(users[1]);
            this.dbContext = MockDbContext.GetContext();
            this.service = new RobotDataService(dbContext, MockAutoMapper.GetAutoMapper(), mockUserManager.Object);
            this.armorService = new ArmorDataService(dbContext, this.service, MockAutoMapper.GetAutoMapper(), mockUserManager.Object);
            this.weaponService = new WeaponDataService(dbContext, this.service, MockAutoMapper.GetAutoMapper(), mockUserManager.Object);
            this.creepService = new CreepDataService(dbContext, this.service, MockAutoMapper.GetAutoMapper());
            this.dbContextService = new DbContextService(dbContext, this.service, MockAutoMapper.GetAutoMapper(), mockUserManager.Object);
            this.userService = new UserDataService(dbContext,MockAutoMapper.GetAutoMapper(), mockUserManager.Object);

            var controller = new RepairCenterController(mockUserManager.Object,MockAutoMapper.GetAutoMapper(),dbContextService,this.service,armorService,weaponService,userService);
            controller.ControllerContext = new ControllerContext()
            {
                HttpContext = new DefaultHttpContext()
                {
                    User = new ClaimsPrincipal(new ClaimsIdentity(new[]
                       {
                          new Claim(ClaimTypes.Role, "Admin")
                      }))
                }
            };
            var tempData = new TempDataDictionary(controller.HttpContext, Mock.Of<ITempDataProvider>());
            controller.TempData = tempData;

            var newwwwUser = new User() { Id = "1", Coins = 251 };
            var armor = new ArmorDetailsViewModel()
            {
                Id = 1,
                Name = "mechoo",
                ArmorPoints = 101,
                CurrentArmor = 50,
                Durability = 50,
                ImageUrl = "kk",
                Price = 120,

            };

            dbContext.Users.Add(newwwwUser);
            var actualArmor = new Armor()
            {
                Id = 1,
                Name = "mechoo",
                ArmorPoints = 101,
                Durability = 50,
                ImageUrl = "kk",
                Price = 120,
                UserId = "1",
                User = newwwwUser
            };
            this.dbContext.Armors.Add(actualArmor);
            this.dbContext.SaveChanges();
           await controller.Repair(1, "ArmorRepairViewModel");
            Assert.AreEqual(1, newwwwUser.Coins);
        }
    }
}
