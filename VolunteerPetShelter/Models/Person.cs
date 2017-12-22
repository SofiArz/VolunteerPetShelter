using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VolunteerPetShelter.Models
{
    public abstract class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
     
        [Display(Name = "DNI")]
        public int ID { get; set; } //Entity Framework interprets a property that's named ID or classname ID as the primary key.

        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

        [Display(Name = "Localidad")]
        public string Location { get; set; }

        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [Display(Name = "Mail")]
        public string Email { get; set; }

        [Display(Name = "Telefono")]
        public string Telephone { get; set;}

        //public virtual ICollection<AdoptionForm> AdoptionForm { get; set; }
        public virtual ICollection<VolunteerForm> VolunteerForms { get; set; }
        //public virtual ICollection<FosterForm> FosterForm { get; set; }

    }

}