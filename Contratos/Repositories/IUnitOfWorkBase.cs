using Microsoft.EntityFrameworkCore;

using System;

namespace Contratos.Repositories
{
    public interface IUnitOfWorkBase : IDisposable
    {
        DbContext Context { get; }

        int Save();

    }
}
