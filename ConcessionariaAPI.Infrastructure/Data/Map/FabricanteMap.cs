using ConcessionariaAPI.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaAPI.Infrastructure.Data.Map
{
    class FabricanteMap : EntityTypeConfiguration<Fabricante>
    {

        public FabricanteMap()
        {
            ToTable("Fabrincate");

            Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nome).HasMaxLength(200)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("IX_Nome_Fabricante", 1) { IsUnique = true}))
                .IsRequired();

            Property(x => x.PaisOrigem).HasMaxLength(200).IsRequired();

        }
    }
}
