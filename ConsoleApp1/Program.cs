using BushiApp.Domain.Contracts.Repositories;
using BushiApp.Infraestructure.Data;
using BushiApp.Infraestructure.Repositories;
using BushiApp.Startup;
using Microsoft.Practices.Unity;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verificar se o relacionamento de professor com modalidade realmente é N pra N ou 1 pra N.
            var container = new UnityContainer();
            DependencyResolver.Resolve(container);
            var modalidadeRep = container.Resolve<ModalidadeRepositorio>();
            var modRep = modalidadeRep.Get("Jiu-Jitsu");

            //IModalidadeRepositorio modRep;

            //var modsRep = modRep.Get("Jiu-Jitsu");

            //var modalidade = new Modalidade(
            //    "Jiu-Jitsu",
            //    "Arte Marcial Suave"
            //    );

            //using (IModalidadeRepositorio modalidadeRep = new ModalidadeRepositorio(contexto))
            //{
            //    modalidadeRep.Create(modalidade);
            //}

            //using (IModalidadeRepositorio modalidadeRep = new ModalidadeRepositorio(contexto))
            //{
            //    var modRep = modalidadeRep.Get("Jiu-Jitsu");
            //    List<Modalidade> modalidades = new List<Modalidade>();
            //    modalidades.Add(modRep);

            //    var professor = new Professor("Thiago", modalidades);
            //    contexto = new AppDataContext();
            //    IProfessorRepositorio profRep = new ProfessorRepositorio(contexto);
            //    profRep.Create(professor);
            //}
        }
    }
}
