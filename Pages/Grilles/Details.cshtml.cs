using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeCorrecteur.Data;
using LeCorrecteur.Models;

namespace LeCorrecteur.Pages.Grilles
{
    public class DetailsModel : PageModel
    {
        private readonly LeCorrecteurContext _context;

        public DetailsModel(LeCorrecteurContext context)
        {
            _context = context;
        }

        public Grille Grille { get; set; }

        public async Task<IActionResult> OnGetAsync(int ?id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Grille = await _context.Grille
                .Include(s => s.Competences)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Grille == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
