using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Dominio.Interfaces.Repository.SIGA
{
   public interface IRepositorySIGA<TEntity> : IDisposable where TEntity : class
    {
        TEntity AdicionarSIGA(TEntity obj);
        TEntity AtualizarSIGA(TEntity obj);
        TEntity ObterPorIdSIGA(int id);
        IEnumerable<TEntity> ObterTodosSIGA();
        void RemoverSIGA(int id);
        IEnumerable<TEntity> BuscarSIGA(Expression<Func<TEntity, bool>> predicate);

        int SaveChangesSIGA();
    }
}
