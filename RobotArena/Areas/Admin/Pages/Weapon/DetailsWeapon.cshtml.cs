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
    public class DetailsWeaponModel : PageModel
    {
        private readonly RobotArena.Data.RobotContext _context;

        public DetailsWeaponModel(RobotContext context)
        {
            _context = context;
        }

        public Weapon Weapon { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Weapon = await _context.Weapons
                .Include(w => w.Robot).FirstOrDefaultAsync(m => m.Id == id);

            if (Weapon == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
