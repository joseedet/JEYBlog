using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JEYBlog.Data.Repository
{
   
        public interface IRepository<TEntity> where TEntity : class
        {
            Task<TEntity> GetById(int id);
            IQueryable<TEntity> GetAll();
            IQueryable<TEntity> GetAll(int pageNumber, string category);
            Task AddAsync(TEntity entity);
            void Update(TEntity entity);
            Task RenoveAsync(TEntity entity);




            Task<bool> SaveAllChangesAsync();
        }


    
}
