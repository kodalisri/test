using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SantoshProject.DataContext
{
    public class NewDataContext : DbContext
    {
        public NewDataContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<EfilingTemplates> DetailsDbSet { get; set; }
    }
}