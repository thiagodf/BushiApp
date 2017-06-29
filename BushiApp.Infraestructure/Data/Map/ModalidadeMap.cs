using BushiApp.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BushiApp.Infraestructure.Data.Map
{
    public class ModalidadeMap : EntityTypeConfiguration<Modalidade>
    {
        public ModalidadeMap()
        {
            ToTable("Modalidade");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .HasMaxLength(60)
                .IsRequired();

            Property(x => x.Descricao)
                .HasMaxLength(500);
        }
    }
}
