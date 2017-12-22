namespace VolunteerPetShelter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        MailAsId = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MailAsId);
            
            DropColumn("dbo.People", "Mail");
            DropColumn("dbo.People", "Password");
            DropColumn("dbo.People", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.People", "Password", c => c.String());
            AddColumn("dbo.People", "Mail", c => c.String());
            DropTable("dbo.Users");
        }
    }
}
