using Finlo.Application.Common.Interfaces.Repositories;

namespace Finlo.Application.Providers;

public abstract class BaseProvider<TEntity, TKey>
    where TEntity : class
    where TKey : IEquatable<TKey>
{
    protected readonly IBaseRepository<TEntity, TKey> _repository;

    protected BaseProvider(IBaseRepository<TEntity, TKey> repository)
    {
        _repository = repository;
    }
}