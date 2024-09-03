﻿using System.Linq.Expressions;
using Contracts.Interfaces;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace Contracts.Implementation
{
    public abstract class RepositoryBase<T>(RepositoryContext context) : IRepositoryBase<T>
        where T : class
    {
        protected RepositoryContext Context => context;

        public IQueryable<T> FindAll(bool trackChanges) => !trackChanges ? Context.Set<T>().AsNoTracking() : Context.Set<T>();


        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) => !trackChanges ? Context.Set<T>().Where(expression).AsNoTracking() : Context.Set<T>().Where(expression);


        public void Create(T entity) => Context.Set<T>().Add(entity);

        public void Update(T entity) => Context.Set<T>().Update(entity);

        public void Delete(T entity) => Context.Set<T>().Remove(entity);

    }
}
