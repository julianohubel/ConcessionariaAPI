using ConcessionariaAPI.Common.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaAPI.Domain.Model
{
    public class Fabricante
    {
        public Fabricante(string nome, string paisOrigem)
        {
            ID = Guid.NewGuid();
            Nome = nome;
            PaisOrigem = paisOrigem;

        }

        public Guid ID { get;  private set; }

        public string Nome { get; private set; }

        public string PaisOrigem { get;  private set; }
        

        public void ChangeData(string nome, string paisOrigem)
        {
            this.Nome = nome;
            this.PaisOrigem = paisOrigem;
        }


        public void Validate()
        {
            AssertionConcern.AssertArgumentLength(this.Nome, 1, 200, "Nome Inválido");
            AssertionConcern.AssertArgumentNotNull(this.Nome, "Nome Inváldo");

            AssertionConcern.AssertArgumentLength(this.PaisOrigem, 1, 200, "Pais Inválido");
            AssertionConcern.AssertArgumentNotNull(this.PaisOrigem, "País Inválido");

        }






    }
}
