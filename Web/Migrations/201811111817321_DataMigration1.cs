namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderNumbers", "NumberId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderNumbers", "NumberId", c => c.String());
        }
    }
}
