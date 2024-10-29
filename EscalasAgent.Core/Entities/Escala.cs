

namespace EscalasAgent.Core.Entities
{
    public class Escala
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data {  get; set; }
        public int IdEquipe {  get; set; }
        public Equipe equipe { get; set; }

        // Propriedade opcional para pessoas extras
        public ICollection<Pessoa> PessoasExtras { get; set; }

        public Escala()
        {

        }

        public Escala(int id, string titulo, string descricao, DateTime data, int idEquipe, Equipe equipe)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Data = data;
            IdEquipe = idEquipe;
            this.equipe = equipe;
        }
    }
}
