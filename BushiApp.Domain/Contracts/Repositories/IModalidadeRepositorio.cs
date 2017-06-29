using BushiApp.Domain.Models;
using System;

namespace BushiApp.Domain.Contracts.Repositories
{
    public interface IModalidadeRepositorio: IDisposable
    {
        Modalidade Get(string nome);

        Modalidade Get(int id);

        void Create(Modalidade modalidade);

        void Update(Modalidade modalidade);

        void Delete(Modalidade modalidade);
    }
}
