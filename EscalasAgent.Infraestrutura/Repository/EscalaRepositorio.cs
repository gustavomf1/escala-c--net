using EscalasAgent.Core.Entities;
using EscalasAgent.Infraestrutura.Context;
using EscalasAgent.Infrastructure.Repository;
using EscalasAgent.Interfaces;

namespace EscalasAgent.Infraestrutura.Repository
{
    public class EscalaRepositorio : BaseRepositorio<Escala>, IEscalaRepositorio
    {
        public EscalaRepositorio(DbContextEscolaAgent context) : base(context) { }
    }
}
