using System.Linq.Expressions;

namespace EscalasAgent.Interfaces
{
    public interface IRepositorioBase<T> where T : class
    {
        void Inserir(T entidade);

        void Alterar(T entidade);
        void Excluir(T entidade);
        List<T> Listar(Expression<Func<T, bool>> expressao);
        List<T> ListarTodos();

        T Recuperar(Expression<Func<T, bool>> expressao);

    }
}
