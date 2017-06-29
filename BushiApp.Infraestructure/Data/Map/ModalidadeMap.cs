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

            HasKey(x => x.ModId);

            Property(x => x.ModId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.ModNome)
                .HasMaxLength(60)
                .IsRequired();

            Property(x => x.ModDescricao)
                .HasMaxLength(500);
        }
    }
}
