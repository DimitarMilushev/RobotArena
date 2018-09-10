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
    public class DeleteWeaponModel : PageModel
    {
        
        private readonly RobotArena.Data.RobotContext _context;

        public DeleteWeaponModel(RobotContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Weapon = await _context.Weapons.FindAsync(id);

            if (Weapon != null)
            {
                _context.Weapons.Remove(Weapon);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./AllWeapons");
        }
    }
}
