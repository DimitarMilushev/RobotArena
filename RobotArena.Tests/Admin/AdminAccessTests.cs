using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotArena.Areas.Admin.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotArena.Tests.Admin
{

    [TestClass]
    public class AdminAccessTests
    {
        [TestMethod]
        public void CreateArmorModel_ShouldBeInAdminArea()
        {
            var area = typeof(CreateArmorModel)
                .GetCustomAttributes(true)
                .FirstOrDefault(attr => attr is AreaAttribute) as AreaAttribute;

            Assert.IsNotNull(area);
            Assert.AreEqual("Admin", area.RouteValue);
        }
    }
}
