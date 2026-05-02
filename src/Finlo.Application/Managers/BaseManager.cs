using Finlo.Application.Common.Interfaces.Repositories;
using Finlo.Application.Providers;

namespace Finlo.Application.Managers;

public class BaseManager<TEntity, TKey> : BaseProvider<TEntity, TKey>
    where TEntity : class
    where TKey : IEquatable<TKey>
{
    public BaseManager(IBaseRepository<TEntity, TKey> repository) : base(repository)
    {
    }
}
