using Commitizen.Core.Models;
using Commitizen.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commitizen.Data.Repositories
{
    public class ChangeTypeRepository : Repository<ChangeType>, IChangeTypeRepository
    {
        public ChangeTypeRepository(CommitizenDbContext context) : base(context) { }

        public async Task<IEnumerable<ChangeType>> GetAllActiveAsync()
        {
            return await ((CommitizenDbContext)Context).ChangeTypes
                .Where(c => c.Active == true)
                .ToListAsync();
        }
    }
}
