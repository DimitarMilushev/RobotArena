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
    public class DetailsCreepModel : PageModel
    {
        private readonly RobotArena.Data.RobotContext _context;

        public DetailsCreepModel(RobotArena.Data.RobotContext context)
        {
            _context = context;
        }

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
    }
}
