﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAccsesLayer.Abstract;

public interface IGenericRepository<T> where T : class,new()
{
    Task<IEnumerable<T>> GetAllAsync(bool tracking = true);
    Task<T> GetByIdAsync(int id);
    Task<bool> AddAsync(T entity);
    Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> expression);
    Task SaveChangesAsync();
    bool Update(T entity);
    bool Remove(T entity);
  
   
}