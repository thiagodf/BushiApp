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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ModalidadeMap());
        }
    }
}
