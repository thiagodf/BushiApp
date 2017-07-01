namespace BushiApp.Domain.Models
{
    public class Aluno:PessoaFisica
    {
        public Aluno(){}

        public Aluno(string documento, string matricula, string nome, string telefone, string email) :
            base(documento, nome, telefone, email)
        {
            this.Matricula = matricula;
        }

        public string Matricula { get; private set; }
    }
}
