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
    public class DeleteArmorModel : PageModel
    {
        private readonly RobotArena.Data.RobotContext _context;

        public DeleteArmorModel(RobotContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Armor Armor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Armor = await _context.Armors
                .Include(a => a.Robot).FirstOrDefaultAsync(m => m.Id == id);

            if (Armor == null)
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

            Armor = await _context.Armors.FindAsync(id);

            if (Armor != null)
            {
                _context.Armors.Remove(Armor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./AllArmors");
        }
    }
}
