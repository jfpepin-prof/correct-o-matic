using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LeCorrecteur.Models
{
    public class Grille
    {
        public int ID { get; set; }
        [Required]
        public string Titre { get; set; }
        public string Cours {  get; set; }
        public ICollection<Competence> Competences { get; set; }
        public DateTime DateCreation { get; set; }
        public int TotalPoints
        {
            get
            {
                int totalPoints = 0;
                if (Competences != null)
                {
                    foreach (var competence in Competences)
                    {
                        totalPoints += competence.Ponderation;
                    }
                }
                return totalPoints;
            }
        }

        public Grille()
        {
            DateCreation = DateTime.Now;
        }
        
        

    }
}
