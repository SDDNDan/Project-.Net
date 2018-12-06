using System;
using DomainLayer.Base;
using DataAccessLayer.Base.DataContext;

namespace DataAccessLayer.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDataContext dataContext;

        private bool disposed;

        public UnitOfWork(IDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Commit()
        {
            this.dataContext.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.dataContext.Dispose();
                }
            }

            this.disposed = true;
        }
    }
}
