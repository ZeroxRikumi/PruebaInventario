using ProyectoInventario.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ProyectoInventario.Data.Repositories;

public interface IGenericRepository<T,TId>
    where T : Base<TId>
{
    Task<T> Insert(T entity);
    Task<T?> GetById(TId id);
    IQueryable<T> GetAll();
    void Update(T entity);
}

public class GenericRepository<T, TId> : IGenericRepository<T, TId>
    where T : Base<TId>
    where TId : IEquatable<TId>
{
    private readonly Context _context;
    protected DbSet<T> Entities => _context.Set<T>();

    protected GenericRepository(Context context)
    {
        _context = context; 
    }

    public async Task<T> Insert(T entity)
    {
        EntityEntry<T> insertedValue = await _context.Set<T>().AddAsync(entity);
        return insertedValue.Entity;
    }

    public virtual async Task<T?> GetById(TId id)
        => await _context.Set<T>()
            .FirstAsync(a => a.Id.Equals(id));


    public IQueryable<T> GetAll()
        => _context.Set<T>();

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }
}
