using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VolunteerPetShelter.Models
{
    public class User 
    {
        [Key]
        [Required]
        public string MailAsId { get; set; }
        [Required]
        public string Password { get; set; }
       
    }
}