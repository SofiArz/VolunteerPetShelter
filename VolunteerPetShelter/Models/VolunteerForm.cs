using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VolunteerPetShelter.Models
{
    public class VolunteerForm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VolunteerFormID { get; set; }
        public bool Question1 { get; set; } //Car question
        public ListOptions Question2 { get; set; } //Interest question. Foreing Key
        public virtual ICollection<Person> Persons { get; set; }

        public enum ListOptions
        {
            [Display(Name = "1- Tratamientos y cuidado de animales.")] TCA,
            [Display(Name = "2- Medicación, alimentación y limpieza diaria")] MAL,
            [Display(Name = "3- Limpieza y mantenimiento del lugar")] LML,
            [Display(Name = "4- Campañas de castración, adopción, concientización")] CAC,
            [Display(Name = "5- Otras actividades relacionadas a profesionales")] OTR,

        }

    }
}






