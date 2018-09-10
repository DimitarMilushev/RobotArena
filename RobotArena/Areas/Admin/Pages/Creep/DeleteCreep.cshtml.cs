using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RobotArena.Data;
using RobotArena.Models.NPC;

namespace RobotArena.Areas.Admin.Pages
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DeleteCreepModel : PageModel
    {
        private readonly RobotArena.Data.RobotContext _context;

        public DeleteCreepModel(RobotArena.Data.RobotContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Creep Creep { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Creep = await _context.Creeps.FirstOrDefaultAsync(m => m.Id == id);

            if (Creep == null)
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

            Creep = await _context.Creeps.FindAsync(id);

            if (Creep != null)
            {
                _context.Creeps.Remove(Creep);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./AllCreeps");
        }
    }
}
