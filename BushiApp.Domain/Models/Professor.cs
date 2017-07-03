using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BushiApp.Domain.Models
{
    public class Professor: PessoaFisica
    {
        public Professor(){}

        public Professor(string nome, List<Modalidade> modalidades, string documento, string telefone, string email)
            :base(documento, nome, telefone, email)
        {
            this.ModalidadesLista = modalidades;
        }

        public int ProId{ get; private set; }

        public virtual ICollection<Modalidade> ModalidadesLista{ get; set; }
    }
}
