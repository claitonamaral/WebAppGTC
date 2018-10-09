using GTC.ApplicationCore.Entities;
using GTC.ApplicationCore.Interfaces.NFe;
using GTC.Infrastruture.Config;
using GTC.Infrastruture.Repository.Generic;
using Raven.Client.Documents.Session;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTC.Infrastruture.Repository.NFe
{
    class RepositoryNFe : RepositoryGeneric<NFeInfNFe>, InterfaceNfe
    {
        private readonly Lazy<IAsyncDocumentSession> _session;
        public RepositoryNFe()
        {
            _session = new Lazy<IAsyncDocumentSession>();
        }

        public void Adicionar(NFeInfNFe Entity)
        {
            using (var db = DocumentStoreHolder.Store.OpenSession())
            {
                db.Store(Entity);
                db.SaveChanges();
            }            
        }

        public void Atualizar(NFeInfNFe Entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(NFeInfNFe Entity)
        {
            throw new NotImplementedException();
        }

        public List<NFeInfNFe> Listar()
        {
            throw new NotImplementedException();
        }

        public NFeInfNFe LocalizarcNF(int cNF)
        {
            throw new NotImplementedException();
        }
    }
}
