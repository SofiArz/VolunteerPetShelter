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
        public int VolunteerFormID { get; set; }
        public bool  Question1 { get; set; } //Car question
        public VolunteerWorks Question2 { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
        
    }
}






