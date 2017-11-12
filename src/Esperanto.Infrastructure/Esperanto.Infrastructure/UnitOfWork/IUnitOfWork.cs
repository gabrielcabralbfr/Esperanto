using System;


namespace Esperanto.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
