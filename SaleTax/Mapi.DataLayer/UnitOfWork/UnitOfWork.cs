using Mapi.DataLayer.Repository;
using Mapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapi.DataLayer
{
    public class UnitOfWork
    {
        public class GenericUnitOfWork
        {
            private SaleTaxContext entities = null;

            public GenericUnitOfWork()
            {
                entities = new SaleTaxContext();
            }

            public Dictionary<Type, object> repositories = new Dictionary<Type, object>();

            public IGenericRepository<T> Repository<T>() where T : class
            {
                if (repositories.Keys.Contains(typeof(T)) == true)
                {
                    return repositories[typeof(T)] as GenericRepository<T>;
                }
                IGenericRepository<T> repo = new GenericRepository<T>(entities);
                repositories.Add(typeof(T), repo);
                return repo;
            }

            public void Save()
            {
                entities.SaveChanges();
            }

            private bool disposed = false;

            protected virtual void Dispose(bool disposing)
            {
                if (!this.disposed)
                {
                    if (disposing)
                    {
                        entities.Dispose();
                    }
                }
                this.disposed = true;
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }
    }
}
