using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotArena.Controllers;
using RobotArena.Data;
using RobotArena.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RobotArena.Tests.Home
{[TestClass]
    public class IndexTest
    {
        private RobotContext dbContext;
        
        [TestMethod]
        public void Index_ShouldReturnView()
        {
           
            var controller = new HomeController();
            // Act
            var result =  controller.Index();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}
