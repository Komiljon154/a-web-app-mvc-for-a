using System.Linq.Expressions;

namespace MusicHub.Core.Interfaces;

/// <summary>
/// Generic repository interface for data access operations.
/// </summary>
/// <typeparam name="TEntity">The type of the entity.</typeparam>
public interface IRepository<TEntity> where TEntity : class
{
    /// <summary>
    /// Gets an entity by its ID.
    /// </summary>
    /// <param name="id">The ID of the entity.</param>
    /// <returns>The entity, or null if not found.</returns>
    ValueTask<TEntity?> GetByIdAsync(int id);

    /// <summary>
    /// Gets all entities.
    /// </summary>
    /// <returns>A collection of all entities.</returns>
    Task<IEnumerable<TEntity>> GetAllAsync();

    /// <summary>
    /// Finds entities based on a predicate.
    /// </summary>
    /// <param name="predicate">The expression to filter entities.</param>
    /// <returns>A collection of entities that match the predicate.</returns>
    IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

    /// <summary>
    /// Adds a new entity.
    /// </summary>
    /// <param name="entity">The entity to add.</param>
    Task AddAsync(TEntity entity);

    /// <summary>
    /// Adds a range of entities.
    /// </summary>
    /// <param name="entities">The entities to add.</param>
    Task AddRangeAsync(IEnumerable<TEntity> entities);

    /// <summary>
    /// Removes an entity.
    /// </summary>
    /// <param name="entity">The entity to remove.</param>
    void Remove(TEntity entity);

    /// <summary>
    /// Removes a range of entities.
    /// </summary>
    /// <param name="entities">The entities to remove.</param>
    void RemoveRange(IEnumerable<TEntity> entities);
}
