using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeCorrecteur.Models
{
    public class Competence
    {
        public int ID { get; set; }
        
        [Required]
        public int GrilleID { get; set; }

        [Required]
        [Display(Name = "Compétence")]
        public string Nom { get; set; }

        public string Description { get; set; }

        [Required]
        [Display(Name = "Pondération")]
        public int Ponderation { get; set; }

    }
}
