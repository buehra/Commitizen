using Commitizen.Core;
using Commitizen.Core.Repositories;
using Commitizen.Data.Repositories;
using System.Threading.Tasks;

namespace Commitizen.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CommitizenDbContext _context;
        private ChangeTypeRepository _changeTypeRepository;
        private ScopeRepository _scopeRepository;

        public UnitOfWork(CommitizenDbContext context)
        {
            _context = context;
        }

        public IChangeTypeRepository ChangeTypes => _changeTypeRepository ??= new ChangeTypeRepository(_context);

        public IScopeRepository Scopes => _scopeRepository ??= new ScopeRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
