using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RobotArena.Data;
using RobotArena.Models.NPC;

namespace RobotArena.Areas.Admin.Pages
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CreateCreepModel : PageModel
    {
        private readonly RobotArena.Data.RobotContext _context;

        public CreateCreepModel(RobotArena.Data.RobotContext context)
        {
            _context = context;
        }
        public List<SelectListItem> Types { get; set; }
        public IActionResult OnGet()
        {
            Types = new List<SelectListItem> {
        new SelectListItem { Value = "Fire", Text = "Fire" },
        new SelectListItem { Value = "Nature", Text = "Nature" },
        new SelectListItem { Value = "Water", Text = "Water" }        
    };
            return Page();
        }

        [BindProperty]
        public Creep Creep { get; set; }

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

            _context.Creeps.Add(Creep);
            await _context.SaveChangesAsync();

            return RedirectToPage("./AllCreeps");
        }
    }
}