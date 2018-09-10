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
    [Authorize(Roles = "Admin")]
    public class CreateWeaponModel : PageModel
    {
        private readonly RobotArena.Data.RobotContext _context;

        public CreateWeaponModel(RobotContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["RobotId"] = new SelectList(_context.Robots, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Weapon Weapon { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Weapons.Add(Weapon);
            await _context.SaveChangesAsync();

            return RedirectToPage("./AllWeapons");
        }
    }
}