using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace COVID19TriC.Data
{
    public class COVID19TriCContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public COVID19TriCContext() : base("name=COVID19TriCContext")
        {
        }

        public System.Data.Entity.DbSet<COVID19TriC.Models.Case> Cases { get; set; }

        public System.Data.Entity.DbSet<COVID19TriC.Models.Person> People { get; set; }

        public System.Data.Entity.DbSet<COVID19TriC.Models.Status> Status { get; set; }

        public System.Data.Entity.DbSet<COVID19TriC.Models.Location> Locations { get; set; }

        public System.Data.Entity.DbSet<COVID19TriC.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<COVID19TriC.Models.State> States { get; set; }
    }
}
