using ConcessionariaAPI.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaAPI.Domain.Contracts.Services
{
    public interface IFabricanteService
    {
    
        Fabricante GetByName(string nome);

        void ChangeData(string nome, string PaisOrigem);

    }
}
