using BushiApp.Domain.Models;
using System;

namespace BushiApp.Domain.Contracts.Repositories
{
    public interface IProfessorRepositorio: IDisposable
    {
        Professor Get(string nome);

        Professor Get(int id);

        void Create(Professor professor);

        void Update(Professor professor);

        void Delete(Professor professor);
    }
}
