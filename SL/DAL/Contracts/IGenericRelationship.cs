using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Contracts
{
    internal interface IGenericRelationship<T, U>
    {

        // Agrego una relación de tipo 1 a *, T elemento origen, U es el destino
        void Join(T obj1, U obj2);


        List<U> Get(T obj);
    }
}
