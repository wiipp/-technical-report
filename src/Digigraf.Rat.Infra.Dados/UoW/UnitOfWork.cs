using System;
using Digigraf.Rat.Infra.Dados.Context;
using Digigraf.Rat.Infra.Dados.Interfaces;

namespace Digigraf.Rat.Infra.Dados.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RatContext _context;
        private bool _disposed;

        public UnitOfWork(RatContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}
