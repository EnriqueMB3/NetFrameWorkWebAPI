using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using NetFrameWorkWebAPI.Models;

namespace NetFrameWorkWebAPI.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private EmployeesEntities Context { get; set; }
        public Repository(EmployeesEntities Context)
        {
            this.Context = Context;
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }


        public TEntity GetById(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }


        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();

        }
        public void AddorUpdate(TEntity entity)
        {
            Context.Set<TEntity>().AddOrUpdate(entity);
            Context.SaveChanges();

        }
        public void Attach(TEntity entity)
        {
            Context.Set<TEntity>().Attach(entity);
            Context.SaveChanges();

        }


        public void Insert(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }

    }
}