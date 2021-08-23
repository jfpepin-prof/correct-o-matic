using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LeCorrecteur.Data;
using LeCorrecteur.Models;

namespace LeCorrecteur.Pages.Grilles
{
    public class CreateModel : PageModel
    {
        private readonly LeCorrecteurContext _context;

        public CreateModel(LeCorrecteurContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Grille Grille { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Grille.Add(Grille);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
