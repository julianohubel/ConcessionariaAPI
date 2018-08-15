using ConcessionariaAPI.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaAPI.Domain.Contracts.Respositories
{
    public interface IFabricanteRepository : IDisposable
    {
        Fabricante Get(string nome);

        Fabricante Get(Guid id);

        void Create(Fabricante fabricante);

        void Update(Fabricante fabricante);

        void Delete(Fabricante fabricante);

    }
}
