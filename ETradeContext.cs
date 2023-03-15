using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace EntityframeworkDemo
{
    class ETradeContext :DbContext
    {
        public DbSet<Product> Products { get; set; }

    }
}
