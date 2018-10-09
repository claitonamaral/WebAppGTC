using GTC.ApplicationCore.Interfaces.Generic;
using GTC.Infrastruture.Config;
using Raven.Client.Documents.Session;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTC.Infrastruture.Repository.Generic
{
    class RepositoryGeneric<T> : InterfaceGeneric<T>, IDisposable where T : class
    {
        private readonly Lazy<IAsyncDocumentSession> _session;
        public RepositoryGeneric()
        {
            _session = new Lazy<IAsyncDocumentSession>();
        }

        public void Add(T Entity)
        {
            using (var db = DocumentStoreHolder.Store.OpenSession())
            {
                db.Store(Entity);
                db.SaveChanges();
            }
        }

        public void Delete(T Entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T GetEntity(int Id)
        {
            throw new NotImplementedException();
        }

        public List<T> List()
        {
            throw new NotImplementedException();
        }

        public void Update(T Entity)
        {
            throw new NotImplementedException();
        }
    }
}
