namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderNumbers", "UserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderNumbers", "UserId");
        }
    }
}
