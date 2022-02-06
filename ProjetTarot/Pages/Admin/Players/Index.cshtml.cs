using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetTarot.Data;
using ProjetTarot.Models;

namespace ProjetTarot.Pages.Admin.Players
{
    public class IndexModel : PageModel
    {
        private readonly ProjetTarot.Data.DataContext _context;

        public IndexModel(ProjetTarot.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Player> Player { get;set; }

        public async Task OnGetAsync()
        {
            Player = await _context.Players.ToListAsync();
        }
    }
}
