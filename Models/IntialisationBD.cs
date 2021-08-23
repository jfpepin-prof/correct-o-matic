using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LeCorrecteur.Data;
using System;
using System.Linq;

namespace LeCorrecteur.Models
{
    public class IntialisationBD
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LeCorrecteurContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LeCorrecteurContext>>()))
            {

                if (context.Grille.Any())
                {
                    return;   // Le seed a déjà été effectué
                }

                context.Grille.AddRange(
                    new Grille
                    {
                        Titre = "TP1 - Interface web statique",
                        Cours = "420-515FX-Évo"
                    },
                    new Grille
                    {
                        Titre = "TP2 - Framework MVC",
                        Cours = "420-515FX-Évo"
                    },
                    new Grille
                    {
                        Titre = "TP3 - Site responsive",
                        Cours = "420-515FX-Web"
                    }
                );
                context.SaveChanges();

                context.Competence.AddRange(
                    new Competence
                    {
                        GrilleID = 1,
                        Nom = "Composantes dynamiques (jQuery)",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut maximus dui, in porta est. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae;",
                        Ponderation = 25
                    },
                    new Competence
                    {
                        GrilleID = 1,
                        Nom = "Sémantique web (référencement)",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut maximus dui, in porta est. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae;",
                        Ponderation = 20
                    },
                    new Competence 
                    {
                        GrilleID = 1,
                        Nom = "Accessibilité web",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut maximus dui, in porta est. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae;",
                        Ponderation = 25
                    },
                    new Competence
                    {
                        GrilleID = 1,
                        Nom = "Qualité de l’intégration",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut maximus dui, in porta est. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae;",
                        Ponderation = 10
                    },
                    new Competence
                    {
                        GrilleID = 1,
                        Nom = "Gestion de projet",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ut maximus dui, in porta est. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae;",
                        Ponderation = 20
                    }


                );
                context.SaveChanges();

            }
        }
    }
}
