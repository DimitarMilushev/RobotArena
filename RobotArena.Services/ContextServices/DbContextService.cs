using AutoMapper;
using Microsoft.AspNetCore.Identity;
using RobotArena.Data;
using RobotArena.Models;
using RobotArena.Services.ContextServices.Interfaces;
using RobotArena.Services.RobotServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotArena.Services.ContextServices
{
    public class DbContextService:BaseEFService,IDbContextService
    {

        private readonly UserManager<User> userManager;
        private readonly IRobotDataService robotDataService;
        public DbContextService(RobotContext dbContext, IRobotDataService robotDataService, IMapper mapper, UserManager<User> userManager)
            : base(dbContext, mapper)
        {
            this.userManager = userManager;
            this.robotDataService = robotDataService;
        }
        public void SaveChanges()
        {
            //var robot = context.Robots.FirstOrDefault(r => r.Id == RobotId);
             this.DbContext.SaveChanges();

        }
    }
}
