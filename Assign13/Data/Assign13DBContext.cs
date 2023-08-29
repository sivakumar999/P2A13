using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assign13.Data
{
    public class Assign13DBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Assign13DBContext() : base("name=Assign13DBContext")
        {
        }

        public System.Data.Entity.DbSet<Assign13.Models.Team> Teams { get; set; }
    }
}
