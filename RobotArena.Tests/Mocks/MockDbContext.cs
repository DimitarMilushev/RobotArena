using Microsoft.EntityFrameworkCore;
using RobotArena.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotArena.Tests.Mocks
{
   public static class MockDbContext
    {
        public static RobotContext GetContext()
        {
            var options = new DbContextOptionsBuilder<RobotContext>()
               .UseInMemoryDatabase(Guid.NewGuid().ToString())
               .Options;

            return new RobotContext(options);
        }
    }
}
