using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RobotArena.Data;
using RobotArena.Models.Items;

namespace RobotArena.Areas.Admin.Pages
{[Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AllArmorsModel : PageModel
    {
        private readonly RobotArena.Data.RobotContext _context;

        public AllArmorsModel(RobotArena.Data.RobotContext context)
        {
            _context = context;
        }

        public IList<Armor> Armor { get;set; }

        public async Task OnGetAsync()
        {
            Armor = await _context.Armors
                .Include(a => a.Robot)
                .Include(a => a.User).ToListAsync();
        }
    }
}
