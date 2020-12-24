using Commitizen.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Commitizen.Core.Services
{
    public interface IScopeService
    {
        Task<IEnumerable<Scope>> GetAllActiveAsync();
        Task<Scope> GetScopeById(int id);
        Task<Scope> CreateScope(Scope scope);
        Task UpdateScope(Scope scopeToBeUpdated, Scope scope);
        Task DeleteScope(Scope scope);
    }
}
