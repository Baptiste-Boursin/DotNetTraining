using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChatonBDD.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        
        [Display(Name = "LIbellé")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Libelle { get; set; }
        
        [Display(Name = "Petite Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        public virtual ICollection<Chaton> Chatons { get; set; }
    }
}