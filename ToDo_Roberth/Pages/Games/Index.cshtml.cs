using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ToDo_Roberth.Models;

namespace ToDo_Roberth.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly ToDo_Roberth.Models.AppDbContext _context;

        public IndexModel(ToDo_Roberth.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
