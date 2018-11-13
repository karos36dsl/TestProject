namespace Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Web.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Web.Models.ApplicationDbContext";
        }

        protected override void Seed(Web.Models.ApplicationDbContext context)
        {
            context.Numbers.Add(new Number { QuantityRooms = "1", TypeRoom = "Эконом", Status = "Свободен", Price = "1000 р." });
            context.Numbers.Add(new Number { QuantityRooms = "1", TypeRoom = "Бизнес", Status = "Свободен", Price = "2000 р." });
            context.Numbers.Add(new Number { QuantityRooms = "1", TypeRoom = "Люкс", Status = "Свободен", Price = "3000 р." });
            context.Numbers.Add(new Number { QuantityRooms = "2", TypeRoom = "Эконом", Status = "Свободен", Price = "2000 р." });
            context.Numbers.Add(new Number { QuantityRooms = "2", TypeRoom = "Бизнес", Status = "Свободен", Price = "4000 р." });
            context.Numbers.Add(new Number { QuantityRooms = "2", TypeRoom = "Люкс", Status = "Свободен", Price = "6000 р." });
            context.Numbers.Add(new Number { QuantityRooms = "3", TypeRoom = "Эконом", Status = "Свободен", Price = "3000 р." });
            context.Numbers.Add(new Number { QuantityRooms = "3", TypeRoom = "Бизнес", Status = "Свободен", Price = "4000 р." });
            context.Numbers.Add(new Number { QuantityRooms = "3", TypeRoom = "Люкс", Status = "Свободен", Price = "9000 р." });
            context.Numbers.Add(new Number { QuantityRooms = "4", TypeRoom = "Президентский Люкс", Status = "Свободен", Price = "15000 р." });
            context.Numbers.Add(new Number { QuantityRooms = "4", TypeRoom = "Президентский Люкс", Status = "Свободен", Price = "15000 р." });
            context.Numbers.Add(new Number { QuantityRooms = "4", TypeRoom = "Президентский Люкс", Status = "Свободен", Price = "15000 р." });


            base.Seed(context);
        }
    }
}
