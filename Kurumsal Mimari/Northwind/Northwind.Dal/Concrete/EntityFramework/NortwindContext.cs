using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.EntityFramework
{
    public class NortwindContext:DbContext
    {
        public DbSet<Product> Product { get; set; }
    }
}
