using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class NumberDbInit : DropCreateDatabaseAlways<ProjectContext>
    {
        protected override void Seed(ProjectContext db)
        {
            db.Numbers.Add(new Number {QuantityRooms = "1",TypeRoom = "Эконом",Status = "Свободен",Price = "1000 р." });
            db.Numbers.Add(new Number { QuantityRooms = "1", TypeRoom = "Бизнес", Status = "Свободен", Price = "2000 р." });
            db.Numbers.Add(new Number { QuantityRooms = "1", TypeRoom = "Люкс", Status = "Свободен", Price = "3000 р." });
            db.Numbers.Add(new Number { QuantityRooms = "2", TypeRoom = "Эконом", Status = "Свободен", Price = "2000 р." });
            db.Numbers.Add(new Number { QuantityRooms = "2", TypeRoom = "Бизнес", Status = "Свободен", Price = "4000 р." });
            db.Numbers.Add(new Number { QuantityRooms = "2", TypeRoom = "Люкс", Status = "Свободен", Price = "6000 р." });
            db.Numbers.Add(new Number { QuantityRooms = "3", TypeRoom = "Эконом", Status = "Свободен", Price = "3000 р." });
            db.Numbers.Add(new Number { QuantityRooms = "3", TypeRoom = "Бизнес", Status = "Свободен", Price = "4000 р." });
            db.Numbers.Add(new Number { QuantityRooms = "3", TypeRoom = "Люкс", Status = "Свободен", Price = "9000 р." });
            db.Numbers.Add(new Number { QuantityRooms = "4", TypeRoom = "Президентский Люкс", Status = "Свободен", Price = "15000 р." });
            db.Numbers.Add(new Number { QuantityRooms = "4", TypeRoom = "Президентский Люкс", Status = "Свободен", Price = "15000 р." });
            db.Numbers.Add(new Number { QuantityRooms = "4", TypeRoom = "Президентский Люкс", Status = "Свободен", Price = "15000 р." });


            base.Seed(db);
        }
    }
}