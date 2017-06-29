using BushiApp.Domain.Contracts.Repositories;
using BushiApp.Domain.Models;
using BushiApp.Infraestructure.Data;
using BushiApp.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verificar se o relacionamento de professor com modalidade realmente é N pra N ou 1 pra N.

            AppDataContext contexto = new AppDataContext();
            //var modalidade = new Modalidade(
            //    "Jiu-Jitsu",
            //    "Arte Marcial Suave"
            //    );

            //using (IModalidadeRepositorio modalidadeRep = new ModalidadeRepositorio(contexto))
            //{
            //    modalidadeRep.Create(modalidade);
            //}

            using (IModalidadeRepositorio modalidadeRep = new ModalidadeRepositorio(contexto))
            {
                var modRep = modalidadeRep.Get("Jiu-Jitsu");
                List<Modalidade> modalidades = new List<Modalidade>();
                modalidades.Add(modRep);

                var professor = new Professor("Thiago", modalidades);
                contexto = new AppDataContext();
                IProfessorRepositorio profRep = new ProfessorRepositorio(contexto);
                profRep.Create(professor);


            
            }
        }
    }
}
