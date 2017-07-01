using BushiApp.Domain.Contracts.Repositories;
using BushiApp.Domain.Models;
using BushiApp.Infraestructure.Data;
using System.Linq;

namespace BushiApp.Infraestructure.Repositories
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        AppDataContext _contexto;

        public AlunoRepositorio(){}

        public AlunoRepositorio(AppDataContext _contexto)
        {
            this._contexto =_contexto;
        }

        public Aluno GetEmail(string email)
        {
            return (_contexto.Alunos.Where(x => x.Email == email).FirstOrDefault());
        }

        public Aluno GetMatricula(string matricula)
        {
            return (_contexto.Alunos.Where(x => x.Matricula == matricula).FirstOrDefault());
        }

        public Aluno GetNome(string nome)
        {
            return (_contexto.Alunos.Where(x => x.Nome == nome).FirstOrDefault());
        }

        public void Create(Aluno aluno)
        {
            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();
        }

        public void Update(Aluno aluno)
        {
            _contexto.Entry<Aluno>(aluno).State = System.Data.Entity.EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Delete(Aluno aluno)
        {
            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
