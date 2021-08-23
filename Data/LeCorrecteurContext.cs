using Microsoft.EntityFrameworkCore;
using LeCorrecteur.Models;

namespace LeCorrecteur.Data
{
    public class LeCorrecteurContext : DbContext
    {
        public LeCorrecteurContext (DbContextOptions<LeCorrecteurContext> options)
            : base(options)
        {
        }

        public DbSet<Grille> Grille { get; set; }
        public DbSet<Competence> Competence { get; set; }

    }
}
