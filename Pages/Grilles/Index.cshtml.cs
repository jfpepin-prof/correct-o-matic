using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeCorrecteur.Data;
using LeCorrecteur.Models;

namespace LeCorrecteur.Pages.Grilles
{
    public class IndexModel : PageModel
    {
        private readonly LeCorrecteurContext _context;

        public IndexModel(LeCorrecteurContext context)
        {
            _context = context;
        }

        public IList<Grille> Grille { get;set; }

        public async Task OnGetAsync()
        {
            Grille = await _context.Grille.ToListAsync();
        }
    }
}
