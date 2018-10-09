using GTC.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace GTC.ApplicationCore.Validations
{
    public class ValidaNFe
    {
        public bool ValidaNull(NFe nfe)
        {
            if (string.IsNullOrEmpty(nfe.infNFe.ide.cNF.ToString()))
                return false;
            else
            {
                return true;
            }
        }
    }
}
