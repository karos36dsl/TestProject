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
            context.Numbers.Add(new Number { QuantityRooms = "1", TypeRoom = "������", Status = "��������", Price = "1000 �." });
            context.Numbers.Add(new Number { QuantityRooms = "1", TypeRoom = "������", Status = "��������", Price = "2000 �." });
            context.Numbers.Add(new Number { QuantityRooms = "1", TypeRoom = "����", Status = "��������", Price = "3000 �." });
            context.Numbers.Add(new Number { QuantityRooms = "2", TypeRoom = "������", Status = "��������", Price = "2000 �." });
            context.Numbers.Add(new Number { QuantityRooms = "2", TypeRoom = "������", Status = "��������", Price = "4000 �." });
            context.Numbers.Add(new Number { QuantityRooms = "2", TypeRoom = "����", Status = "��������", Price = "6000 �." });
            context.Numbers.Add(new Number { QuantityRooms = "3", TypeRoom = "������", Status = "��������", Price = "3000 �." });
            context.Numbers.Add(new Number { QuantityRooms = "3", TypeRoom = "������", Status = "��������", Price = "4000 �." });
            context.Numbers.Add(new Number { QuantityRooms = "3", TypeRoom = "����", Status = "��������", Price = "9000 �." });
            context.Numbers.Add(new Number { QuantityRooms = "4", TypeRoom = "������������� ����", Status = "��������", Price = "15000 �." });
            context.Numbers.Add(new Number { QuantityRooms = "4", TypeRoom = "������������� ����", Status = "��������", Price = "15000 �." });
            context.Numbers.Add(new Number { QuantityRooms = "4", TypeRoom = "������������� ����", Status = "��������", Price = "15000 �." });


            base.Seed(context);
        }
    }
}
