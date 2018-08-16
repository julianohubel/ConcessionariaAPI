using ConcessionariaAPI.Domain.Contracts.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcessionariaAPI.Domain.Model;
using ConcessionariaAPI.Infrastructure.Data;

namespace ConcessionariaAPI.Infrastructure.Repositories
{
    public class FabricanteRepository : IFabricanteRepository
    {
        private ConcessionariaAPIDataContext dbContext;

        public FabricanteRepository(ConcessionariaAPIDataContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public void Create(Fabricante fabricante)
        {
            dbContext.fabricantes.Add(fabricante);
            dbContext.SaveChanges();
        }

        public void Delete(Fabricante fabricante)
        {
            var item =  dbContext.fabricantes.Find(fabricante.ID);
            dbContext.fabricantes.Remove(item);
            dbContext.SaveChanges();
        }


        public Fabricante Get(string nome)
        {
            return dbContext.fabricantes.Where(f => f.Nome == nome).FirstOrDefault();
        }

        public Fabricante Get(Guid id)
        {
            return dbContext.fabricantes.Where(f => f.ID == id).FirstOrDefault();
        }

        public void Update(Fabricante fabricante)
        {
            dbContext.Entry<Fabricante>(fabricante).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }
        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
