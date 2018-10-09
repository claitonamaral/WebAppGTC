using System;
using System.Collections.Generic;
using System.Text;

namespace GTC.ApplicationCore.Interfaces.Generic
{
    public interface InterfaceGeneric<T> where T : class
    {
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
        T GetEntity(int Id);
        List<T> List();
    }
}
