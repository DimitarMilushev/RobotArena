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
    public class AllCreepsModel : PageModel
    {
        private readonly RobotArena.Data.RobotContext _context;

        public AllCreepsModel(RobotArena.Data.RobotContext context)
        {
            _context = context;
        }

        public IList<Creep> Creep { get;set; }

        public async Task OnGetAsync()
        {
            Creep = await _context.Creeps.ToListAsync();
        }
    }
}
