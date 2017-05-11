using Digigraf.Rat.Dominio.Interfaces.Repository.SIGA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Digigraf.Rat.Infra.Dados.Context;
using System.Data.Entity;

namespace Digigraf.Rat.Infra.Dados.Repository.SIGA
{
    public class RepositorySIGA<TEntity> : IRepositorySIGA<TEntity> where TEntity : class
    {
        protected SIGAContext DbSIGA;
        protected DbSet<TEntity> DbSetSIGA;

        public RepositorySIGA(SIGAContext contextSIGA)
        {
            DbSIGA = contextSIGA;
            DbSetSIGA = DbSIGA.Set<TEntity>();
        }


        public TEntity AdicionarSIGA(TEntity obj)
        {
            return DbSetSIGA.Add(obj);
        }

        public TEntity AtualizarSIGA(TEntity obj)
        {
            var entry = DbSIGA.Entry(obj);
            DbSetSIGA.Attach(obj);
            entry.State = EntityState.Modified;

            return obj;
        }

        public IEnumerable<TEntity> BuscarSIGA(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSetSIGA.Where(predicate);
        }

        public void Dispose()
        {
            DbSIGA.Dispose();
            GC.SuppressFinalize(this);
        }

        public TEntity ObterPorIdSIGA(int id)
        {
            return DbSetSIGA.Find(id);
        }

        public IEnumerable<TEntity> ObterTodosSIGA()
        {
            return DbSetSIGA.ToList();
        }

        public void RemoverSIGA(int id)
        {
            DbSetSIGA.Remove(DbSetSIGA.Find(id));
        }

        public int SaveChangesSIGA()
        {
            return DbSIGA.SaveChanges();
        }
    }
}
