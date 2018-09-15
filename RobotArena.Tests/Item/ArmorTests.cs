using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RobotArena.Common.Models.Armor;
using RobotArena.Controllers;
using RobotArena.Data;
using RobotArena.Models;
using RobotArena.Models.Items;
using RobotArena.Services.ArmorServices;
using RobotArena.Services.ContextServices;
using RobotArena.Services.RobotServices;
using RobotArena.Services.RobotServices.Interfaces;
using RobotArena.Services.WeaponServices;
using RobotArena.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace RobotArena.Tests.Item
{  [TestClass]
    public class ArmorTests
    {
        private RobotContext dbContext;       
        private ArmorDataService armorService;
        private WeaponDataService weaponService;
        private readonly RobotDataService service;
        private DbContextService dbContextService;

        [TestMethod]
      public async void SellArmor_ShouldIncreaseUserCoins()
        {
            var users = new[]
              {

                new User() { Id = "222" },
                new User() { Id = "333" },
                new User() { Id = "444" }
            };
            this.dbContext = MockDbContext.GetContext(); 

           

            var mockUserStore = new Mock<IUserStore<User>>();
            var mockUserManager = new Mock<UserManager<User>>(
                mockUserStore.Object, null, null, null, null, null, null, null, null);
            mockUserManager.Setup(um => um.GetUserAsync(null))
                    .ReturnsAsync(users[1]);
            this.armorService = new ArmorDataService(dbContext, this.service, MockAutoMapper.GetAutoMapper(), mockUserManager.Object);
            this.weaponService = new WeaponDataService(dbContext, this.service, MockAutoMapper.GetAutoMapper(), mockUserManager.Object);
            this.dbContextService = new DbContextService(dbContext, this.service, MockAutoMapper.GetAutoMapper(), mockUserManager.Object);

            var controller = new StoreController(mockUserManager.Object,this.weaponService,this.armorService, this.dbContextService, MockAutoMapper.GetAutoMapper());
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


            var newwwwUser = new User() { Id = "1", Coins = 0 };
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
            await controller.SellArmorPost(1);
            Assert.AreEqual(60, newwwwUser.Coins);

        }


    }
}
