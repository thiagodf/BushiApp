using BushiApp.Domain.Contracts.Repositories;
using BushiApp.Domain.Models;
using BushiApp.Infraestructure.Data;
using BushiApp.Infraestructure.Repositories;
using Microsoft.Practices.Unity;

namespace BushiApp.Startup
{
    public static class DependencyResolver 
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<AppDataContext, AppDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IModalidadeRepositorio, ModalidadeRepositorio>(new HierarchicalLifetimeManager());
            container.RegisterType<IProfessorRepositorio, ProfessorRepositorio>(new HierarchicalLifetimeManager());

            container.RegisterType<Professor, Professor>(new HierarchicalLifetimeManager());
            container.RegisterType<Modalidade, Modalidade>(new HierarchicalLifetimeManager());
        }

    }
}
