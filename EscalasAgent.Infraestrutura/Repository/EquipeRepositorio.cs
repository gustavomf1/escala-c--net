using EscalasAgent.Core.Entities;
using EscalasAgent.Infraestrutura.Context;
using EscalasAgent.Infrastructure.Repository;
using EscalasAgent.Interfaces;


namespace EscalasAgent.Infraestrutura.Repository
{
    public class EquipeRepositorio : BaseRepositorio<Equipe>, IEquipeRepositorio
    {
        public EquipeRepositorio(DbContextEscolaAgent context) : base(context) { }
    }
}
