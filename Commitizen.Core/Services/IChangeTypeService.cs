using Commitizen.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Commitizen.Core.Services
{
    public interface IChangeTypeService
    {
        Task<IEnumerable<ChangeType>> GetAllActiveAsync();
        Task<ChangeType> GetChangeTypeById(int id);
        Task<ChangeType> CreateChangeType(ChangeType changeType);
        Task UpdateChangeType(ChangeType changeTypeToBeUpdated, ChangeType changeType);
        Task DeleteChangeType(ChangeType changeType);
    }
}
