using BushiApp.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BushiApp.Infraestructure.Data.Map
{
    public class AlunoMap: EntityTypeConfiguration<Aluno>
    {
        public AlunoMap()
        {
            ToTable("Aluno");

            HasKey(x => x.Matricula);

            Property(x => x.Matricula)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.Nome)
                .HasMaxLength(60)
                .IsRequired();

            Property(x => x.Telefone)
                .HasMaxLength(20);

            Property(x => x.Email)
                .HasMaxLength(100);

            Property(x => x.Documento)
                .HasMaxLength(11)
                .IsRequired();
        }
    }
}
