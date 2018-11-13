using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class AnnonContext : DbContext
    {
        public DbSet<Annon> Annons { get; set; }
        public DbSet<Respond> Responds { get; set; }
    }
}