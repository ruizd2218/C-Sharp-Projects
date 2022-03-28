﻿namespace CodeFirstDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddURL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "URL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "URL");
        }
    }
}
