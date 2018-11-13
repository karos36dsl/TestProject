namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Numbers",
                c => new
                    {
                        NumberId = c.Int(nullable: false, identity: true),
                        QuantityRooms = c.String(),
                        TypeRoom = c.String(),
                        Status = c.String(),
                        Price = c.String(),
                    })
                .PrimaryKey(t => t.NumberId);
            
            CreateTable(
                "dbo.OrderNumbers",
                c => new
                    {
                        OrderNumberId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        MiddleName = c.String(nullable: false),
                        NumberId = c.String(),
                        BeginDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderNumberId);
            
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "MiddleName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "MiddleName");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropTable("dbo.OrderNumbers");
            DropTable("dbo.Numbers");
        }
    }
}
