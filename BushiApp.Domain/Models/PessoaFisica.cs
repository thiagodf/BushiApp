namespace BushiApp.Domain.Models
{
    public abstract class PessoaFisica : Pessoa
    {
        public PessoaFisica(){}

        public PessoaFisica(string documento, string nome, string telefone, string email)
            :base(nome, telefone, email)
        {
            this.Documento = documento;
            
        }
        public string Documento { get; private set; }
    }
}
