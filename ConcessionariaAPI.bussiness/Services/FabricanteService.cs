using ConcessionariaAPI.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcessionariaAPI.Domain.Model;
using ConcessionariaAPI.Domain.Contracts.Respositories;

namespace ConcessionariaAPI.bussiness.Services
{
    public class FabricanteService : IFabricanteService
    {
        private IFabricanteRepository _repository;

        public void ChangeData(string nome, string paisOrigem)
        {
            var fabricante = GetByName(nome);
            fabricante.ChangeData(nome, paisOrigem);
            fabricante.Validate();

            _repository.Update(fabricante);

        }

        public Fabricante GetByName(string nome)
        {
            return _repository.Get(nome);
        }
    }
}
