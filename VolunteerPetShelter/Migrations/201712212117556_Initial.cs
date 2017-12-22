namespace VolunteerPetShelter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(),
                        LastName = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        Location = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                        VolunteerFormID = c.Int(identity: true),
                        Question1 = c.Boolean(),
                        Question2 = c.Int(),
                        Mail = c.String(),
                        Password = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VolunteerFormsXPerson",
                c => new
                    {
                        PersonID = c.Int(nullable: false),
                        FormID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PersonID, t.FormID })
                .ForeignKey("dbo.People", t => t.PersonID)
                .ForeignKey("dbo.People", t => t.FormID)
                .Index(t => t.PersonID)
                .Index(t => t.FormID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VolunteerFormsXPerson", "FormID", "dbo.People");
            DropForeignKey("dbo.VolunteerFormsXPerson", "PersonID", "dbo.People");
            DropIndex("dbo.VolunteerFormsXPerson", new[] { "FormID" });
            DropIndex("dbo.VolunteerFormsXPerson", new[] { "PersonID" });
            DropTable("dbo.VolunteerFormsXPerson");
            DropTable("dbo.People");
        }
    }
}
