using System.Collections.Generic;

namespace BushiApp.Domain.Models
{
    public class Modalidade
    {
        public Modalidade() { }

        public Modalidade(string nome, string descricao)
        {
            this.ModNome = nome;
            this.ModDescricao = descricao;
            ProfessorLista = new List<Professor>();
        }

        
        public int ModId { get; private set; }

        public string ModNome { get; private set; }

        public string ModDescricao { get; private set; }

        public virtual ICollection<Professor> ProfessorLista { get; set; }
    }
}
