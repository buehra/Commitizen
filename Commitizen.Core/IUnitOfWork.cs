using Commitizen.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace Commitizen.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IChangeTypeRepository ChangeTypes { get; }
        IScopeRepository Scopes { get; }
        Task<int> CommitAsync();
    }
}
