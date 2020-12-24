using Commitizen.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Commitizen.Core.Repositories
{
    public interface IScopeRepository : IRepository<Scope>
    {
        Task<IEnumerable<Scope>> GetAllActiveAsync();
    }
}
