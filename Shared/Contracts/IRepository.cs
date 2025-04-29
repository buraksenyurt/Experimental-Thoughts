using Shared;
using Shared.Errors;

namespace Shared.Contracts;

public interface IRepository<TEntity, TError>
    where TError : RepositoryError
{
    Result<TEntity, TError> Get(int entityId);
    Result<IEnumerable<TEntity>, TError> GetAll(int entityId);
    Result<TEntity, TError> Add(TEntity entity);
    Result<TEntity, TError> Update(TEntity entity);
    Result<TEntity, TError> Delete(int entityId);
}
