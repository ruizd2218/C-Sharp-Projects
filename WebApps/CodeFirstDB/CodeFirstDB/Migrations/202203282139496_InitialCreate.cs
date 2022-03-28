namespace CodeFirstDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assignments",
                c => new
                    {
                        AssignmentID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        StudentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AssignmentID)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assignments", "StudentID", "dbo.Students");
            DropIndex("dbo.Assignments", new[] { "StudentID" });
            DropTable("dbo.Students");
            DropTable("dbo.Assignments");
        }
    }
}
