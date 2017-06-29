using BushiApp.Domain.Contracts.Repositories;
using BushiApp.Domain.Models;
using BushiApp.Infraestructure.Data;
using System.Linq;

namespace BushiApp.Infraestructure.Repositories
{
    public class ModalidadeRepositorio : IModalidadeRepositorio
    {
        AppDataContext _contexto = new AppDataContext();

        public Modalidade Get(string nome)

        {
            return(_contexto.Modalidades.Where(x => x.Nome == nome).FirstOrDefault());
        }

        public Modalidade Get(int id)
        {
            return (_contexto.Modalidades.Where(x => x.Id == id).FirstOrDefault());
        }

        public void Create(Modalidade modalidade)
        {
            _contexto.Modalidades.Add(modalidade);
            _contexto.SaveChanges();
        }

        public void Update(Modalidade modalidade)
        {
            _contexto.Entry<Modalidade>(modalidade).State = System.Data.Entity.EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Delete(Modalidade modalidade)
        {
            _contexto.Modalidades.Remove(modalidade);
            _contexto.SaveChanges();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

    }
}
