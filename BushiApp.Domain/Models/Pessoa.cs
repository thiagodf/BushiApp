namespace BushiApp.Domain.Models
{
    public abstract class Pessoa
    {
        public Pessoa(){}

        public Pessoa(string nome, string telefone, string email)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
        }

        public string Nome { get; private set; }

        public string Telefone { get; private set; }

        public string Email { get; private set; }
    }
}
