using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotArena.Areas.Admin.Pages;
using RobotArena.Controllers;
using System.Linq;

namespace RobotArena.Tests
{
    [TestClass]
    public class AuthorizationControllersTests
    {
        
        [TestMethod]
        public void TestIfBattleControllerHasAuthorization()
        {
            var authAttribute = typeof(BattleController)
         .GetCustomAttributes(true)
         .FirstOrDefault(attr => attr is AuthorizeAttribute) as AuthorizeAttribute;

            Assert.IsNotNull(authAttribute);

        }
        [TestMethod]
        public void TestIfRepairCenterControllerHasAuthorization()
        {
            var authAttribute = typeof(RepairCenterController)
         .GetCustomAttributes(true)
         .FirstOrDefault(attr => attr is AuthorizeAttribute) as AuthorizeAttribute;

            Assert.IsNotNull(authAttribute);

        }
        [TestMethod]
        public void TestIfRobotControllerHasAuthorization()
        {
            var authAttribute = typeof(RobotController)
         .GetCustomAttributes(true)
         .FirstOrDefault(attr => attr is AuthorizeAttribute) as AuthorizeAttribute;

            Assert.IsNotNull(authAttribute);

        }
        [TestMethod]
        public void TestIfStoreControllerHasAuthorization()
        {
            var authAttribute = typeof(StoreController)
         .GetCustomAttributes(true)
         .FirstOrDefault(attr => attr is AuthorizeAttribute) as AuthorizeAttribute;

            Assert.IsNotNull(authAttribute);

        }
        [TestMethod]
        public void TestIfUsersControllerHasAuthorization()
        {
            var authAttribute = typeof(UsersController)
         .GetCustomAttributes(true)
         .FirstOrDefault(attr => attr is AuthorizeAttribute) as AuthorizeAttribute;

            Assert.IsNotNull(authAttribute);

        }
    }
}
