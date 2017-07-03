using BushiApp.Domain.Contracts.Repositories;
using BushiApp.Domain.Models;
using BushiApp.Infraestructure.Data;
using System;
using System.Linq;

namespace BushiApp.Infraestructure.Repositories
{
    public class ProfessorRepositorio : IProfessorRepositorio
    {
        AppDataContext _contexto;
        public ProfessorRepositorio(AppDataContext _contexto)
        {
            this._contexto = _contexto;
        }

        public Professor Get(string nome)
        {
            return (_contexto.Professores.Where(x => x.Nome == nome).FirstOrDefault());
        }

        public Professor Get(int id)
        {
            return (_contexto.Professores.Where(x=> x.ProId == id).FirstOrDefault());
        }

        public void Create(Professor professor)
        {
            _contexto.Professores.Add(professor);
            _contexto.SaveChanges();
        }
        public void Update(Professor professor)
        {
            _contexto.Entry<Professor>(professor).State = System.Data.Entity.EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Delete(Professor professor)
        {
            _contexto.Professores.Remove(professor);
            _contexto.SaveChanges();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
