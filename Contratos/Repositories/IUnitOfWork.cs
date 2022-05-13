namespace Contratos.Repositories
{
    public interface IUnitOfWork : IUnitOfWorkBase
    {
        I GetRepository<I>();
    }
}
