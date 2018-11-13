using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ProjectContext : DbContext
    {
        public DbSet<Number> Numbers { get; set; }
        public DbSet<OrderNumber> OrderNumbers { get; set; }
    }
}