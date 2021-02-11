using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChatonBDD.Models
{
    public class Chaton
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Nom { get; set; }
        
        //int? c'est un Nullable
        [Display(Name ="Année de Naissance")]
        [Range(2000,2031)]
        public int? AnneeDeNaissance { get; set; }
        
        public virtual Categorie Categorie { get; set; }


    }
}