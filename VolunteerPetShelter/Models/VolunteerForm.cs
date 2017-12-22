using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VolunteerPetShelter.Models
{
    

    public class VolunteerForm : Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Solicitud N°")]
        public int VolunteerFormID { get; set; }

        [Display(Name = "Vehiculo propio")]
        public bool  Question1 { get; set; } //Car question

        [Display(Name = "Area de interés")]
        public VolunteerWorks Question2 { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
        
    }
}






