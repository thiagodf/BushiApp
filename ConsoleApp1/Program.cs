using BushiApp.Domain.Contracts.Repositories;
using BushiApp.Domain.Models;
using BushiApp.Infraestructure.Data;
using BushiApp.Infraestructure.Repositories;
using BushiApp.Startup;
using Microsoft.Practices.Unity;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verificar se o relacionamento de professor com modalidade realmente é N pra N ou 1 pra N.

            var container = new UnityContainer();
            DependencyResolver.Resolve(container);

            //var modalidade = new Modalidade(
            //    "Jiu-jitsu",
            //    "Arte marcial suave"
            //    );

            //var modalidadeRep = container.Resolve<ModalidadeRepositorio>();
            //var modalidade1 = modalidadeRep.Get("Jiu-Jitsu");
            //var modalidade2 = modalidadeRep.Get("Judô");


            //List<Modalidade> modalidadeLista = new List<Modalidade>();
            //modalidadeLista.Add(modalidade1);
            //modalidadeLista.Add(modalidade2);

            //var professorRep = container.Resolve<ProfessorRepositorio>();
            //var professor = new Professor("Thiago", modalidadeLista);
            //professorRep.Create(professor);

            //professor = professorRep.Get("Thiago");

            //var aluno = new Aluno(
            //    "01827940166",
            //    "011122929983",
            //    "VALENTINA",
            //    "6191381511",
            //    "valentina@email.com");

            var alunoRepositorio = container.Resolve<AlunoRepositorio>();
            //alunoRepositorio.Create(aluno);

            
            var alunoTeste = alunoRepositorio.GetNome("valentina");
            
        }
    }
}
