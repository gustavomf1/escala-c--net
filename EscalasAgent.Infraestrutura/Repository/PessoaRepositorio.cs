using EscalasAgent.Core.Entities;
using EscalasAgent.Infraestrutura.Context;
using EscalasAgent.Infrastructure.Repository;
using EscalasAgent.Interfaces;

namespace EscalasAgent.Infraestrutura.Repository
{
    public class PessoaRepositorio : BaseRepositorio<Pessoa>, IPessoaRepositorio 
    {
        public PessoaRepositorio(DbContextEscolaAgent context) : base(context) { }
    }
}
