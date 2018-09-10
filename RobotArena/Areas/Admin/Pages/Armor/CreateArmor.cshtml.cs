using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RobotArena.Data;
using RobotArena.Models.Items;

namespace RobotArena.Areas.Admin.Pages
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class CreateArmorModel : PageModel
    {
        private readonly RobotArena.Data.RobotContext _context;

        public CreateArmorModel(RobotContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["RobotId"] = new SelectList(_context.Robots, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Armor Armor { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Armors.Add(Armor);
            await _context.SaveChangesAsync();
            //TODO ./AllArmors
            return RedirectToPage("./AllArmors");
        }
    }
}