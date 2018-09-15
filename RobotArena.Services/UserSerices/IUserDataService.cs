using RobotArena.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RobotArena.Services.UserSerices
{
    public interface IUserDataService
    {//TODO make a folder interfaces for this interface
        Task<User> GetCurrentUserWithRobotsAsync(User user);
        Task<User> GetCurrentUserWithItemsAsync(User user);
        Task<User> GetCurrentUserWithItemsAndRobotsAsync(User user);
    }
}
