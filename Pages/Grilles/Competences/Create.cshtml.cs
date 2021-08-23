using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LeCorrecteur.Data;
using LeCorrecteur.Models;

namespace LeCorrecteur.Pages.Grilles.Competences
{
    public class Create : PageModel
    {
        private readonly LeCorrecteurContext _context;

        public Create(LeCorrecteurContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Competence Competence { get; set; }

        public IActionResult OnGet()
        {
    
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Competence.GrilleID = id;
            _context.Competence.Add(Competence);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Grilles/Details", new { id = id });
        }
    }
}
