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
using RobotArena.Models.NPC;
using RobotArena.Services.RobotServices;
using RobotArena.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace RobotArena.Tests.Fight
{

    [TestClass]
    public class FightTest
    {
        private RobotContext dbContext;
        private RobotDataService service;
        private UserManager<User> manager;
        [TestMethod]
        public void Fight_ShouldDecreaseRobotPoints()
        {
            var users = new[]
{
                new User() { Id = "111" },
                new User() { Id = "222" },
                new User() { Id = "333" },
                new User() { Id = "444" }
            };

            var mockUserStore = new Mock<IUserStore<User>>();
            var mockUserManager = new Mock<UserManager<User>>(
                mockUserStore.Object, null, null, null, null, null, null, null, null);
            mockUserManager.Setup(um => um.GetUserAsync(null))
                    .ReturnsAsync(users[1]);


            this.dbContext = MockDbContext.GetContext();
            this.service = new RobotDataService(dbContext, MockAutoMapper.GetAutoMapper(), mockUserManager.Object);





            var robot = new Models.Robots.Robot()
            {
                Id = 1,
                BaseHealth = 1000,
                CurrentHealth = 1000,
                BaseDamage = 100,
                Type = "Fire",
                ImageUrl = "https://i.ytimg.com/vi/Rrb4jW_uJxE/hqdefault.jpg"

            };
            var creep = new Creep()
            {
                Id = 1,
                Name = "aaaa",
                Type = "Fire",
                Health = 1000,
                Damage = 100,
                Bounty = 10,
                ImageUrl = "1"
            };

            var controller = new BattleController(mockUserManager.Object, this.dbContext, MockAutoMapper.GetAutoMapper(), this.service);
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
            this.dbContext.Robots.Add(robot);
            this.dbContext.Creeps.Add(creep);
            this.dbContext.SaveChanges();
            controller.Fight(robot.Id, creep.Id);
            Assert.AreEqual(0, robot.CurrentHealth);
        }
      
        
    }
}
