using Commitizen.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Commitizen.Core.Repositories
{
    public interface IChangeTypeRepository : IRepository<ChangeType>
    {
        Task<IEnumerable<ChangeType>> GetAllActiveAsync();
    }
}
