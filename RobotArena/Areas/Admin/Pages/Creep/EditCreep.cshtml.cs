using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RobotArena.Data;
using RobotArena.Models.NPC;

namespace RobotArena.Areas.Admin.Pages
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class EditCreepModel : PageModel
    {
        private readonly RobotArena.Data.RobotContext _context;

        public EditCreepModel(RobotArena.Data.RobotContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Creep Creep { get; set; }
        public List<SelectListItem> Types { get; set; }
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
            Types = new List<SelectListItem> {
        new SelectListItem { Value = "Fire", Text = "Fire" },
        new SelectListItem { Value = "Nature", Text = "Nature" },
        new SelectListItem { Value = "Water", Text = "Water" }
    };
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Types = new List<SelectListItem> {
        new SelectListItem { Value = "Fire", Text = "Fire" },
        new SelectListItem { Value = "Nature", Text = "Nature" },
        new SelectListItem { Value = "Water", Text = "Water" }
    };
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Creep).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CreepExists(Creep.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./AllCreeps");
        }

        private bool CreepExists(int id)
        {
            return _context.Creeps.Any(e => e.Id == id);
        }
    }
}
