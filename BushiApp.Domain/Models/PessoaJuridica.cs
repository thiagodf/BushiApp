namespace BushiApp.Domain.Models
{
    public abstract class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(){}

        public PessoaJuridica(string documento)
        {
            this.Documento = documento;
        }
        public string Documento { get; private set; }
    }
}
