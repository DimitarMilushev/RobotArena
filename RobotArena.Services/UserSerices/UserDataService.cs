using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RobotArena.Data;
using RobotArena.Models;

namespace RobotArena.Services.UserSerices
{
    public class UserDataService : BaseEFService, IUserDataService
    {
        private readonly UserManager<User> userManager;
        public UserDataService(RobotContext dbContext, IMapper mapper, UserManager<User> userManager)
            : base(dbContext, mapper)
        {
            this.userManager = userManager;
        }


        public async Task<User> GetCurrentUserWithRobotsAsync(User user)
        {
          
           
            var currentUser = await DbContext.Users.Include(u => u.Robots).FirstOrDefaultAsync(u => u.Id == user.Id);
            return currentUser;

         
        }
        public async Task<User> GetCurrentUserWithItemsAsync(User user)
        {


            var currentUserWithItems = await DbContext.Users.Include(u => u.Weapons).Include(u => u.Armors).FirstOrDefaultAsync(u => u.Id == user.Id);
            return currentUserWithItems;

           
        }
        public async Task<User> GetCurrentUserWithItemsAndRobotsAsync(User user)
        {


            var currentUserWithItems = await DbContext.Users.Include(u=>u.Robots).Include(u => u.Weapons).Include(u => u.Armors).FirstOrDefaultAsync(u => u.Id == user.Id);
            return currentUserWithItems;


        }
    }
}
