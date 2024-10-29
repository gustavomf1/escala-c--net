namespace EscalasAgent.Core.Entities
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int IdEquipe {  get; set; }
        public Equipe equipe { get; set; }
        public DateTime dataCadasto { get; set; }
        public bool ativo { get; set; }

        // Propriedade opcional que indica as escalas nas quais essa pessoa é uma pessoa extra
        public virtual ICollection<Escala> EscalasExtras { get; set; }

        public Pessoa()
        {
            this.EscalasExtras = new HashSet<Escala>();
        }

        public Pessoa(int id, string nome, string cpf, int idEquipe, Equipe equipe, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            IdEquipe = idEquipe;
            this.equipe = equipe;
            this.dataCadasto = DateTime.Now;
            this.ativo = true;
            Email = email;
            Senha = senha;
        }
    }
}
