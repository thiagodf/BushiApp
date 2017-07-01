using BushiApp.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BushiApp.Infraestructure.Data.Map
{
    class ProfessorMap : EntityTypeConfiguration<Professor>
    {
        public ProfessorMap()
        {
            ToTable("Professor");

            HasKey(x => x.ProId);

            Property(x => x.ProId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.ProNome)
                .HasMaxLength(60)
                .IsRequired();

            //N:N
            HasMany(x => x.ModalidadesLista)
                .WithMany(x => x.ProfessorLista)
                .Map(m =>
                {
                    m.MapLeftKey("ModId");
                    m.MapRightKey("ProId");
                    m.ToTable("ProfessorModalidade");
                });
        }

    }
}
