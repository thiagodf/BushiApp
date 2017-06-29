using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BushiApp.Domain.Models
{
    public class Professor
    {
        public Professor(string nome, List<Modalidade> modalidades)
        {
            this.Nome = nome;
            this.Modalidades = modalidades;
        }

        public int Id{ get; private set; }

        public string Nome { get; set; }

        public virtual ICollection<Modalidade> Modalidades{ get; set; }
    }
}
