using ConcessionariaAPI.Domain.Model;
using ConcessionariaAPI.Infrastructure.Data.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaAPI.Infrastructure.Data
{
    public class ConcessionariaAPIDataContext   : DbContext
    {
        public ConcessionariaAPIDataContext() : base("ConcessionariaAPI")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Fabricante> fabricantes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FabricanteMap());
        }

    }
}
