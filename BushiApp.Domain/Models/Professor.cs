using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BushiApp.Domain.Models
{
    public class Professor
    {
        public Professor()
        {

        }
        public Professor(string nome, List<Modalidade> modalidades)
        {
            this.ProNome = nome;
            this.ModalidadesLista = modalidades;
        }

        public int ProId{ get; private set; }

        public string ProNome { get; set; }

        public virtual ICollection<Modalidade> ModalidadesLista{ get; set; }
    }
}
