using Raven.Client.Documents;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTC.Infrastruture.Config
{
    public class DocumentStoreHolder
    {
        private static Lazy<IDocumentStore> store = new Lazy<IDocumentStore>(CreateStore);

        //RETORNANDO O STORE CONTENDO A ESTRUTURA DO BANCO...
        public static IDocumentStore Store
        {
            get { return store.Value; }
        }

        //INICIALIZANDO A CONEXÃO COM O REPOSITÓRIO DO RAVENDB...
        private static IDocumentStore CreateStore()
        {
            IDocumentStore store = new DocumentStore()
            {
                Urls = new[] { "http://localhost:8080" },
                Database = "GTC"
            }.Initialize();

            return store;
            
        }
    }
}
