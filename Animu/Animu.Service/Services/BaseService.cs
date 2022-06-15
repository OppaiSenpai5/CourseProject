using Animu.Data.Entities;
using Animu.Web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animu.Service.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        protected readonly AnimuDbContext context;
        protected readonly DbSet<T> dbSet;

        public BaseService(AnimuDbContext context)
        {
            this.context = context;
            this.dbSet = this.context.Set<T>();
        }

        public IEnumerable<T> GetAll() => this.dbSet.ToHashSet();

        public T Get(Guid id) => this.dbSet.Find(id);

        public void Create(T entity)
        {
            this.dbSet.Add(entity);
            this.context.SaveChanges();
        }

        public void Update(T entity)
        {
            this.dbSet.Update(entity);
            this.context.SaveChanges();
        }

        public void Delete(T entity)
        {
            this.dbSet.Remove(entity);
            this.context.SaveChanges();
        }
    }
}
