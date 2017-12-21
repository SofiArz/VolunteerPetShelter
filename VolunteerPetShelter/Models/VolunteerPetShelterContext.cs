using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VolunteerPetShelter.Models
{
    public class VolunteerPetShelterContext : DbContext
    {
     
        public VolunteerPetShelterContext() : base("VolunteerPetShelterContext")  {   }

       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Person>() 
                .HasMany<VolunteerForm>(u => u.VolunteerForms) 
                .WithMany(p => p.Persons)
                .Map(us =>
                {
                    us.MapLeftKey("PersonID");
                    us.MapRightKey("FormID");
                    us.ToTable(tableName: "VolunteerFormsXPerson");
                });
        }

        /// <summary>
        /// Colección para poder administrar Persons en la base de datos
        /// </summary>
        public DbSet<Person> Persons { get; set; }
        /// <summary>
        /// Colección para poder administrar VolunteerForms en la base de datos
        /// </summary>
        public DbSet<VolunteerForm> VolunteerForms { get; set; }

      

    }
}