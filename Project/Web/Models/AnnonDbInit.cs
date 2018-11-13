using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class AnnonDbInit : DropCreateDatabaseAlways<AnnonContext>
    {
        protected override void Seed(AnnonContext db)
        {
            db.Annons.Add(new Annon { Name = "Веб Дизайнер", Price = "10000 p", Description = "Креативность и знание графического редактора ", Organisation = "Creative", ContactFace = "Alex", NumberPhone = "89998876", Type = "Полная" });
            db.Annons.Add(new Annon { Name = "Переводчик", Price = "150000 p", Description = "Необходимо знание Английского языка ", Organisation = "Translate", ContactFace = "Olga", NumberPhone = "89998876", Type = "Полная" });
            db.Annons.Add(new Annon { Name = "Программист c++", Price = "10000 p", Description = "Уверенное Знание языка программирования c++ ", Organisation = "Coder", ContactFace = "Jane", NumberPhone = "89998876", Type = "Полная" });
            db.Annons.Add(new Annon { Name = ",e[ufknth", Price = "150000 p", Description = "Ведение Учета ", Organisation = "пфр", ContactFace = "Dmitri", NumberPhone = "89998876", Type = "Полная" });

            base.Seed(db);
        }
    }
}