using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalasAgent.Core.Entities
{
    public class Equipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Escala> escalas { get; set; }

        public Equipe() { }

        public Equipe(int id, string name, ICollection<Escala> escalas)
        {
            Id = id;
            Name = name;
            this.escalas = escalas;
        }
    }
}
