using Commitizen.Core;
using Commitizen.Core.Models;
using Commitizen.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Commitizen.Services
{
    public class ChangeTypeService : IChangeTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ChangeTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ChangeType> CreateChangeType(ChangeType changeType)
        {
            await _unitOfWork.ChangeTypes.AddAsync(changeType);
            await _unitOfWork.CommitAsync();
            return changeType;
        }

        public async Task DeleteChangeType(ChangeType changeType)
        {
            _unitOfWork.ChangeTypes.Remove(changeType);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<ChangeType>> GetAllActiveAsync()
        {
            return await _unitOfWork.ChangeTypes.GetAllActiveAsync();
        }

        public async Task<ChangeType> GetChangeTypeById(int id)
        {
            return await _unitOfWork.ChangeTypes.GetByIdAsync(id);
        }

        public async Task UpdateChangeType(ChangeType changeTypeToBeUpdated, ChangeType changeType)
        {
            changeTypeToBeUpdated.Name = changeType.Name;
            changeTypeToBeUpdated.Description = changeType.Description;
            changeTypeToBeUpdated.Active = changeType.Active;

            await _unitOfWork.CommitAsync();
        }
    }
}
