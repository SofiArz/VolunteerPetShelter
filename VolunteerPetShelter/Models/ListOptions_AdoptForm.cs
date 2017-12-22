using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VolunteerPetShelter.Models
{
    public enum Veterinarian
    {
        [Display(Name = "Una vez cada 3 años")] TresAños,
        [Display(Name = "Solo cuando se enferme")] PorEnfermedad,
        [Display(Name = "Dos veces al año")] DosVecesXAño,
        [Display(Name = "Anualmente")] Anualmente,

    }
    public enum Answer { Si, No }

    public enum Gender
    {
        [Display(Name = "Macho")] Male,
        [Display(Name = "Hembra")] Female,
        [Display(Name = "Sin preferencia")] DaIgual,
    }

    public enum Age
    {
        [Display(Name = "Cachorro")] Cachorro,
        [Display(Name = "Joven adulto")] JovenAdulto,
        [Display(Name = "Adulto")] Adulto,
        [Display(Name = "Mayor")] Mayor,
        [Display(Name = "Sin preferencia")] DaIgual,

    }
    public enum Coat
    {
        [Display(Name = "Corto")] Corto,
        [Display(Name = "Mediano")] Mediano,
        [Display(Name = "Largo")] Largo,
        [Display(Name = "Sin preferencia")] DaIgual,

    }

    public enum LivingEnvironment
    {
        [Display(Name = "Casa con patio")] Casa,
        [Display(Name = "Casa sin patio")] CasaPequeña,
        [Display(Name = "Departamento")] Departamento,       
    }

}