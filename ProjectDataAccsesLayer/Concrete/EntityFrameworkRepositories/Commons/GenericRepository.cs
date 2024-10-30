using Microsoft.EntityFrameworkCore;
using ProjectDataAccsesLayer.Abstract;
using ProjectDataAccsesLayer.EntityFrameworks.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAccsesLayer.Concrete.EntityFrameworkRepositories.Commons;

public class GenericRepository<T> : IGenericRepository<T> where T : class,new()
{
    private readonly FootWearContext _context;
    public DbSet<T> TableEntity=> _context.Set<T>();
    public GenericRepository(FootWearContext context)
    {
        _context = context;
    }

    public async Task<bool> AddAsync(T entity)
    {
        var addedState =await TableEntity.AddAsync(entity);
        return addedState.State == EntityState.Added; 
    }

    public async Task<IEnumerable<T>> GetAllAsync(bool tracking = true)
    {
        if (tracking is false)
        {
        return await TableEntity.AsNoTracking().ToListAsync();
        }
        return await TableEntity.ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)=> await TableEntity.FindAsync(id);
    
    public bool Remove(T entity)
    {
       var removed=TableEntity.Remove(entity);
        return removed.State == EntityState.Deleted;
    }

    public async Task SaveChangesAsync()
    {
      await _context.SaveChangesAsync();
    }

    public bool Update(T entity)
    {
       _context.Entry(entity).State = EntityState.Modified;
        return true;
    }

    async Task<IEnumerable<T>> IGenericRepository<T>.GetWhereAsync(Expression<Func<T, bool>> expression)
        => await TableEntity.Where(expression).ToListAsync();
    
}
