using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameWorkWebAPI.Repositories
{
    interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        //  Task<TEntity> GetById(int id);
        TEntity GetById(int id);
        // Task<TEntity> Insert(TEntity entity);
        void Insert(TEntity entity);
        //    Task<TEntity> Update(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
