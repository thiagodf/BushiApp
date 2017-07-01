using BushiApp.Domain.Models;
using BushiApp.Infraestructure.Data.Map;
using System.Data.Entity;

namespace BushiApp.Infraestructure.Data
{
    public class AppDataContext:DbContext
    {
        public AppDataContext()
            :base("AppConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Modalidade> Modalidades { get; set; }

        public DbSet<Professor> Professores { get; set; }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ModalidadeMap());
            modelBuilder.Configurations.Add(new ProfessorMap());
            modelBuilder.Configurations.Add(new AlunoMap());

            modelBuilder.Properties()
              .Where(p => p.Name == p.ReflectedType.Name + "Id")
              .Configure(p => p.IsKey());
        }
    }
}
