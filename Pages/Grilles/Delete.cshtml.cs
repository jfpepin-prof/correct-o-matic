using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeCorrecteur.Data;
using LeCorrecteur.Models;

namespace LeCorrecteur.Pages.Grilles
{
    public class DeleteModel : PageModel
    {
        private readonly LeCorrecteurContext _context;

        public DeleteModel(LeCorrecteurContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Grille Grille { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Grille = await _context.Grille.FirstOrDefaultAsync(m => m.ID == id);

            if (Grille == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Grille = await _context.Grille.FindAsync(id);

            if (Grille != null)
            {
                _context.Grille.Remove(Grille);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
