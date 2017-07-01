using BushiApp.Domain.Models;
using System;

namespace BushiApp.Domain.Contracts.Repositories
{
    public interface IAlunoRepositorio: IDisposable
    {
        Aluno GetNome(string nome);

        Aluno GetMatricula(string matricula);

        Aluno GetEmail(string email);

        void Create(Aluno aluno);

        void Update(Aluno aluno);

        void Delete(Aluno aluno);
    }
}
