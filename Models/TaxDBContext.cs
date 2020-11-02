using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaxCalculatorGlobalBlue.Models
{
    public class TaxDBContext:DbContext
    {
        public TaxDBContext()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // other code 
            Database.SetInitializer<TaxDBContext>(null);
            // more code here.
        }

        public DbSet<TaxInput> TaxInputs { get; set; }
    }
}