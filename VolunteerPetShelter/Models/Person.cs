using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VolunteerPetShelter.Models
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ID { get; set; } //Entity Framework interprets a property that's named ID or classname ID as the primary key.
        public string Name { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

        public int LocationID { get; set; } //foreing key to the Location entity. A Person entity is associated with one Location entity.
        public virtual Location Location { get; set; }//navigation property name

        public string Address { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set;}

        //public virtual ICollection<AdoptionForm> AdoptionForm { get; set; }
        public virtual ICollection<VolunteerForm> VolunteerForms { get; set; }
        //public virtual ICollection<FosterForm> FosterForm { get; set; }

    }

}