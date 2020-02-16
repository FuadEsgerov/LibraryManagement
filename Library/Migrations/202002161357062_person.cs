namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class person : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Password", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.People", "Phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Phone", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.People", "Password");
        }
    }
}
