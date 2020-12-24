using Commitizen.Core.Models;
using Commitizen.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commitizen.Data.Repositories
{
    public class ScopeRepository : Repository<Scope>, IScopeRepository
    {
        public ScopeRepository(CommitizenDbContext context) : base(context) { }
        public async Task<IEnumerable<Scope>> GetAllActiveAsync()
        {
            return await((CommitizenDbContext)Context).Scopes
                .Where(s => s.Active == true)
                .ToListAsync();
        }
    }
}
