namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderNumbers", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderNumbers", "UserId", c => c.Int(nullable: false));
        }
    }
}
