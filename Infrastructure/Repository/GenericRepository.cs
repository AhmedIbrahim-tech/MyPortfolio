using Core.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class GenericRepository<T> : IAllFunction<T> where T : class
    {
        private readonly DataContext _context;
        private DbSet<T> table = null;
        public GenericRepository(DataContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public void Delete(object id)
        {
            T existing = Details(id);
            table.Remove(existing);
        }

        public List<T> Find()
        {
            return table.ToList();
        }

        public T Details(object id)
        {
            return table.Find(id);
        }

        public void Create(T entity)
        {
            table.Add(entity);
        }

        public void Edit(T entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}