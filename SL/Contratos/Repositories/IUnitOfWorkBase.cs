using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contratos
{
    public interface IUnitOfWorkBase : IDisposable
    {
        DbContext Context { get; }

        int Save();

    }
}
