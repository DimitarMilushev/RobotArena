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
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AllWeaponsModel : PageModel
    {
        private readonly RobotArena.Data.RobotContext _context;

        public AllWeaponsModel(RobotArena.Data.RobotContext context)
        {
            _context = context;
        }

        public IList<Weapon> Weapon { get;set; }

        public async Task OnGetAsync()
        {
            Weapon = await _context.Weapons
                .Include(w => w.Robot).ToListAsync();
        }
    }
}
