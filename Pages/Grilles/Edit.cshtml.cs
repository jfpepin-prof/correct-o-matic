using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeCorrecteur.Data;
using LeCorrecteur.Models;

namespace LeCorrecteur.Pages.Grilles
{
    public class EditModel : PageModel
    {
        private readonly LeCorrecteurContext _context;

        public EditModel(LeCorrecteurContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Grille).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GrilleExists(Grille.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("/Grilles/Details", Grille.ID);
        }

        private bool GrilleExists(int id)
        {
            return _context.Grille.Any(e => e.ID == id);
        }
    }
}
