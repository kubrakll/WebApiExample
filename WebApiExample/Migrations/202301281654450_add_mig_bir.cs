namespace WebApiExample.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_bir : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable: false),
                        StudentSurname = c.String(nullable: false),
                        StudentStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropTable("Students");
        }
    }
}
