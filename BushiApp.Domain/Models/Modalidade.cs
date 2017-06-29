using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BushiApp.Domain.Models
{
    public class Modalidade
    {
        public Modalidade() { }

        public Modalidade(string nome, string descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        public int Id { get; private set; }

        public string Nome { get; private set; }

        public string Descricao { get; private set; }
    }
}
