using ConcessionariaAPI.Domain.Contracts.Respositories;
using ConcessionariaAPI.Infrastructure.Data;
using ConcessionariaAPI.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace ConcessionariaAPI.Startup
{
    public static class DependencyResolver
    {

        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<ConcessionariaAPIDataContext, ConcessionariaAPIDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IFabricanteRepository, FabricanteRepository>(new HierarchicalLifetimeManager());

        }
    }
}

