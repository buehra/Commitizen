using Commitizen.Core;
using Commitizen.Core.Models;
using Commitizen.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Commitizen.Services
{
    public class ScopeService : IScopeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ScopeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Scope> CreateScope(Scope scope)
        {
            await _unitOfWork.Scopes.AddAsync(scope);
            await _unitOfWork.CommitAsync();
            return scope;
        }

        public async Task DeleteScope(Scope scope)
        {
            _unitOfWork.Scopes.Remove(scope);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Scope>> GetAllActiveAsync()
        {
            return await _unitOfWork.Scopes.GetAllActiveAsync();
        }

        public async Task<Scope> GetScopeById(int id)
        {
            return await _unitOfWork.Scopes.GetByIdAsync(id);
        }

        public async Task UpdateScope(Scope scopeToBeUpdated, Scope scope)
        {
            scopeToBeUpdated.Name = scope.Name;
            scopeToBeUpdated.Description = scope.Description;
            scopeToBeUpdated.Active = scope.Active;

            await _unitOfWork.CommitAsync();
        }
    }
}
