using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RobotArena.Common.Models.Robot;
using RobotArena.Controllers;
using RobotArena.Data;
using RobotArena.Models;
using RobotArena.Services.ArmorServices;
using RobotArena.Services.RobotServices;
using RobotArena.Services.WeaponServices;
using RobotArena.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RobotArena.Tests.Robot
{
    [TestClass]
    public class RobotTests
    {
        private RobotContext dbContext;
        private RobotDataService service;
        private ArmorDataService armorService;
        private WeaponDataService weaponService;
        private UserManager<User> manager;
     
       
        [TestMethod]
        public void EditingRobot_ShouldEditRobotName()
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
            this.armorService = new ArmorDataService(dbContext, this.service,MockAutoMapper.GetAutoMapper(), mockUserManager.Object);
            this.weaponService = new WeaponDataService(dbContext,this.service, MockAutoMapper.GetAutoMapper(), mockUserManager.Object);

            var controller = new RobotController(mockUserManager.Object, MockAutoMapper.GetAutoMapper(), this.service,this.weaponService,this.armorService);
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
        var user2 = controller.ControllerContext.HttpContext.User;


            var robot = new Models.Robots.Robot()
            {
                Id = 1,
             BaseHealth = 1000,
            CurrentHealth = 1000,
            BaseDamage = 100,
            Type = "Fire",
            ImageUrl = "https://i.ytimg.com/vi/Rrb4jW_uJxE/hqdefault.jpg"

        };
            this.dbContext.Robots.Add(robot);
            this.dbContext.SaveChanges();
            var updateNameBindingModel = new UpdateNameBindingModel()
            {
                Name = "Edited"

            };
        var result = controller.Edit(robot.Id, updateNameBindingModel);
       
        //service.CreateRobotAsync(user2, robot);
        Assert.AreEqual("Edited",dbContext.Robots.First().Name);
           
        }
        [TestMethod]
        public void DeletingRobot_ShouldRemoveRobotFromDatabase()
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

            this.armorService = new ArmorDataService(dbContext, this.service, MockAutoMapper.GetAutoMapper(), mockUserManager.Object);
            this.weaponService = new WeaponDataService(dbContext, this.service, MockAutoMapper.GetAutoMapper(), mockUserManager.Object);

            var controller = new RobotController(mockUserManager.Object, MockAutoMapper.GetAutoMapper(), this.service, this.weaponService, this.armorService);
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
            var user2 = controller.ControllerContext.HttpContext.User;


            var robot = new Models.Robots.Robot()
            {
                Id = 1,
                BaseHealth = 1000,
                CurrentHealth = 1000,
                BaseDamage = 100,
                Type = "Fire",
                ImageUrl = "https://i.ytimg.com/vi/Rrb4jW_uJxE/hqdefault.jpg"

            };
            this.dbContext.Robots.Add(robot);
            this.dbContext.SaveChanges();
            
            var result =controller.DeletePost(robot.Id);
            this.dbContext.SaveChanges();
            //service.CreateRobotAsync(user2, robot);
            Assert.AreEqual(0, dbContext.Robots.Count());

        }
        [TestMethod]
        public void EquipArmor_ShouldAddArmorToRobot()
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

            this.armorService = new ArmorDataService(dbContext, this.service, MockAutoMapper.GetAutoMapper(), mockUserManager.Object);
            this.weaponService = new WeaponDataService(dbContext, this.service, MockAutoMapper.GetAutoMapper(), mockUserManager.Object);

            var controller = new RobotController(mockUserManager.Object, MockAutoMapper.GetAutoMapper(), this.service, this.weaponService, this.armorService);
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
            var user2 = controller.ControllerContext.HttpContext.User;


            var robot = new Models.Robots.Robot()
            {
                Id = 1,
                BaseHealth = 1000,
                CurrentHealth = 1000,
                BaseDamage = 100,
                Type = "Fire",
                ImageUrl = "https://i.ytimg.com/vi/Rrb4jW_uJxE/hqdefault.jpg"

            };
            var armor = new Models.Items.Armor()
            {
                Name="mechoo",
                ArmorPoints=101,
                DurabilityLossAmount=15,
                ImageUrl="kk",
                Price=101
            };
            dbContext.Robots.Add(robot);
            dbContext.Armors.Add(armor);
            this.dbContext.SaveChanges();
            var result = controller.EquipArmor(robot.Id, armor.Id);
            this.dbContext.SaveChanges();
            Assert.AreEqual(1, robot.Armors.Count());
        }
        [TestMethod]
        public void UnequipArmor_ShouldRemoveArmorFromRobot()
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

            this.armorService = new ArmorDataService(dbContext, this.service, MockAutoMapper.GetAutoMapper(), mockUserManager.Object);
            this.weaponService = new WeaponDataService(dbContext, this.service, MockAutoMapper.GetAutoMapper(), mockUserManager.Object);

            var controller = new RobotController(mockUserManager.Object, MockAutoMapper.GetAutoMapper(), this.service, this.weaponService, this.armorService);
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
            var user2 = controller.ControllerContext.HttpContext.User;


            var robot = new Models.Robots.Robot()
            {
                Id = 1,
                BaseHealth = 1000,
                CurrentHealth = 1000,
                BaseDamage = 100,
                Type = "Fire",
                ImageUrl = "https://i.ytimg.com/vi/Rrb4jW_uJxE/hqdefault.jpg"

            };
            var armor = new Models.Items.Armor()
            {
                Name = "mechoo",
                ArmorPoints = 101,
                DurabilityLossAmount = 15,
                ImageUrl = "kk",
                Price = 101
            };
            dbContext.Robots.Add(robot);
            dbContext.Armors.Add(armor);
            robot.Armors.Add(armor);
            this.dbContext.SaveChanges();
            var result = controller.UnequipArmor(robot.Id, armor.Id);
            this.dbContext.SaveChanges();
            Assert.AreEqual(0, robot.Armors.Count());
          
        }
       
    }
}
