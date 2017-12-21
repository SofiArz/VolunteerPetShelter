using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VolunteerPetShelter.Models
{
    public enum VolunteerWorks
    {
        [Display(Name = "1- Tratamientos y cuidado de animales.")] Tratamientos,
        [Display(Name = "2- Medicación, alimentación y limpieza diaria")] Medicacion,
        [Display(Name = "3- Limpieza y mantenimiento del lugar")] Limpieza,
        [Display(Name = "4- Campañas de castración, adopción, concientización")] Campañas,
        [Display(Name = "5- Otras actividades relacionadas a profesionales")] Otros,

    }
}