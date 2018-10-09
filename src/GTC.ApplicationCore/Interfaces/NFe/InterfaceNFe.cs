using System;
using System.Collections.Generic;
using System.Text;
using GTC.ApplicationCore.Interfaces.Generic;
using GTC.ApplicationCore.Entities;

namespace GTC.ApplicationCore.Interfaces.NFe
{
    public interface InterfaceNfe : InterfaceGeneric<NFeInfNFe>
    {
        void Adicionar(NFeInfNFe Entity);
        void Atualizar(NFeInfNFe Entity);
        void Excluir(NFeInfNFe Entity);
        NFeInfNFe LocalizarcNF(int cNF);
        List<NFeInfNFe> Listar();
    }
}
